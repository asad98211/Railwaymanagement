namespace railwaymanagement
{
    partial class Book_Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Ticket));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Options = new System.Windows.Forms.GroupBox();
            this.back = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bstation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 150);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Options
            // 
            this.Options.Controls.Add(this.back);
            this.Options.Controls.Add(this.print);
            this.Options.Controls.Add(this.destination);
            this.Options.Controls.Add(this.label2);
            this.Options.Controls.Add(this.Bstation);
            this.Options.Controls.Add(this.label1);
            this.Options.Location = new System.Drawing.Point(336, 200);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(361, 180);
            this.Options.TabIndex = 41;
            this.Options.TabStop = false;
            this.Options.Text = "Passenger Info";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(148, 123);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 5;
            this.back.Text = "Go Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(268, 123);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 4;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(243, 71);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(100, 20);
            this.destination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // Bstation
            // 
            this.Bstation.Location = new System.Drawing.Point(243, 33);
            this.Bstation.Name = "Bstation";
            this.Bstation.Size = new System.Drawing.Size(100, 20);
            this.Bstation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boardin Station";
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 413);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Book_Ticket";
            this.Text = "Book_Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Bstation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button print;
    }
}