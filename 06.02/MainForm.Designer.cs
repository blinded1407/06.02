namespace _06._02
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.линейныйАлгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разветвляющийсяАглоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.линейныйАлгоритмToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разветвляющийсяАлгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линейныйАлгоритмToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 28);
            // 
            // линейныйАлгоритмToolStripMenuItem
            // 
            this.линейныйАлгоритмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разветвляющийсяАглоритмToolStripMenuItem});
            this.линейныйАлгоритмToolStripMenuItem.Name = "линейныйАлгоритмToolStripMenuItem";
            this.линейныйАлгоритмToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.линейныйАлгоритмToolStripMenuItem.Text = "Линейный алгоритм";
            // 
            // разветвляющийсяАглоритмToolStripMenuItem
            // 
            this.разветвляющийсяАглоритмToolStripMenuItem.Name = "разветвляющийсяАглоритмToolStripMenuItem";
            this.разветвляющийсяАглоритмToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.разветвляющийсяАглоритмToolStripMenuItem.Text = "Разветвляющийся аглоритм";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линейныйАлгоритмToolStripMenuItem1,
            this.разветвляющийсяАлгоритмToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // линейныйАлгоритмToolStripMenuItem1
            // 
            this.линейныйАлгоритмToolStripMenuItem1.Name = "линейныйАлгоритмToolStripMenuItem1";
            this.линейныйАлгоритмToolStripMenuItem1.Size = new System.Drawing.Size(167, 24);
            this.линейныйАлгоритмToolStripMenuItem1.Text = "Линейный алгоритм";
            this.линейныйАлгоритмToolStripMenuItem1.Click += new System.EventHandler(this.линейныйАлгоритмToolStripMenuItem1_Click);
            // 
            // разветвляющийсяАлгоритмToolStripMenuItem
            // 
            this.разветвляющийсяАлгоритмToolStripMenuItem.Name = "разветвляющийсяАлгоритмToolStripMenuItem";
            this.разветвляющийсяАлгоритмToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.разветвляющийсяАлгоритмToolStripMenuItem.Text = "Разветвляющийся алгоритм";
            this.разветвляющийсяАлгоритмToolStripMenuItem.Click += new System.EventHandler(this.разветвляющийсяАлгоритмToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem линейныйАлгоритмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разветвляющийсяАглоритмToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem линейныйАлгоритмToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem разветвляющийсяАлгоритмToolStripMenuItem;
    }
}

