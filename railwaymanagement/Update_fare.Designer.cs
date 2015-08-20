namespace railwaymanagement
{
    partial class Update_fare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_fare));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Back = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prev_st_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Station_Id = new System.Windows.Forms.TextBox();
            this.train_id = new System.Windows.Forms.ComboBox();
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
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 150);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.train_id);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Station_Id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.prev_st_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.distance);
            this.groupBox1.Controls.Add(this.cost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(251, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 233);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Fare Info";
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
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Station_id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Train_id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Previous Station:";
            // 
            // prev_st_id
            // 
            this.prev_st_id.Location = new System.Drawing.Point(125, 149);
            this.prev_st_id.Name = "prev_st_id";
            this.prev_st_id.Size = new System.Drawing.Size(100, 20);
            this.prev_st_id.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Distance:";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(338, 57);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(100, 20);
            this.distance.TabIndex = 21;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(338, 103);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 20);
            this.cost.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cost:";
            // 
            // Station_Id
            // 
            this.Station_Id.Location = new System.Drawing.Point(125, 54);
            this.Station_Id.Name = "Station_Id";
            this.Station_Id.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Station_Id.Size = new System.Drawing.Size(100, 20);
            this.Station_Id.TabIndex = 15;
            // 
            // train_id
            // 
            this.train_id.FormattingEnabled = true;
            this.train_id.Location = new System.Drawing.Point(125, 106);
            this.train_id.Name = "train_id";
            this.train_id.Size = new System.Drawing.Size(100, 21);
            this.train_id.TabIndex = 35;
            this.train_id.SelectedIndexChanged += new System.EventHandler(this.train_id_SelectedIndexChanged);
            // 
            // Update_fare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Update_fare";
            this.Text = "Update_fare";
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
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prev_st_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox train_id;
        private System.Windows.Forms.TextBox Station_Id;
    }
}