namespace railwaymanagement
{
    partial class insert_train
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insert_train));
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Tname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.offday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.No_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Train_id:";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(69, 57);
            this.Id.Name = "Id";
            this.Id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 2;
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(69, 103);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(100, 20);
            this.Tname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Train_name:";
            // 
            // offday
            // 
            this.offday.Location = new System.Drawing.Point(69, 149);
            this.offday.Name = "offday";
            this.offday.Size = new System.Drawing.Size(100, 20);
            this.offday.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Off_day:";
            // 
            // No_pass
            // 
            this.No_pass.Location = new System.Drawing.Point(304, 57);
            this.No_pass.Name = "No_pass";
            this.No_pass.Size = new System.Drawing.Size(100, 20);
            this.No_pass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "#Of Passenger:";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(304, 103);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(100, 20);
            this.capacity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Capacity:";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(304, 144);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 228);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.Tname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.capacity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.No_pass);
            this.groupBox1.Controls.Add(this.offday);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(293, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 218);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Train Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 151);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(304, 186);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(99, 23);
            this.Back.TabIndex = 12;
            this.Back.Text = "Go Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // insert_train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "insert_train";
            this.Text = "insert_train";
            this.Load += new System.EventHandler(this.insert_train_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox offday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox No_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}