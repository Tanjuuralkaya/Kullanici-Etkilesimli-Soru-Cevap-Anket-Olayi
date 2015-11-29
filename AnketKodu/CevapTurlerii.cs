using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnketKodu
{
    class CevapTurlerii
    {

        RadioButton[] evetHayır = new RadioButton[2];
        RadioButton[] coklu = new RadioButton[5];
        RadioButton[] sayisal = new RadioButton[5];

        public void evetHayirSecenek(Panel anketPanel)
        {
            for (int i = 0; i < evetHayır.Length; i++)
            {
                evetHayır[i] = new RadioButton();
                evetHayır[i].Location = new Point((i * 100) + 15, 35);
                evetHayır[i].Size = new Size(70, 30);
                evetHayır[i].Font = new Font("Miramonte", 10);
                anketPanel.Controls.Add(evetHayır[i]);

            }
            evetHayır[0].Text = "Evet";
            evetHayır[1].Text = "Hayır";

        }
        public void cokluSecenek(Panel anketPanel)
        {
            for (int i = 0; i < coklu.Length; i++)
            {
                coklu[i] = new RadioButton();                
                coklu[i].Location = new Point((i * 100) + 20, 35);
                coklu[i].Size = new Size(100, 30);
                coklu[i].Font = new Font("Miramonte", 10);
                if (i == 0)
                    coklu[0].Text = "Kötü";
                else if (i == 1)
                    coklu[1].Text = "Normal";
                else if (i == 2)
                    coklu[2].Text = "İyi";
                else if (i == 3)
                    coklu[3].Text = "Çok İyi";
                else if (i == 4)
                    coklu[4].Text = "Mükemmel";
                anketPanel.Controls.Add(coklu[i]);
            }

        }
        public void sayisalSecenek(Panel anketPanel)
        {
            for (int i = 0; i < sayisal.Length; i++)
            {
                sayisal[i] = new RadioButton();
                sayisal[i].Location = new Point( (i * 100) + 15, 35);
                sayisal[i].Size = new Size(60, 60);
                sayisal[i].Font = new Font("Miramonte", 10);
                anketPanel.Controls.Add(sayisal[i]);
            }
            sayisal[0].Text = "1";
            sayisal[1].Text = "2";
            sayisal[2].Text = "3";
            sayisal[3].Text = "4";
            sayisal[4].Text = "5";
        }
        
    }
}
