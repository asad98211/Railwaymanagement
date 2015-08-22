namespace railwaymanagement
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Train = new System.Windows.Forms.CheckBox();
            this.Fare = new System.Windows.Forms.CheckBox();
            this.data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.idk = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 152);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idk);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.Fare);
            this.groupBox1.Controls.Add(this.Train);
            this.groupBox1.Location = new System.Drawing.Point(402, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 184);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Selection";
            // 
            // Train
            // 
            this.Train.AutoSize = true;
            this.Train.Location = new System.Drawing.Point(71, 75);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(76, 17);
            this.Train.TabIndex = 0;
            this.Train.Text = "Train Time";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.CheckedChanged += new System.EventHandler(this.Train_CheckedChanged);
            // 
            // Fare
            // 
            this.Fare.AutoSize = true;
            this.Fare.Location = new System.Drawing.Point(71, 98);
            this.Fare.Name = "Fare";
            this.Fare.Size = new System.Drawing.Size(47, 17);
            this.Fare.TabIndex = 1;
            this.Fare.Text = "Fare";
            this.Fare.UseVisualStyleBackColor = true;
            this.Fare.CheckedChanged += new System.EventHandler(this.Fare_CheckedChanged);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(162, 38);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(100, 20);
            this.data.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(187, 91);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 4;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(187, 138);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 5;
            this.back.Text = "Go Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // idk
            // 
            this.idk.AutoSize = true;
            this.idk.Location = new System.Drawing.Point(71, 123);
            this.idk.Name = "idk";
            this.idk.Size = new System.Drawing.Size(100, 17);
            this.idk.TabIndex = 7;
            this.idk.Text = "IDK Train name";
            this.idk.UseVisualStyleBackColor = true;
            this.idk.CheckedChanged += new System.EventHandler(this.idk_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 225);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Fare;
        private System.Windows.Forms.CheckBox Train;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.CheckBox idk;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}