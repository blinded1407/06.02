namespace _06._02
{
    partial class Branches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Branches));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WriteX = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.WriteY = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.Label();
            this.cosX = new System.Windows.Forms.RadioButton();
            this.sqrX = new System.Windows.Forms.RadioButton();
            this.expX = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // WriteX
            // 
            this.WriteX.Location = new System.Drawing.Point(163, 121);
            this.WriteX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteX.Name = "WriteX";
            this.WriteX.Size = new System.Drawing.Size(100, 22);
            this.WriteX.TabIndex = 35;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.Location = new System.Drawing.Point(84, 107);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(87, 49);
            this.x.TabIndex = 34;
            this.x.Text = "X =";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(297, 380);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(173, 60);
            this.Clear.TabIndex = 33;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(93, 380);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(173, 60);
            this.Calculate.TabIndex = 32;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(93, 198);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(377, 178);
            this.Result.TabIndex = 31;
            // 
            // WriteY
            // 
            this.WriteY.Location = new System.Drawing.Point(370, 121);
            this.WriteY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WriteY.Name = "WriteY";
            this.WriteY.Size = new System.Drawing.Size(100, 22);
            this.WriteY.TabIndex = 29;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y.Location = new System.Drawing.Point(293, 107);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(86, 49);
            this.y.TabIndex = 27;
            this.y.Text = "Y =";
            // 
            // cosX
            // 
            this.cosX.AutoSize = true;
            this.cosX.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cosX.Location = new System.Drawing.Point(93, 159);
            this.cosX.Name = "cosX";
            this.cosX.Size = new System.Drawing.Size(107, 34);
            this.cosX.TabIndex = 37;
            this.cosX.TabStop = true;
            this.cosX.Text = "cos(x)";
            this.cosX.UseVisualStyleBackColor = true;
            // 
            // sqrX
            // 
            this.sqrX.AutoSize = true;
            this.sqrX.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrX.Location = new System.Drawing.Point(231, 159);
            this.sqrX.Name = "sqrX";
            this.sqrX.Size = new System.Drawing.Size(103, 34);
            this.sqrX.TabIndex = 38;
            this.sqrX.TabStop = true;
            this.sqrX.Text = "sqr(x)";
            this.sqrX.UseVisualStyleBackColor = true;
            // 
            // expX
            // 
            this.expX.AutoSize = true;
            this.expX.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expX.Location = new System.Drawing.Point(367, 159);
            this.expX.Name = "expX";
            this.expX.Size = new System.Drawing.Size(107, 34);
            this.expX.TabIndex = 39;
            this.expX.TabStop = true;
            this.expX.Text = "exp(x)";
            this.expX.UseVisualStyleBackColor = true;
            // 
            // Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.expX);
            this.Controls.Add(this.sqrX);
            this.Controls.Add(this.cosX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WriteX);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.WriteY);
            this.Controls.Add(this.y);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Branches";
            this.Text = "Line";
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
        private System.Windows.Forms.TextBox WriteY;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.RadioButton cosX;
        private System.Windows.Forms.RadioButton sqrX;
        private System.Windows.Forms.RadioButton expX;
    }
}