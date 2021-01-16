using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace notUygulaması
{
    class VeriTabani
    {
        private SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1LCVNV4\SQLEXPRESS;Initial Catalog=okul;Integrated Security=True");
        
        public void baglantiyiAc()
        {
            if(baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        public void baglantiyiKapat()
        {
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return baglanti;
        }
    }
}
