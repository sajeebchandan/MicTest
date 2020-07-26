namespace Mic_Test
{
    partial class MicTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicTest));
            this.listViewSources = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefreshMicro0phone = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.timerGraph = new System.Windows.Forms.Timer(this.components);
            this.progressBarL = new System.Windows.Forms.ProgressBar();
            this.progressBarR = new System.Windows.Forms.ProgressBar();
            this.pictureBoxGraphVisualizer = new System.Windows.Forms.PictureBox();
            this.checkBoxLoopback = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphVisualizer)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSources
            // 
            this.listViewSources.BackColor = System.Drawing.Color.White;
            this.listViewSources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewSources.ForeColor = System.Drawing.Color.Black;
            this.listViewSources.FullRowSelect = true;
            this.listViewSources.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSources.HideSelection = false;
            this.listViewSources.Location = new System.Drawing.Point(7, 46);
            this.listViewSources.MultiSelect = false;
            this.listViewSources.Name = "listViewSources";
            this.listViewSources.ShowItemToolTips = true;
            this.listViewSources.Size = new System.Drawing.Size(460, 87);
            this.listViewSources.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSources.TabIndex = 0;
            this.listViewSources.UseCompatibleStateImageBehavior = false;
            this.listViewSources.View = System.Windows.Forms.View.Details;
            this.listViewSources.SelectedIndexChanged += new System.EventHandler(this.listViewSources_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 370;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            this.columnHeader2.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonRefreshMicro0phone);
            this.groupBox1.Controls.Add(this.listViewSources);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Device";
            // 
            // buttonRefreshMicro0phone
            // 
            this.buttonRefreshMicro0phone.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRefreshMicro0phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshMicro0phone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRefreshMicro0phone.FlatAppearance.BorderSize = 0;
            this.buttonRefreshMicro0phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshMicro0phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshMicro0phone.ForeColor = System.Drawing.Color.Black;
            this.buttonRefreshMicro0phone.Location = new System.Drawing.Point(7, 20);
            this.buttonRefreshMicro0phone.Name = "buttonRefreshMicro0phone";
            this.buttonRefreshMicro0phone.Size = new System.Drawing.Size(460, 20);
            this.buttonRefreshMicro0phone.TabIndex = 5;
            this.buttonRefreshMicro0phone.Text = "Refresh Device List";
            this.buttonRefreshMicro0phone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefreshMicro0phone.UseVisualStyleBackColor = false;
            this.buttonRefreshMicro0phone.Click += new System.EventHandler(this.buttonRefreshMicro0phone_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCheck.Enabled = false;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.ForeColor = System.Drawing.Color.Black;
            this.buttonCheck.Location = new System.Drawing.Point(12, 158);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(473, 29);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Start";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // timerGraph
            // 
            this.timerGraph.Enabled = true;
            this.timerGraph.Interval = 1;
            this.timerGraph.Tick += new System.EventHandler(this.timerGraph_Tick);
            // 
            // progressBarL
            // 
            this.progressBarL.BackColor = System.Drawing.Color.White;
            this.progressBarL.Location = new System.Drawing.Point(12, 261);
            this.progressBarL.Name = "progressBarL";
            this.progressBarL.Size = new System.Drawing.Size(235, 2);
            this.progressBarL.Step = 1;
            this.progressBarL.TabIndex = 6;
            // 
            // progressBarR
            // 
            this.progressBarR.BackColor = System.Drawing.Color.White;
            this.progressBarR.Location = new System.Drawing.Point(250, 261);
            this.progressBarR.Name = "progressBarR";
            this.progressBarR.Size = new System.Drawing.Size(235, 2);
            this.progressBarR.Step = 1;
            this.progressBarR.TabIndex = 7;
            // 
            // pictureBoxGraphVisualizer
            // 
            this.pictureBoxGraphVisualizer.BackColor = System.Drawing.Color.White;
            this.pictureBoxGraphVisualizer.Location = new System.Drawing.Point(12, 191);
            this.pictureBoxGraphVisualizer.Name = "pictureBoxGraphVisualizer";
            this.pictureBoxGraphVisualizer.Size = new System.Drawing.Size(473, 66);
            this.pictureBoxGraphVisualizer.TabIndex = 4;
            this.pictureBoxGraphVisualizer.TabStop = false;
            // 
            // checkBoxLoopback
            // 
            this.checkBoxLoopback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLoopback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLoopback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoopback.Location = new System.Drawing.Point(419, 2);
            this.checkBoxLoopback.Name = "checkBoxLoopback";
            this.checkBoxLoopback.Size = new System.Drawing.Size(76, 17);
            this.checkBoxLoopback.TabIndex = 8;
            this.checkBoxLoopback.Text = "Loopback";
            this.checkBoxLoopback.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxLoopback.UseVisualStyleBackColor = true;
            this.checkBoxLoopback.CheckedChanged += new System.EventHandler(this.checkBoxLoopback_CheckedChanged);
            // 
            // MicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(497, 269);
            this.Controls.Add(this.checkBoxLoopback);
            this.Controls.Add(this.progressBarR);
            this.Controls.Add(this.progressBarL);
            this.Controls.Add(this.pictureBoxGraphVisualizer);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MicTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mic Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MicTest_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphVisualizer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSources;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonRefreshMicro0phone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timerGraph;
        private System.Windows.Forms.ProgressBar progressBarL;
        private System.Windows.Forms.ProgressBar progressBarR;
        private System.Windows.Forms.PictureBox pictureBoxGraphVisualizer;
        private System.Windows.Forms.CheckBox checkBoxLoopback;
    }
}

