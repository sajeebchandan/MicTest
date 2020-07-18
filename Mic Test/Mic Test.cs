using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mic_Test
{
    public partial class MicTest : Form
    {
        public MicTest()
        {
            InitializeComponent();
        }

        private void buttonRefreshMicro0phone_Click(object sender, EventArgs e)
        {
            var sources = new List<WaveInCapabilities>();
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                sources.Add(WaveIn.GetCapabilities(i));
            }
            listViewSources.Items.Clear();
            foreach (var source in sources)
            {
                ListViewItem listViewItem = new ListViewItem(source.ProductName);
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, source.Channels.ToString()));
                listViewSources.Items.Add(listViewItem);
            }
        }
    }
}
