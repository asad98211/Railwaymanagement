namespace railwaymanagement
{
    partial class Sign_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in));
            this.login = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.User_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(228, 107);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(59, 25);
            this.login.TabIndex = 0;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // information
            // 
            this.information.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.information.Image = ((System.Drawing.Image)(resources.GetObject("information.Image")));
            this.information.Location = new System.Drawing.Point(12, 181);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(335, 216);
            this.information.TabIndex = 1;
            this.information.Text = "Info";
            this.information.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.information.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.information.UseVisualStyleBackColor = true;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(187, 30);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(100, 20);
            this.User_name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(187, 72);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.User_name);
            this.groupBox1.Location = new System.Drawing.Point(386, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 152);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.information);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Sign_in";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Welcome to Bangladesh Railway";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

