namespace railwaymanagement
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.CheckBox();
            this.Station = new System.Windows.Forms.CheckBox();
            this.Employee = new System.Windows.Forms.CheckBox();
            this.Fare = new System.Windows.Forms.CheckBox();
            this.Works = new System.Windows.Forms.CheckBox();
            this.Stops = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(191, 8);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(83, 50);
            this.insert.TabIndex = 1;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(191, 75);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(83, 50);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(191, 141);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(83, 50);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(287, 351);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(83, 50);
            this.logout.TabIndex = 4;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Train
            // 
            this.Train.AutoSize = true;
            this.Train.Location = new System.Drawing.Point(69, 8);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(50, 17);
            this.Train.TabIndex = 5;
            this.Train.Text = "Train";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.CheckedChanged += new System.EventHandler(this.Train_CheckedChanged);
            // 
            // Station
            // 
            this.Station.AutoSize = true;
            this.Station.Location = new System.Drawing.Point(69, 41);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(59, 17);
            this.Station.TabIndex = 6;
            this.Station.Text = "Station";
            this.Station.UseVisualStyleBackColor = true;
            this.Station.CheckedChanged += new System.EventHandler(this.Station_CheckedChanged);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(69, 75);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(72, 17);
            this.Employee.TabIndex = 7;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.CheckedChanged += new System.EventHandler(this.Employee_CheckedChanged);
            // 
            // Fare
            // 
            this.Fare.AutoSize = true;
            this.Fare.Location = new System.Drawing.Point(69, 175);
            this.Fare.Name = "Fare";
            this.Fare.Size = new System.Drawing.Size(47, 17);
            this.Fare.TabIndex = 10;
            this.Fare.Text = "Fare";
            this.Fare.UseVisualStyleBackColor = true;
            this.Fare.CheckedChanged += new System.EventHandler(this.Fare_CheckedChanged);
            // 
            // Works
            // 
            this.Works.AutoSize = true;
            this.Works.Location = new System.Drawing.Point(69, 141);
            this.Works.Name = "Works";
            this.Works.Size = new System.Drawing.Size(57, 17);
            this.Works.TabIndex = 9;
            this.Works.Text = "Works";
            this.Works.UseVisualStyleBackColor = true;
            this.Works.CheckedChanged += new System.EventHandler(this.Works_CheckedChanged);
            // 
            // Stops
            // 
            this.Stops.AutoSize = true;
            this.Stops.Location = new System.Drawing.Point(69, 108);
            this.Stops.Name = "Stops";
            this.Stops.Size = new System.Drawing.Size(51, 17);
            this.Stops.TabIndex = 8;
            this.Stops.Text = "stops";
            this.Stops.UseVisualStyleBackColor = true;
            this.Stops.CheckedChanged += new System.EventHandler(this.Stops_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.Fare);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.Works);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.Stops);
            this.groupBox1.Controls.Add(this.Train);
            this.groupBox1.Controls.Add(this.Employee);
            this.groupBox1.Controls.Add(this.Station);
            this.groupBox1.Location = new System.Drawing.Point(397, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 208);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select one";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 225);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.CheckBox Train;
        private System.Windows.Forms.CheckBox Station;
        private System.Windows.Forms.CheckBox Employee;
        private System.Windows.Forms.CheckBox Fare;
        private System.Windows.Forms.CheckBox Works;
        private System.Windows.Forms.CheckBox Stops;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}