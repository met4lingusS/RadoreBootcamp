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
            if (cmbLogTipi.SelectedItem == null || cmbLogTipi.SelectedItem.ToString() == "Se�iniz") 
            {
                MessageBox.Show("L�tfen kaydetmek istedi�iniz log tipini se�iniz.");
            }
            else if (txtKayitNotu.Text.Length == 0)
            {
                MessageBox.Show("L�tfen kay�t i�in not ekleyin.");
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
                    lblSonuc.Text = "Ge�erli bir uzant� se�iniz.";
                }
            }
        }
    }
}
