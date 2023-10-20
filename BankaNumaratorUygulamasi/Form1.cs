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
            cmbMusteriTipi.Items.Add("Seçiniz..");
            cmbMusteriTipi.Items.AddRange(Enum.GetNames(typeof(MusteriTipi)));
            cmbMusteriTipi.SelectedIndex = 0;

            //bankamýzýn özelliklerini atayalým..
            banka.Musteriler = new BindingList<IMusteri>();
            banka.Numarator = new Numarator();
            banka.Numarator.BekleyenMusteriler = new BindingList<IMusteri>();


        }

        private void cmbMusteriTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // müþteritürü seçtiyse seçiniz kaldýr
            if (cmbMusteriTipi.Items[0] == "Seçiniz.." && cmbMusteriTipi.SelectedIndex != 0)
            {
                cmbMusteriTipi.Items.Remove(cmbMusteriTipi.Items[0]);
                btnEkle.Enabled = true;
                btnSiraNumarasiAl.Enabled = true;

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTcNo.Text.Trim() == "")
            {
                MessageBox.Show("Tc kimlik No boþ olamaz!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtTcNo.Text, out long tcNo))
            {
                MessageBox.Show("Tc kimlik No sayýsal olmalýdýr!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Musteri yeniMusteri = new Musteri();
            yeniMusteri.MusteriTipi = (MusteriTipi)Enum.Parse(typeof(MusteriTipi), cmbMusteriTipi.SelectedItem.ToString()!);
            yeniMusteri.TcKimlik = txtTcNo.Text.Trim();

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