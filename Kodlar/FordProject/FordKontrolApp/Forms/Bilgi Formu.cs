using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordKontrolApp.Forms
{
    public partial class Bilgi_Formu : Form
    {
        public Bilgi_Formu()
        {
            InitializeComponent();
        }

        FordEntities fordEntities = new FordEntities();
        private void btnekle_Click(object sender, EventArgs e)
        {
            Destek destek = new Destek();

            destek.Ad = txtad.Text;
            destek.Soyad = txtsoyad.Text;
            destek.Email = txtmail.Text;
            destek.ArabaId = int.Parse(txtaraba.Text);


            if (txttel.Text.Length != 11)
            {
                MessageBox.Show("Lütfen Geçerli Bir Telefon Girin");
            }

            else
            {

                destek.Telefon = txttel.Text;
                fordEntities.Destek.Add(destek);
                fordEntities.SaveChanges();
                MessageBox.Show("Yeni Müşteri Eklendi");
                Temizle();
                listele();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            var musteriid = int.Parse(lblıd.Text);
            var musterı_guncelle = fordEntities.Destek.FirstOrDefault(x => x.MusteriId == musteriid);

            musterı_guncelle.Ad = txtad.Text;
            musterı_guncelle.Soyad = txtsoyad.Text;
            musterı_guncelle.Email = txtmail.Text;

            musterı_guncelle.ArabaId = int.Parse(txtaraba.Text);

            if (txttel.Text.Length != 11)
            {
                MessageBox.Show("Lütfen Geçerli Bir Telefon Girin");
            }
            else
            {
                musterı_guncelle.Telefon = txttel.Text;
                fordEntities.SaveChanges();
                MessageBox.Show("Müşteri Bilgileri Güncellendi");
                Temizle();
                listele();
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int musteriıd = int.Parse(lblıd.Text);
            var musteri_sil = fordEntities.Destek.FirstOrDefault(x => x.MusteriId == musteriıd);

            fordEntities.Destek.Remove(musteri_sil);
            fordEntities.SaveChanges();
            MessageBox.Show("Müşteri Silindi");
            listele();
            Temizle();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bilgi_Formu_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void Temizle()
        {
            lblıd.Text = txtad.Text = txtsoyad.Text = txtmail.Text = txttel.Text = txtaraba.Text = "";
        }

        public void listele()
        {
            dgwlist.DataSource = fordEntities.Destek.ToList();

            using (var db = new FordEntities())
            {
                var destek = from Destek in db.Destek
                             join Araba in db.Araba on Destek.ArabaId equals Araba.ArabaId
                             select new
                             {
                                 Destek.MusteriId,
                                 Destek.Ad,
                                 Destek.Soyad,
                                 Destek.Email,
                                 Destek.Telefon,
                                 Destek.ArabaId,
                                 Araba.ArabaModel
                             };

                dgwlist.DataSource = destek.ToList();
            }

        }

        private void dgwlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblıd.Text = dgwlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dgwlist.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtsoyad.Text = dgwlist.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtmail.Text = dgwlist.Rows[e.RowIndex].Cells[3].Value.ToString();

            txttel.Text = dgwlist.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtaraba.Text = dgwlist.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblıd.Text = txtad.Text = txtsoyad.Text = txtmail.Text = txttel.Text = txtaraba.Text = "";
        }
    }
}
