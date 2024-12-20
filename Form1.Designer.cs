namespace Chezar
{
    partial class FormMainApplication
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
            this.textBox_DecryptText = new System.Windows.Forms.TextBox();
            this.textBox_EncryptText = new System.Windows.Forms.TextBox();
            this.label_EncryptText = new System.Windows.Forms.Label();
            this.label_DecryptText = new System.Windows.Forms.Label();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.label_KeyText = new System.Windows.Forms.Label();
            this.textBox_KeyText = new System.Windows.Forms.TextBox();
            this.button_KeyGeneration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_DecryptText
            // 
            this.textBox_DecryptText.Location = new System.Drawing.Point(16, 56);
            this.textBox_DecryptText.Multiline = true;
            this.textBox_DecryptText.Name = "textBox_DecryptText";
            this.textBox_DecryptText.Size = new System.Drawing.Size(269, 128);
            this.textBox_DecryptText.TabIndex = 0;
            this.textBox_DecryptText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CryptTextBox);
            // 
            // textBox_EncryptText
            // 
            this.textBox_EncryptText.Location = new System.Drawing.Point(291, 56);
            this.textBox_EncryptText.Multiline = true;
            this.textBox_EncryptText.Name = "textBox_EncryptText";
            this.textBox_EncryptText.Size = new System.Drawing.Size(269, 128);
            this.textBox_EncryptText.TabIndex = 1;
            this.textBox_EncryptText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CryptTextBox);
            // 
            // label_EncryptText
            // 
            this.label_EncryptText.AutoSize = true;
            this.label_EncryptText.Location = new System.Drawing.Point(35, 26);
            this.label_EncryptText.Name = "label_EncryptText";
            this.label_EncryptText.Size = new System.Drawing.Size(90, 13);
            this.label_EncryptText.TabIndex = 2;
            this.label_EncryptText.Text = "Открытый текст";
            // 
            // label_DecryptText
            // 
            this.label_DecryptText.AutoSize = true;
            this.label_DecryptText.Location = new System.Drawing.Point(307, 26);
            this.label_DecryptText.Name = "label_DecryptText";
            this.label_DecryptText.Size = new System.Drawing.Size(90, 13);
            this.label_DecryptText.TabIndex = 3;
            this.label_DecryptText.Text = "Закрытый текст";
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(173, 190);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(112, 49);
            this.button_Encrypt.TabIndex = 4;
            this.button_Encrypt.Text = "Зашифровать";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.Encrypt);
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.Location = new System.Drawing.Point(448, 190);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(112, 49);
            this.button_Decrypt.TabIndex = 5;
            this.button_Decrypt.Text = "Расшифровать";
            this.button_Decrypt.UseVisualStyleBackColor = true;
            this.button_Decrypt.Click += new System.EventHandler(this.Decrypt);
            // 
            // label_KeyText
            // 
            this.label_KeyText.AutoSize = true;
            this.label_KeyText.Location = new System.Drawing.Point(33, 262);
            this.label_KeyText.Name = "label_KeyText";
            this.label_KeyText.Size = new System.Drawing.Size(33, 13);
            this.label_KeyText.TabIndex = 6;
            this.label_KeyText.Text = "Ключ";
            // 
            // textBox_KeyText
            // 
            this.textBox_KeyText.Location = new System.Drawing.Point(72, 259);
            this.textBox_KeyText.Name = "textBox_KeyText";
            this.textBox_KeyText.Size = new System.Drawing.Size(100, 20);
            this.textBox_KeyText.TabIndex = 7;
            this.textBox_KeyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_KeyTextBox);
            // 
            // button_KeyGeneration
            // 
            this.button_KeyGeneration.Location = new System.Drawing.Point(178, 257);
            this.button_KeyGeneration.Name = "button_KeyGeneration";
            this.button_KeyGeneration.Size = new System.Drawing.Size(75, 23);
            this.button_KeyGeneration.TabIndex = 8;
            this.button_KeyGeneration.Text = "Сгенерировать ключ";
            this.button_KeyGeneration.UseVisualStyleBackColor = true;
            this.button_KeyGeneration.Click += new System.EventHandler(this.GenerateKey);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Взлом";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(291, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 179);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Закрытый текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Открытый текст";
            // 
            // FormMainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_KeyGeneration);
            this.Controls.Add(this.textBox_KeyText);
            this.Controls.Add(this.label_KeyText);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.label_DecryptText);
            this.Controls.Add(this.label_EncryptText);
            this.Controls.Add(this.textBox_EncryptText);
            this.Controls.Add(this.textBox_DecryptText);
            this.Name = "FormMainApplication";
            this.Text = "Шифр Цезаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_DecryptText;
        private System.Windows.Forms.TextBox textBox_EncryptText;
        private System.Windows.Forms.Label label_EncryptText;
        private System.Windows.Forms.Label label_DecryptText;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.Label label_KeyText;
        private System.Windows.Forms.TextBox textBox_KeyText;
        private System.Windows.Forms.Button button_KeyGeneration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

