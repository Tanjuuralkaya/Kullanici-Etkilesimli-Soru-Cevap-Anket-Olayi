using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data;

namespace AnketKodu
{
    class veritabani
    {
        public static SqlConnection baglanti;
        public static SqlCommand kmt = new SqlCommand();

        public static void baglantiTanimla(string bag)
        {
            baglanti = new SqlConnection(bag);
            baglanti.Open();
        }
        public static void BaglantiKoptuysaAc()
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
        }
    }
}
