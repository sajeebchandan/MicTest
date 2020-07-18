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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicTest));
            this.listViewSources = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.pictureBoxGraphVisualizer = new System.Windows.Forms.PictureBox();
            this.buttonRefreshMicro0phone = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphVisualizer)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSources
            // 
            this.listViewSources.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listViewSources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSources.ForeColor = System.Drawing.Color.Lime;
            this.listViewSources.FullRowSelect = true;
            this.listViewSources.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSources.HideSelection = false;
            this.listViewSources.Location = new System.Drawing.Point(7, 46);
            this.listViewSources.Name = "listViewSources";
            this.listViewSources.Size = new System.Drawing.Size(364, 103);
            this.listViewSources.TabIndex = 0;
            this.listViewSources.UseCompatibleStateImageBehavior = false;
            this.listViewSources.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.buttonRefreshMicro0phone);
            this.groupBox1.Controls.Add(this.listViewSources);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Microphone";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Green;
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCheck.Enabled = false;
            this.buttonCheck.FlatAppearance.BorderSize = 0;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCheck.Location = new System.Drawing.Point(15, 177);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(377, 29);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Start";
            this.buttonCheck.UseVisualStyleBackColor = false;
            // 
            // pictureBoxGraphVisualizer
            // 
            this.pictureBoxGraphVisualizer.Location = new System.Drawing.Point(15, 213);
            this.pictureBoxGraphVisualizer.Name = "pictureBoxGraphVisualizer";
            this.pictureBoxGraphVisualizer.Size = new System.Drawing.Size(377, 174);
            this.pictureBoxGraphVisualizer.TabIndex = 4;
            this.pictureBoxGraphVisualizer.TabStop = false;
            // 
            // buttonRefreshMicro0phone
            // 
            this.buttonRefreshMicro0phone.BackColor = System.Drawing.Color.Green;
            this.buttonRefreshMicro0phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshMicro0phone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRefreshMicro0phone.FlatAppearance.BorderSize = 0;
            this.buttonRefreshMicro0phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshMicro0phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshMicro0phone.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRefreshMicro0phone.Location = new System.Drawing.Point(7, 20);
            this.buttonRefreshMicro0phone.Name = "buttonRefreshMicro0phone";
            this.buttonRefreshMicro0phone.Size = new System.Drawing.Size(364, 20);
            this.buttonRefreshMicro0phone.TabIndex = 5;
            this.buttonRefreshMicro0phone.Text = "Refresh Microphone List";
            this.buttonRefreshMicro0phone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefreshMicro0phone.UseVisualStyleBackColor = false;
            this.buttonRefreshMicro0phone.Click += new System.EventHandler(this.buttonRefreshMicro0phone_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 294;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            this.columnHeader2.Width = 70;
            // 
            // MicTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Mic_Test.Properties.Resources.microphone__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(404, 399);
            this.Controls.Add(this.pictureBoxGraphVisualizer);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MicTest";
            this.Text = "Mic Test";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraphVisualizer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSources;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.PictureBox pictureBoxGraphVisualizer;
        private System.Windows.Forms.Button buttonRefreshMicro0phone;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

