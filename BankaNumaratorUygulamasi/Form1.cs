using Altyapi.Arabirimler;
using Altyapi.Enumlar;
using Altyapi.Siniflar;
using System.ComponentModel;

namespace BankaNumaratorUygulamasi
{
    public partial class Form1 : Form
    {
        Banka banka = new Banka();


        public Form1()
        {
            InitializeComponent();
            cmbMusteriTipi.Items.Add("Se�iniz..");
            cmbMusteriTipi.Items.AddRange(Enum.GetNames(typeof(MusteriTipi)));
            cmbMusteriTipi.SelectedIndex = 0;

            //bankam�z�n �zelliklerini atayal�m..
            banka.Musteriler = new BindingList<IMusteri>();
            banka.Numarator = new Numarator();
            banka.Numarator.BekleyenMusteriler = new BindingList<IMusteri>();


        }

        private void cmbMusteriTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // m��terit�r� se�tiyse se�iniz kald�r
            if (cmbMusteriTipi.Items[0] == "Se�iniz.." && cmbMusteriTipi.SelectedIndex != 0)
            {
                cmbMusteriTipi.Items.Remove(cmbMusteriTipi.Items[0]);
                btnEkle.Enabled = true;
                btnSiraNumarasiAl.Enabled = true;

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.MusteriTipi = (MusteriTipi)Enum.Parse(typeof(MusteriTipi), cmbMusteriTipi.SelectedItem.ToString()!);
            yeniMusteri.TcKimlik = txtTcNo.Text;

            yeniMusteri.NumaratoreGit += banka.Numarator.NumaraUret;
            yeniMusteri.Numara += yeniMusteri.NumaraAl();

            banka.Musteriler.Add(yeniMusteri);
            banka.Numarator.BekleyenMusteriler.Add(yeniMusteri);


            ListeGuncelle(banka.Numarator.BekleyenMusteriler);
        }

        private void ListeGuncelle(BindingList<IMusteri> liste)
        {
            gdvBekleyenler.DataSource = null;
            gdvBekleyenler.DataSource = liste;
        }

        private void btnSiraNumarasiAl_Click(object sender, EventArgs e)
        {
            lblIslemdekiMusteri.Text = banka.Numarator.SiradakiniGetir();
            ListeGuncelle(banka.Numarator.BekleyenMusteriler);
        }
    }
}