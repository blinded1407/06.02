namespace _06._02
{
    partial class Line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WriteX = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.WriteZ = new System.Windows.Forms.TextBox();
            this.WriteY = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // WriteX
            // 
            this.WriteX.Location = new System.Drawing.Point(99, 137);
            this.WriteX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteX.Name = "WriteX";
            this.WriteX.Size = new System.Drawing.Size(100, 22);
            this.WriteX.TabIndex = 25;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.Location = new System.Drawing.Point(17, 126);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(87, 49);
            this.x.TabIndex = 24;
            this.x.Text = "X =";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(304, 359);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(260, 60);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(26, 359);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(260, 60);
            this.Calculate.TabIndex = 22;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(26, 177);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(538, 178);
            this.Result.TabIndex = 21;
            // 
            // WriteZ
            // 
            this.WriteZ.Location = new System.Drawing.Point(464, 137);
            this.WriteZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteZ.Name = "WriteZ";
            this.WriteZ.Size = new System.Drawing.Size(100, 22);
            this.WriteZ.TabIndex = 17;
            // 
            // WriteY
            // 
            this.WriteY.Location = new System.Drawing.Point(277, 137);
            this.WriteY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteY.Name = "WriteY";
            this.WriteY.Size = new System.Drawing.Size(100, 22);
            this.WriteY.TabIndex = 16;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z.Location = new System.Drawing.Point(383, 126);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(85, 49);
            this.z.TabIndex = 15;
            this.z.Text = "Z =";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y.Location = new System.Drawing.Point(200, 126);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(86, 49);
            this.y.TabIndex = 14;
            this.y.Text = "Y =";
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WriteX);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.WriteZ);
            this.Controls.Add(this.WriteY);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Line";
            this.Text = "Branches";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox WriteX;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox WriteZ;
        private System.Windows.Forms.TextBox WriteY;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label y;
    }
}