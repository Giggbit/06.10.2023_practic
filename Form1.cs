using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox textBox;

        public Form1() {
            InitializeComponent();

            textBox1.MaxLength = 0;
        }

        private void TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            string oldText = tb.Text;
            string newText = Regex.Replace(oldText, "[^A-ZА-Я\\s]", "");

            if (newText != oldText) {
                tb.Text = newText;
                tb.SelectionStart = tb.Text.Length;
            }
        }

    }
}
