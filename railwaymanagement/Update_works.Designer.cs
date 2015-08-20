namespace railwaymanagement
{
    partial class Update_works
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_works));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.Button();
            this.St_id = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Jdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Start_time = new System.Windows.Forms.TextBox();
            this.End_time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Emp_id = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 217);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 150);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Emp_id);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.St_id);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Jdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Start_time);
            this.groupBox1.Controls.Add(this.End_time);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(251, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 233);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Worker Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(338, 192);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 23);
            this.Back.TabIndex = 34;
            this.Back.Text = "Go Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // St_id
            // 
            this.St_id.Location = new System.Drawing.Point(125, 103);
            this.St_id.Name = "St_id";
            this.St_id.Size = new System.Drawing.Size(100, 20);
            this.St_id.TabIndex = 17;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(338, 152);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 23);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Employee_id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Station_id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Joining_Date:";
            // 
            // Jdate
            // 
            this.Jdate.Location = new System.Drawing.Point(125, 149);
            this.Jdate.Name = "Jdate";
            this.Jdate.Size = new System.Drawing.Size(100, 20);
            this.Jdate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Start_Time:";
            // 
            // Start_time
            // 
            this.Start_time.Location = new System.Drawing.Point(338, 57);
            this.Start_time.Name = "Start_time";
            this.Start_time.Size = new System.Drawing.Size(100, 20);
            this.Start_time.TabIndex = 21;
            // 
            // End_time
            // 
            this.End_time.Location = new System.Drawing.Point(338, 103);
            this.End_time.Name = "End_time";
            this.End_time.Size = new System.Drawing.Size(100, 20);
            this.End_time.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "End_Time:";
            // 
            // Emp_id
            // 
            this.Emp_id.FormattingEnabled = true;
            this.Emp_id.Location = new System.Drawing.Point(125, 57);
            this.Emp_id.Name = "Emp_id";
            this.Emp_id.Size = new System.Drawing.Size(100, 21);
            this.Emp_id.TabIndex = 35;
            this.Emp_id.SelectedIndexChanged += new System.EventHandler(this.Emp_id_SelectedIndexChanged);
            // 
            // Update_works
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Update_works";
            this.Text = "Update_works";
            this.Load += new System.EventHandler(this.Update_works_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox St_id;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Jdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Start_time;
        private System.Windows.Forms.TextBox End_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Emp_id;
    }
}