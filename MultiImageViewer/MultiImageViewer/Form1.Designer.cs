namespace MultiImageViewer
{
    partial class MIV
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.sBtn2 = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.sBtn1 = new System.Windows.Forms.Button();
            this.clear1 = new System.Windows.Forms.Button();
            this.clear2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(26, 47);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(216, 20);
            this.box1.TabIndex = 2;
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(26, 73);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(216, 380);
            this.img1.TabIndex = 3;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(414, 73);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(216, 380);
            this.img2.TabIndex = 6;
            this.img2.TabStop = false;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(414, 47);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(216, 20);
            this.box2.TabIndex = 5;
            // 
            // sBtn2
            // 
            this.sBtn2.Location = new System.Drawing.Point(414, 12);
            this.sBtn2.Name = "sBtn2";
            this.sBtn2.Size = new System.Drawing.Size(216, 23);
            this.sBtn2.TabIndex = 4;
            this.sBtn2.Text = "Search";
            this.sBtn2.UseVisualStyleBackColor = true;
            this.sBtn2.Click += new System.EventHandler(this.sBtn2_Click);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(248, 45);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(135, 407);
            this.list1.TabIndex = 7;
            this.list1.Click += new System.EventHandler(this.list1_Click);
            this.list1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.list1_KeyUp);
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(636, 45);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(135, 407);
            this.list2.TabIndex = 8;
            this.list2.Click += new System.EventHandler(this.list2_Click);
            this.list2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.list2_KeyUp);
            // 
            // sBtn1
            // 
            this.sBtn1.Location = new System.Drawing.Point(26, 12);
            this.sBtn1.Name = "sBtn1";
            this.sBtn1.Size = new System.Drawing.Size(216, 23);
            this.sBtn1.TabIndex = 9;
            this.sBtn1.Text = "Search";
            this.sBtn1.UseVisualStyleBackColor = true;
            this.sBtn1.Click += new System.EventHandler(this.sBtn1_Click);
            // 
            // clear1
            // 
            this.clear1.Location = new System.Drawing.Point(249, 12);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(134, 23);
            this.clear1.TabIndex = 10;
            this.clear1.Text = "Clear";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(this.clear1_Click);
            // 
            // clear2
            // 
            this.clear2.Location = new System.Drawing.Point(637, 12);
            this.clear2.Name = "clear2";
            this.clear2.Size = new System.Drawing.Size(134, 23);
            this.clear2.TabIndex = 11;
            this.clear2.Text = "Clear";
            this.clear2.UseVisualStyleBackColor = true;
            this.clear2.Click += new System.EventHandler(this.clear2_Click);
            // 
            // MIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 458);
            this.Controls.Add(this.clear2);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.sBtn1);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.sBtn2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.box1);
            this.Name = "MIV";
            this.Text = "MIV";
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Button sBtn2;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Button sBtn1;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button clear2;
    }
}

