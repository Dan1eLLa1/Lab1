using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chezar
{
    public partial class FormMainApplication : Form
    {
        public FormMainApplication()
        {
            InitializeComponent();
        }
        static string alphabet = "0123456789АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя ";
        private void KeyPress_CryptTextBox(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= 1040 && e.KeyChar <= 1103) && e.KeyChar != 8 && e.KeyChar != 32 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void KeyPress_KeyTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void GenerateKey(object sender, EventArgs e)
        {
            textBox_KeyText.Text = new Random().Next(1, 9).ToString();
        }
        private string Chezar(string EncryptText, int key)
        {
            var CodedText="";
            
            foreach(char el_Text in EncryptText)
                CodedText+= alphabet[(alphabet.Length+alphabet.IndexOf(el_Text) + key) % alphabet.Length];
            return CodedText;
        }
        private void Encrypt(object sender, EventArgs e)
        {
            if (textBox_DecryptText.Text.Length != 0 && textBox_KeyText.Text.Length != 0)
               textBox_EncryptText.Text = Chezar(textBox_DecryptText.Text, -Convert.ToInt32(textBox_KeyText.Text));
        }
        private void Decrypt(object sender, EventArgs e)
        {
            if (textBox_EncryptText.Text.Length != 0 && textBox_KeyText.Text.Length != 0)
                textBox_DecryptText.Text = Chezar(textBox_EncryptText.Text, Convert.ToInt32(textBox_KeyText.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                textBox1.Text += Chezar(textBox2.Text, i) +' ';
            }
        }

    }
    
}
