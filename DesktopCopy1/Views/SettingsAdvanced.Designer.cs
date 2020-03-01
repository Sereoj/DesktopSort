namespace DesktopCopy1.Views
{
    partial class SettingsAdvanced
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckLogger = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox2 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // CheckLogger
            // 
            this.CheckLogger.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckLogger.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckLogger.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckLogger.FillColor = System.Drawing.Color.White;
            this.CheckLogger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckLogger.Location = new System.Drawing.Point(32, 43);
            this.CheckLogger.Name = "CheckLogger";
            this.CheckLogger.Size = new System.Drawing.Size(237, 20);
            this.CheckLogger.TabIndex = 57;
            this.CheckLogger.Text = "Записывать ошибки в отдельный файл";
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox1.Location = new System.Drawing.Point(32, 69);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(282, 20);
            this.gunaCheckBox1.TabIndex = 57;
            this.gunaCheckBox1.Text = "Проверять обновление при запуске программы";
            // 
            // gunaCheckBox2
            // 
            this.gunaCheckBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox2.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox2.Location = new System.Drawing.Point(32, 95);
            this.gunaCheckBox2.Name = "gunaCheckBox2";
            this.gunaCheckBox2.Size = new System.Drawing.Size(172, 20);
            this.gunaCheckBox2.TabIndex = 57;
            this.gunaCheckBox2.Text = "Отключение заднего фона";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(307, 25);
            this.gunaLabel1.TabIndex = 58;
            this.gunaLabel1.Text = "Расширенные настройки\r\n\r\n";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SingleBitPerPixel;
            // 
            // SettingsAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaCheckBox2);
            this.Controls.Add(this.gunaCheckBox1);
            this.Controls.Add(this.CheckLogger);
            this.Name = "SettingsAdvanced";
            this.Size = new System.Drawing.Size(578, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox CheckLogger;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
