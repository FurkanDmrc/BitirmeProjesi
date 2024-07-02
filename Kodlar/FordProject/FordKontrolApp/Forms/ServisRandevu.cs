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
    public partial class ServisRandevu : Form
    {
        public ServisRandevu()
        {
            InitializeComponent();
        }

        FordEntities fordEntities = new FordEntities();
        private void dgwlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblıd.Text = dgwlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dgwlist.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtsoyad.Text = dgwlist.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtmail.Text = dgwlist.Rows[e.RowIndex].Cells[3].Value.ToString();

            txttel.Text = dgwlist.Rows[e.RowIndex].Cells[4].Value.ToString();

            txtaraba.Text = dgwlist.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            Servis servis = new Servis();

            servis.Ad = txtad.Text;
            servis.Soyad = txtsoyad.Text;
            servis.Email = txtmail.Text;
            servis.ArabaId = int.Parse(txtaraba.Text);


            if (txttel.Text.Length != 11)
            {
                MessageBox.Show("Lütfen Geçerli Bir Telefon Girin");
            }

            else
            {

                servis.Telefon = txttel.Text;
                fordEntities.Servis.Add(servis);
                fordEntities.SaveChanges();
                MessageBox.Show("Yeni Müşteri Eklendi");
                Temizle();
                listele();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {


            var musteriid = int.Parse(lblıd.Text);
            var musterı_guncelle = fordEntities.Servis.FirstOrDefault(x => x.MusteriId == musteriid);

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
            var musteri_sil = fordEntities.Servis.FirstOrDefault(x => x.MusteriId == musteriıd);

            fordEntities.Servis.Remove(musteri_sil);
            fordEntities.SaveChanges();
            MessageBox.Show("Müşteri Silindi");
            listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblıd.Text = txtad.Text = txtsoyad.Text = txtmail.Text = txttel.Text = txtaraba.Text = "";
        }

        private void ServisRandevu_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void Temizle()
        {
            lblıd.Text = txtad.Text = txtsoyad.Text = txtmail.Text = txttel.Text = txtaraba.Text = "";
        }

        public void listele()
        {
            using (var db = new FordEntities())
            {
                var müşteriArabaları = from Servis in db.Servis
                                       join Araba in db.Araba on Servis.ArabaId equals Araba.ArabaId
                                       select new
                                       {
                                           Servis.MusteriId,
                                           Servis.Ad,
                                           Servis.Soyad,
                                           Servis.Email,
                                           Servis.Telefon,
                                           Servis.ArabaId,
                                           Araba.ArabaModel
                                       };

                dgwlist.DataSource = müşteriArabaları.ToList();
            }

        }
    }
}
