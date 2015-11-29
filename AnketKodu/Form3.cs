using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace AnketKodu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        int anketTuru;
        int soruId = 0;
        int cevapID;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cevapID = 1;
            }
            else if (radioButton2.Checked == true)
            {
                cevapID = 2;
            }
            else if (radioButton3.Checked == true)
            {
                cevapID = 3;                
            }

            
                //burda sorular tablosuna soru eklendı
                anketTuru = Convert.ToInt32(comboBox1.Items.IndexOf(comboBox1.SelectedItem)) + 1;//AnketID ye secilen anket turunu sayısal degere cevırıp 
                //bunu anketID ye yolladım
                //anketTuru = comboBox1.SelectedIndex;
                // ++soruId;                          
           //burada texte gırılen soruyu verıtabanına yolluyoz
            veritabani.BaglantiKoptuysaAc();
            veritabani.kmt.Connection = veritabani.baglanti;
            veritabani.kmt.CommandText = "INSERT INTO Sorular(AnketID,Soru) VALUES ("+ anketTuru +",'"+ txtSoru.Text +"')";
            veritabani.kmt.ExecuteNonQuery();
            veritabani.baglanti.Close();


            veritabani.BaglantiKoptuysaAc();//burada bir eklenen sorudan sonra yeni eklenen soru için ekleme yapmıyordu bunu gıdermek ıcın
            veritabani.kmt.Connection = veritabani.baglanti;//soruIDleri tersden yazdıracak sekılde dızayn etttım yani son eklenen soruyu basa yazdık
            veritabani.kmt.CommandText = "SELECT top 1 * FROM Sorular ORDER BY SoruID DESC";
            SqlDataReader oku = veritabani.kmt.ExecuteReader();
            oku.Read();
            soruId= Convert.ToInt32(oku["SoruID"].ToString());
            veritabani.baglanti.Close();

            
            veritabani.BaglantiKoptuysaAc();
            veritabani.kmt.Connection = veritabani.baglanti;
            veritabani.kmt.CommandText = "INSERT INTO [AnaTablo](AnketID,SoruID,CevapID) VALUES(" + anketTuru + "," + soruId + "," + cevapID + ")";
            veritabani.kmt.ExecuteNonQuery();
            veritabani.baglanti.Close();
            
            MessageBox.Show("Soru Başarıyla Kaydedildi");
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                veritabani.baglantiTanimla("Data Source=TANJU; Initial Catalog=Anketler; Integrated Security = SSPI;");
                
                //MessageBox.Show("veri tabanına baglandı");               
            }
            catch (Exception)
            {
                MessageBox.Show("Veri tabanına Bağlanmadı");
                
            }            

            veritabani.kmt.Connection = veritabani.baglanti;//combobox1e veri tabanından verileri cekmek için kullandık
            veritabani.kmt.CommandText = "Select * From Ankett ";
            SqlDataReader oku = veritabani.kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["AnketAdi"]);
            }
            veritabani.baglanti.Close();            

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}
