namespace hashstring1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.inputWord = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.inputHash = new System.Windows.Forms.TextBox();
            this.outputHash = new System.Windows.Forms.TextBox();
            this.outputWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = ">>hash>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputWord
            // 
            this.inputWord.Location = new System.Drawing.Point(12, 28);
            this.inputWord.Name = "inputWord";
            this.inputWord.Size = new System.Drawing.Size(204, 20);
            this.inputWord.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = ">>unhash>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputHash
            // 
            this.inputHash.Location = new System.Drawing.Point(12, 57);
            this.inputHash.Name = "inputHash";
            this.inputHash.Size = new System.Drawing.Size(204, 20);
            this.inputHash.TabIndex = 3;
            // 
            // outputHash
            // 
            this.outputHash.Location = new System.Drawing.Point(303, 28);
            this.outputHash.Name = "outputHash";
            this.outputHash.Size = new System.Drawing.Size(240, 20);
            this.outputHash.TabIndex = 6;
            // 
            // outputWord
            // 
            this.outputWord.Location = new System.Drawing.Point(303, 57);
            this.outputWord.Name = "outputWord";
            this.outputWord.Size = new System.Drawing.Size(240, 20);
            this.outputWord.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.outputWord);
            this.Controls.Add(this.outputHash);
            this.Controls.Add(this.inputHash);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputWord);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputWord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputHash;
        private System.Windows.Forms.TextBox outputHash;
        private System.Windows.Forms.TextBox outputWord;
    }
}

