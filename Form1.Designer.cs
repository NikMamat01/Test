namespace Тест_форма
{
    partial class Рандом
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
            this.random1 = new System.Windows.Forms.Button();
            this.chislo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // random1
            // 
            this.random1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.random1.Location = new System.Drawing.Point(12, 127);
            this.random1.Name = "random1";
            this.random1.Size = new System.Drawing.Size(257, 107);
            this.random1.TabIndex = 0;
            this.random1.Text = "Рандом";
            this.random1.UseVisualStyleBackColor = true;
            this.random1.Click += new System.EventHandler(this.random1_Click);
            // 
            // chislo
            // 
            this.chislo.AutoSize = true;
            this.chislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chislo.Location = new System.Drawing.Point(12, 25);
            this.chislo.Name = "chislo";
            this.chislo.Size = new System.Drawing.Size(39, 20);
            this.chislo.TabIndex = 1;
            this.chislo.Text = "100";
            // 
            // Рандом
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 246);
            this.Controls.Add(this.chislo);
            this.Controls.Add(this.random1);
            this.Name = "Рандом";
            this.Text = "Рандом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button random1;
        private System.Windows.Forms.Label chislo;
    }
}

