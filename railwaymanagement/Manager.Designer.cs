namespace railwaymanagement
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Options = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JourneyDay = new System.Windows.Forms.DateTimePicker();
            this.Logoff = new System.Windows.Forms.Button();
            this.Operation = new System.Windows.Forms.Button();
            this.Train_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.clockTck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 217);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 150);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.label2);
            this.Options.Controls.Add(this.JourneyDay);
            this.Options.Controls.Add(this.Logoff);
            this.Options.Controls.Add(this.Operation);
            this.Options.Controls.Add(this.Train_Name);
            this.Options.Controls.Add(this.label1);
            this.Options.Controls.Add(this.checkBox2);
            this.Options.Controls.Add(this.checkBox1);
            this.Options.Location = new System.Drawing.Point(336, 218);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(361, 180);
            this.Options.TabIndex = 39;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // JourneyDay
            // 
            this.JourneyDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JourneyDay.Location = new System.Drawing.Point(245, 41);
            this.JourneyDay.Name = "JourneyDay";
            this.JourneyDay.Size = new System.Drawing.Size(95, 20);
            this.JourneyDay.TabIndex = 7;
            this.JourneyDay.ValueChanged += new System.EventHandler(this.JourneyDay_ValueChanged);
            // 
            // Logoff
            // 
            this.Logoff.Location = new System.Drawing.Point(245, 122);
            this.Logoff.Name = "Logoff";
            this.Logoff.Size = new System.Drawing.Size(75, 23);
            this.Logoff.TabIndex = 6;
            this.Logoff.Text = "Log Out";
            this.Logoff.UseVisualStyleBackColor = true;
            this.Logoff.Click += new System.EventHandler(this.Logoff_Click);
            // 
            // Operation
            // 
            this.Operation.Location = new System.Drawing.Point(245, 81);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(75, 23);
            this.Operation.TabIndex = 5;
            this.Operation.Text = "Operation";
            this.Operation.UseVisualStyleBackColor = true;
            this.Operation.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Train_Name
            // 
            this.Train_Name.Location = new System.Drawing.Point(77, 38);
            this.Train_Name.Name = "Train_Name";
            this.Train_Name.Size = new System.Drawing.Size(89, 20);
            this.Train_Name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Train Name";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(66, 120);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ticket";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Check Seat";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // clockTck
            // 
            this.clockTck.AutoSize = true;
            this.clockTck.Location = new System.Drawing.Point(578, 202);
            this.clockTck.Name = "clockTck";
            this.clockTck.Size = new System.Drawing.Size(30, 13);
            this.clockTck.TabIndex = 40;
            this.clockTck.Text = "Time";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.clockTck);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Train_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Operation;
        private System.Windows.Forms.Button Logoff;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label clockTck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker JourneyDay;
    }
}