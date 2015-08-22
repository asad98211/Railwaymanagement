namespace railwaymanagement
{
    partial class Station_Master_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Station_Master_Panel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Stops = new System.Windows.Forms.CheckBox();
            this.Train = new System.Windows.Forms.CheckBox();
            this.Employee = new System.Windows.Forms.CheckBox();
            this.Logout = new System.Windows.Forms.Button();
            this.Oparation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 150);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 217);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Oparation);
            this.groupBox1.Controls.Add(this.Employee);
            this.groupBox1.Controls.Add(this.Train);
            this.groupBox1.Controls.Add(this.Stops);
            this.groupBox1.Location = new System.Drawing.Point(423, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 223);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select One";
            // 
            // Stops
            // 
            this.Stops.AutoSize = true;
            this.Stops.Location = new System.Drawing.Point(48, 128);
            this.Stops.Name = "Stops";
            this.Stops.Size = new System.Drawing.Size(53, 17);
            this.Stops.TabIndex = 0;
            this.Stops.Text = "Stops";
            this.Stops.UseVisualStyleBackColor = true;
            this.Stops.CheckedChanged += new System.EventHandler(this.Stops_CheckedChanged);
            // 
            // Train
            // 
            this.Train.AutoSize = true;
            this.Train.Location = new System.Drawing.Point(48, 82);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(50, 17);
            this.Train.TabIndex = 1;
            this.Train.Text = "Train";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.CheckedChanged += new System.EventHandler(this.Train_CheckedChanged);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(48, 105);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(72, 17);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.CheckedChanged += new System.EventHandler(this.Employee_CheckedChanged);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(320, 354);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 41);
            this.Logout.TabIndex = 40;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Oparation
            // 
            this.Oparation.Location = new System.Drawing.Point(152, 122);
            this.Oparation.Name = "Oparation";
            this.Oparation.Size = new System.Drawing.Size(85, 23);
            this.Oparation.TabIndex = 41;
            this.Oparation.Text = "Oparation";
            this.Oparation.UseVisualStyleBackColor = true;
            this.Oparation.Click += new System.EventHandler(this.Oparation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(161, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Station_Master_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Station_Master_Panel";
            this.Text = "Station_Master_Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Employee;
        private System.Windows.Forms.CheckBox Train;
        private System.Windows.Forms.CheckBox Stops;
        private System.Windows.Forms.Button Oparation;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label1;
    }
}