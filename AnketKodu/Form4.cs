using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AnketKodu
{

    public partial class Form4 : Form
    {
        public int anketTuru;//anatablo.AnketID için tanımlandı
        int soruSayisi;
        public int soruSira = 0;
        int cevapTuru;
        public Form1 anaFrm;
        int[] soruIDler;
        CevapTurlerii cevap = new CevapTurlerii();

        RadioButton cevaplar = new RadioButton();




        public Form4()
        {
            InitializeComponent();
        }
        Label[] sorular;
        Panel[] pnl;


        private void Form4_Load(object sender, EventArgs e)
        {


            //burda soru saysısnı cektik
            veritabani.baglantiTanimla("Data Source=URALKAYA\\SQLSERVERTANJU; Database=Anketler; User Id= sa; Password=12369874");
            veritabani.BaglantiKoptuysaAc();
            veritabani.kmt.Connection = veritabani.baglanti;
            veritabani.kmt.CommandText = "SELECT COUNT(Soru)  FROM Sorular WHERE AnketID = " + anketTuru + "";
            soruSayisi = (int)veritabani.kmt.ExecuteScalar();
            veritabani.baglanti.Close();

            sorular = new Label[soruSayisi];
            soruIDler = new int[soruSayisi];
            pnl = new Panel[soruSayisi];

            // Burda hnagı anketID nın sorularını cekıyor

            veritabani.baglantiTanimla("Data Source = URALKAYA\\SQLSERVERTANJU; Database = Anketler; User Id= sa; Password=12369874 ");
            veritabani.BaglantiKoptuysaAc();
            veritabani.kmt.Connection = veritabani.baglanti;
            //"SELECT anket.AnketAdi, soru.Soru, cevap.CevapID FROM AnaTablo as anatablo, Anketler as anket, Sorular as soru, Cevaplar as cevap WHERE anatablo.AnketID = anket.AnketID AND anatablo.SoruID = soru.SoruID AND anatablo.CevapID = cevap.CevapID";
            veritabani.kmt.CommandText = "SELECT anket.AnketAdi, soru.Soru,soru.SoruID, cevap.CevapID FROM AnaTablo as anatablo, Ankett as anket, Sorular as soru, Cevaplar as cevap WHERE anatablo.AnketID = anket.AnketID AND anatablo.SoruID = soru.SoruID AND anatablo.CevapID = cevap.CevapID AND anket.AnketID = " + anketTuru + "";
            SqlDataReader oku = veritabani.kmt.ExecuteReader();

            while (oku.Read())
            {
                soruIDler[soruSira] = Convert.ToInt32(oku["SoruID"]);

                //burada soruların sayısı kadar label olusturuyoruz  ve bu labellara belırlı aralıklarla soru yazdıryoz
                sorular[soruSira] = new Label();
                sorular[soruSira].Location = new Point(20, (20 * soruSira * 8) + 20);
                sorular[soruSira].Text = (soruSira + 1).ToString() + oku["Soru"].ToString();//sorular tablosunun soru alanını okuyor
                sorular[soruSira].Size = new Size(10000, 16);
                sorular[soruSira].Font = new Font("Miramonte", 10);
                panel1.Controls.Add(sorular[soruSira]);

                cevapTuru = Convert.ToInt32(oku["CevapID"].ToString());

                //şimdi soruların sayısı kadar panel1 üzerinde panel olusturyorum     bu panellere cevap turlerını yazacam                
                pnl[soruSira] = new Panel();
                pnl[soruSira].Location = new Point(20, (20 * soruSira * 8 + 10) + 30);
                pnl[soruSira].Size = new Size(1000, 100);
                pnl[soruSira].BackColor = new Color();
                pnl[soruSira].BackColor = Color.LightBlue;


                //cevap turlerini yazdık yani evet hayırlı mı coklu secenklı sayısaldegerlıklımı
                if (cevapTuru == 1)
                {
                    cevap.evetHayirSecenek(pnl[soruSira]);
                }
                else if (cevapTuru == 2)
                {
                    cevap.cokluSecenek(pnl[soruSira]);
                }
                else
                {
                    cevap.sayisalSecenek(pnl[soruSira]);
                }


                panel1.Height += (sorular[soruSira].Height + pnl[soruSira].Height + 50);

                panel1.Controls.Add(pnl[soruSira]);

                //soruSira bizim srouların sayisini bir bir artırıyor
                soruSira++;
            }

            btnKaydet.Top += panel1.Height - 60;

            for (int i = 1; i < pnl.Length; i++)
            {
                for (int j = 0; j < pnl[i].Controls.Count; j++)
                {
                    cevaplar = (RadioButton)pnl[i].Controls[j];
                    cevaplar.Checked = false;

                }
            }

            veritabani.baglanti.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

            anketTuru = 0;
            cevapTuru = 0;
            soruSira = 0;



            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (!(panel1.Controls[i] is Button))
                {

                    panel1.Controls.Remove(panel1.Controls[i]);
                }
            }


            panel1.Size = new Size(926, 57);
            btnKaydet.Top = 3;
            btnKaydet.Left = 827;
        }

        private void btndeger_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            int soruID = 0;
            int cevapPanel = 0;

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (panel1.Controls[i] is Label)
                {
                    for (int l = 0; l < pnl[cevapPanel].Controls.Count; l++)
                    {
                        if (pnl[cevapPanel].Controls[l] is RadioButton)
                        {
                            cevaplar = (RadioButton)pnl[cevapPanel].Controls[l];
                        }
                        if (cevaplar.Checked == true)
                        {
                            veritabani.BaglantiKoptuysaAc();
                            veritabani.kmt.Connection = veritabani.baglanti;
                            veritabani.kmt.CommandText = "INSERT INTO AnketCevaplar(SoruID,Cevap) VALUES (" + soruIDler[soruID] + ",'" + cevaplar.Text + "')";
                            veritabani.kmt.ExecuteNonQuery();
                            veritabani.baglanti.Close();

                        }
                    }
                    cevapPanel++;
                    soruID++;
                }
            }
            //this.Refresh();
            this.Close();

        }
    }
}
