using LoggingFormu.Classes;
using LoggingFormu.Interfaces;

namespace LoggingFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogKaydet_Click(object sender, EventArgs e)
        {
            if (cmbLogTipi.SelectedItem == null || cmbLogTipi.SelectedItem.ToString() == "Seçiniz") 
            {
                MessageBox.Show("Lütfen kaydetmek istediðiniz log tipini seçiniz.");
            }
            else if (txtKayitNotu.Text.Length == 0)
            {
                MessageBox.Show("Lütfen kayýt için not ekleyin.");
            }
            else
            {
                string secilenLogTipi = cmbLogTipi.SelectedItem.ToString();
                string message = Convert.ToString(txtKayitNotu.Text);
                LogManagerFactory factory = new LogManagerFactory();
                ILog logTipi = factory.LogNesnesiOlustur(secilenLogTipi);

                if (logTipi != null)
                {
                    lblSonuc.Text = logTipi.Log(message);
                }
                else
                {
                    lblSonuc.Text = "Geçerli bir uzantý seçiniz.";
                }
            }
        }
    }
}
