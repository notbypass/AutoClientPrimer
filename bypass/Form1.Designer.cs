namespace bypass
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
            this.button3 = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.pasBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(93, 70);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(100, 20);
            this.logBox.TabIndex = 1;
            this.logBox.TextChanged += new System.EventHandler(this.logBox_TextChanged);
            // 
            // pasBox
            // 
            this.pasBox.Location = new System.Drawing.Point(93, 113);
            this.pasBox.Name = "pasBox";
            this.pasBox.Size = new System.Drawing.Size(100, 20);
            this.pasBox.TabIndex = 2;
            this.pasBox.TextChanged += new System.EventHandler(this.pasBox_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pasBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox pasBox;
    }
}

