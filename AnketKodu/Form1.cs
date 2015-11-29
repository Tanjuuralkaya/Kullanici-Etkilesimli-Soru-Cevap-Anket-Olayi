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

    public partial class Form1 : Form
    {
        public Form4 frm4;

        public Form1()
        {
            
            InitializeComponent();
            frm4 = new Form4();
            frm4.anaFrm = this;

        
        }

        private void btnyonetici_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            this.Close();
        }

        private void müsteribtn_Click(object sender, EventArgs e)
        {
            frm4.anketTuru = 1;
            frm4.ShowDialog(); 
        }

        private void btnCalısan_Click(object sender, EventArgs e)
        {
            frm4.anketTuru = 2;
            frm4.ShowDialog();
        }

        private void btnSağlık_Click(object sender, EventArgs e)
        {
            frm4.anketTuru = 3;
            frm4.ShowDialog();
        }

        private void btnCalısanPerformans_Click(object sender, EventArgs e)
        {
            frm4.anketTuru = 4;
            frm4.ShowDialog();
        }

        private void btnistenayrılmna_Click(object sender, EventArgs e)
        {
            frm4.anketTuru = 5;
            frm4.ShowDialog();

        }

        private void ismemnunıyetiankt_Click(object sender, EventArgs e)
        {
            frm4.anketTuru = 6;
            frm4.ShowDialog();
        }

        private void calısanAvantajlari_Click(object sender, EventArgs e)
        {
            frm4.anketTuru = 7;
            frm4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
