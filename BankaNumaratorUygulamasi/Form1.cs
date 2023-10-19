using Altyapi.Enumlar;
using Altyapi.Siniflar;

namespace BankaNumaratorUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbMusteriTipi.Items.Add("Se�iniz..");
            cmbMusteriTipi.Items.AddRange(Enum.GetNames(typeof(MusteriTipi)));
            cmbMusteriTipi.SelectedIndex = 0;

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

        }
    }
}