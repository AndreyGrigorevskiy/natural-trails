namespace Diplom
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonPorch = new System.Windows.Forms.Button();
            this.buttonRoad = new System.Windows.Forms.Button();
            this.buttonBarrier = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.аToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.алгоритмToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem1,
            this.загрузитьToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.сохранитьToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // алгоритмToolStripMenuItem
            // 
            this.алгоритмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аToolStripMenuItem});
            this.алгоритмToolStripMenuItem.Name = "алгоритмToolStripMenuItem";
            this.алгоритмToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.алгоритмToolStripMenuItem.Text = "Алгоритм";
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Brown;
            this.buttonHome.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHome.Location = new System.Drawing.Point(926, 32);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 34);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "Дом";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonPorch
            // 
            this.buttonPorch.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPorch.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPorch.Location = new System.Drawing.Point(927, 72);
            this.buttonPorch.Name = "buttonPorch";
            this.buttonPorch.Size = new System.Drawing.Size(75, 34);
            this.buttonPorch.TabIndex = 3;
            this.buttonPorch.Text = "Вход";
            this.buttonPorch.UseVisualStyleBackColor = false;
            this.buttonPorch.Click += new System.EventHandler(this.buttonPorch_Click);
            // 
            // buttonRoad
            // 
            this.buttonRoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRoad.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRoad.Location = new System.Drawing.Point(927, 113);
            this.buttonRoad.Name = "buttonRoad";
            this.buttonRoad.Size = new System.Drawing.Size(75, 34);
            this.buttonRoad.TabIndex = 4;
            this.buttonRoad.Text = "Дорога";
            this.buttonRoad.UseVisualStyleBackColor = false;
            this.buttonRoad.Click += new System.EventHandler(this.buttonRoad_Click);
            // 
            // buttonBarrier
            // 
            this.buttonBarrier.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBarrier.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBarrier.Location = new System.Drawing.Point(927, 154);
            this.buttonBarrier.Name = "buttonBarrier";
            this.buttonBarrier.Size = new System.Drawing.Size(75, 34);
            this.buttonBarrier.TabIndex = 5;
            this.buttonBarrier.Text = "Барьер";
            this.buttonBarrier.UseVisualStyleBackColor = false;
            this.buttonBarrier.Click += new System.EventHandler(this.buttonBarrier_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Teal;
            this.buttonGreen.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGreen.Location = new System.Drawing.Point(927, 195);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(75, 34);
            this.buttonGreen.TabIndex = 6;
            this.buttonGreen.Text = "Зелень";
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.Location = new System.Drawing.Point(925, 586);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(75, 34);
            this.buttonEraser.TabIndex = 7;
            this.buttonEraser.Text = "Ластик";
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 629);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(927, 627);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 34);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // аToolStripMenuItem
            // 
            this.аToolStripMenuItem.Name = "аToolStripMenuItem";
            this.аToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.аToolStripMenuItem.Text = "А*";
            this.аToolStripMenuItem.Click += new System.EventHandler(this.аToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEraser);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonBarrier);
            this.Controls.Add(this.buttonRoad);
            this.Controls.Add(this.buttonPorch);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Form1";
            this.Text = "Trop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPorch;
        private System.Windows.Forms.Button buttonRoad;
        private System.Windows.Forms.Button buttonBarrier;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem аToolStripMenuItem;
    }
}

