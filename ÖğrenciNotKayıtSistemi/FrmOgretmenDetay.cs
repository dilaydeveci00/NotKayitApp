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


namespace ÖğrenciNotKayıtSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-93QGIB63\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");



        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayıtDataSet.matematik2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.matematik2TableAdapter.Fill(this.dbNotKayıtDataSet.matematik2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MATEMATİK2 (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@P1", MskNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@P3", TxtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi.");
            this.matematik2TableAdapter.Fill(this.dbNotKayıtDataSet.matematik2);





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null) // Eğer hiçbir satır seçilmediyse devam etme
            {
                int secilenIndex = dataGridView1.CurrentRow.Index;

                MskNumara.Text = dataGridView1.Rows[secilenIndex].Cells[1].Value?.ToString();
                TxtAd.Text = dataGridView1.Rows[secilenIndex].Cells[2].Value?.ToString();
                TxtSoyad.Text = dataGridView1.Rows[secilenIndex].Cells[3].Value?.ToString();
                TxtSinav1.Text = dataGridView1.Rows[secilenIndex].Cells[4].Value?.ToString();
                TxtSinav2.Text = dataGridView1.Rows[secilenIndex].Cells[5].Value?.ToString();
                TxtSinav3.Text = dataGridView1.Rows[secilenIndex].Cells[6].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;

            s1 = Convert.ToDouble(TxtSinav1.Text);
            s2 = Convert.ToDouble(TxtSinav2.Text);
            s3 = Convert.ToDouble(TxtSinav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString();

            if(ortalama>=50)
            {
                durum = "TRUE";
            }
            else
            {
                durum = "FALSE";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update matematik2 set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtSinav1.Text);
            komut.Parameters.AddWithValue("@p2", TxtSinav2.Text);
            komut.Parameters.AddWithValue("@p3", TxtSinav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(LblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.matematik2TableAdapter.Fill(this.dbNotKayıtDataSet.matematik2);


        }
    }
}
