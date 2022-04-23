
namespace Lines
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
            this.buttonHoriz = new System.Windows.Forms.Button();
            this.buttonVert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHoriz
            // 
            this.buttonHoriz.Location = new System.Drawing.Point(12, 415);
            this.buttonHoriz.Name = "buttonHoriz";
            this.buttonHoriz.Size = new System.Drawing.Size(223, 23);
            this.buttonHoriz.TabIndex = 0;
            this.buttonHoriz.Text = "Рисовать горизонтально";
            this.buttonHoriz.UseVisualStyleBackColor = true;
            this.buttonHoriz.Click += new System.EventHandler(this.buttonHoriz_Click);
            // 
            // buttonVert
            // 
            this.buttonVert.Location = new System.Drawing.Point(565, 415);
            this.buttonVert.Name = "buttonVert";
            this.buttonVert.Size = new System.Drawing.Size(223, 23);
            this.buttonVert.TabIndex = 1;
            this.buttonVert.Text = "Рисовать вертикально";
            this.buttonVert.UseVisualStyleBackColor = true;
            this.buttonVert.Click += new System.EventHandler(this.buttonVert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVert);
            this.Controls.Add(this.buttonHoriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHoriz;
        private System.Windows.Forms.Button buttonVert;
    }
}

