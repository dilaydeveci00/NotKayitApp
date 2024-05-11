﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ÖğrenciNotKayıtSistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-93QGIB63\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");
        //Data Source = LAPTOP - 93QGIB63\SQLEXPRESS;Initial Catalog = DbNotKayıt; Integrated Security = True
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select* from MATEMATİK2 WHERE OGRNUMARA=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[2].ToString() + "" + dr[3].ToString();
                LblSinav1.Text = dr[4].ToString();
                LblSinav2.Text = dr[5].ToString();
                LblSinav3.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();
                LblDurum.Text = dr[8].ToString();
            }

            baglanti.Close();
        }
    }
}
