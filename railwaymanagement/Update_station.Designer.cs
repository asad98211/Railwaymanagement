namespace railwaymanagement
{
    partial class Update_station
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_station));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.no_emp = new System.Windows.Forms.TextBox();
            this.STname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.No_plat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Station_id = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(53, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 228);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Station_id:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(325, 159);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 23);
            this.Add.TabIndex = 24;
            this.Add.Text = "Update";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Station_Name:";
            // 
            // no_emp
            // 
            this.no_emp.Location = new System.Drawing.Point(325, 118);
            this.no_emp.Name = "no_emp";
            this.no_emp.Size = new System.Drawing.Size(100, 20);
            this.no_emp.TabIndex = 23;
            // 
            // STname
            // 
            this.STname.Location = new System.Drawing.Point(90, 118);
            this.STname.Name = "STname";
            this.STname.Size = new System.Drawing.Size(100, 20);
            this.STname.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "#of Employee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "#Of Platform:";
            // 
            // No_plat
            // 
            this.No_plat.Location = new System.Drawing.Point(325, 72);
            this.No_plat.Name = "No_plat";
            this.No_plat.Size = new System.Drawing.Size(100, 20);
            this.No_plat.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Station_id);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.no_emp);
            this.groupBox1.Controls.Add(this.STname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.No_plat);
            this.groupBox1.Location = new System.Drawing.Point(264, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 221);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Station Info";
            // 
            // Station_id
            // 
            this.Station_id.FormattingEnabled = true;
            this.Station_id.Location = new System.Drawing.Point(89, 76);
            this.Station_id.Name = "Station_id";
            this.Station_id.Size = new System.Drawing.Size(101, 21);
            this.Station_id.TabIndex = 26;
            this.Station_id.SelectedIndexChanged += new System.EventHandler(this.Station_id_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(90, 158);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 23);
            this.Back.TabIndex = 25;
            this.Back.Text = "Go Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 155);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Update_station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Update_station";
            this.Text = "Update_station";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox no_emp;
        private System.Windows.Forms.TextBox STname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox No_plat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Station_id;
    }
}