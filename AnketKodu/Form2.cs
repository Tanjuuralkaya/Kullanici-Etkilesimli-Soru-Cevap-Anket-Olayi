using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnketKodu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "Tanju" && textBox2.Text.Trim() == "1234")
            {
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
            else 
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
                textBox1.Text = "";
                textBox2.Clear();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
