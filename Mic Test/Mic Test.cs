using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mic_Test
{
    public partial class MicTest : Form
    {
        private const CaptureMode captureMode = CaptureMode.Capture;
        private readonly GraphVisualization _graphVisualization = new GraphVisualization();
        private float l = 0;
        private float r = 0;
        private MMDevice _selectedDevice;
        private WasapiCapture _soundIn;
        private IWaveSource _finalSource;
        private ISoundOut _soundOut;
        public MicTest()
        {
            InitializeComponent();
            RefreshDevices();
        }
        public MMDevice SelectedDevice
        {
            get { return _selectedDevice; }
            set
            {
                _selectedDevice = value;
                if (value != null)
                    buttonCheck.Enabled = true;
            }
        }
        private void RefreshDevices()
        {
            listViewSources.Items.Clear();

            using (var deviceEnumerator = new MMDeviceEnumerator())
            using (var deviceCollection = deviceEnumerator.EnumAudioEndpoints(
                captureMode == CaptureMode.Capture ? DataFlow.Capture : DataFlow.Render, DeviceState.Active))
            {
                foreach (var device in deviceCollection)
                {
                    var deviceFormat = WaveFormatFromBlob(device.PropertyStore[
                        new PropertyKey(new Guid(0xf19f064d, 0x82c, 0x4e27, 0xbc, 0x73, 0x68, 0x82, 0xa1, 0xbb, 0x8e, 0x4c), 0)].BlobValue);

                    var item = new ListViewItem(device.FriendlyName) { Tag = device };
                    item.SubItems.Add(deviceFormat.Channels.ToString(CultureInfo.InvariantCulture));

                    listViewSources.Items.Add(item);
                }
            }
        }
        private static WaveFormat WaveFormatFromBlob(Blob blob)
        {
            if (blob.Length == 40)
                return (WaveFormat)Marshal.PtrToStructure(blob.Data, typeof(WaveFormatExtensible));
            return (WaveFormat)Marshal.PtrToStructure(blob.Data, typeof(WaveFormat));
        }

        private void buttonRefreshMicro0phone_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (listViewSources.SelectedItems.Count > 0)
            {
                if (_soundIn == null)
                {
                    if (SelectedDevice == null)
                        return;

                    buttonCheck.Enabled = false;
                    if (captureMode == CaptureMode.Capture)
                        _soundIn = new WasapiCapture();
                    else
                        _soundIn = new WasapiLoopbackCapture();

                    _soundIn.Device = SelectedDevice;
                    _soundIn.Initialize();

                    var soundInSource = new SoundInSource(_soundIn);
                    //{ FillWithZeros = true };            

                    var singleBlockNotificationStream = new SingleBlockNotificationStream(soundInSource.ToSampleSource());
                    _finalSource = singleBlockNotificationStream.ToWaveSource();

                    singleBlockNotificationStream.SingleBlockRead += SingleBlockNotificationStreamOnSingleBlockRead;

                    _soundIn.Start();
                    _soundOut = new WasapiOut();
                    _soundOut.Initialize(_finalSource);
                    _soundOut.Play();
                    buttonCheck.Enabled = true;
                    buttonRefreshMicro0phone.Enabled = false;
                    listViewSources.Enabled = false;
                    buttonCheck.Text = "Stop";
                }
                else
                {
                    buttonCheck.Enabled = false;
                    _soundOut.Stop();
                    _soundOut.Dispose();
                    _soundIn.Stop();
                    _soundIn.Dispose();
                    _soundOut = null;
                    _soundIn = null;
                    buttonCheck.Enabled = true;
                    listViewSources.Enabled = true;
                    buttonRefreshMicro0phone.Enabled = true;
                    buttonCheck.Text = "Start";
                }
            }
            else
            {
                MessageBox.Show("Reload & Select a Microphone");
            }
        }

        private void SingleBlockNotificationStreamOnSingleBlockRead(object sender, SingleBlockReadEventArgs e)
        {
            l = e.Left;
            r = e.Right;
            _graphVisualization.AddSamples(e.Left, e.Right);
        }

        private void listViewSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSources.SelectedItems.Count > 0)
            {
                SelectedDevice = (MMDevice)listViewSources.SelectedItems[0].Tag;
                buttonCheck.Enabled = true;
            }
            else
            {
                SelectedDevice = null;
            }
        }

        private void timerGraph_Tick(object sender, EventArgs e)
        {
            progressBarL.Value = Math.Abs(Convert.ToInt32(l * 100));
            progressBarR.Value = Math.Abs(Convert.ToInt32(r * 100));
            var image = pictureBoxGraphVisualizer.Image;
            pictureBoxGraphVisualizer.Image = _graphVisualization.Draw(pictureBoxGraphVisualizer.Width, pictureBoxGraphVisualizer.Height);
            if (image != null)
                image.Dispose();
        }

        private void MicTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_soundOut != null)
            {
                _soundOut.Stop();
                _soundOut.Dispose();
                _soundOut = null;
            }
            if (_soundIn != null)
            {
                _soundIn.Stop();
                _soundIn.Dispose();
                _soundIn = null;
            }
        }
    }

    public enum CaptureMode
    {
        Capture,
        LoopbackCapture
    }
}
