using OdemeFormu.Classes;
using OdemeFormu.Interfaces;

namespace OdemeFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTipi.SelectedItem == null || cmbOdemeTipi.SelectedItem.ToString() == "Se�iniz")
            {
                MessageBox.Show("L�tfen bir �deme y�ntemi se�iniz.");
            }
            else if (txtTutar.Text.Length == 0)
            {
                MessageBox.Show("L�tfen tutar giriniz.");
            }
            else
            {
                string secilenOdemeTipi = cmbOdemeTipi.SelectedItem.ToString();
                double tutar = Convert.ToDouble(txtTutar.Text);
                OdemeIslemiFactory factory = new OdemeIslemiFactory();
                IOdemeTipi odemeTipi = factory.NesneOlustur(secilenOdemeTipi);

                if (odemeTipi != null)
                {
                    lblSonuc.Text = odemeTipi.ode(tutar);
                }
                else
                {
                    lblSonuc.Text = "Ge�ersiz �deme tipi se�ildi.";
                }
            }

            /* A�a��daki if-else if yap�s� sonuca g�t�rse de yeni �zellikler eklenmesi zahmetlidir
            // Reflection ve Factory Design Pattern dinamik kod yazmam�za imkan verir
            
            // pop-up ileti�im kutusu ��karmak i�in:
            // MessageBox.Show($"Se�ti�iniz �deme tipi: {secilenOdemeTipi}");
            OdemeIslemi odemeIslemi;
            if (secilenOdemeTipi == "KrediKarti")
            {
                KrediKarti krediKarti = new KrediKarti();
                odemeIslemi = new OdemeIslemi(krediKarti);
                lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
            }
            else if (secilenOdemeTipi == "MailOrder")
            {
                MailOrder mailOrder = new MailOrder();
                odemeIslemi = new OdemeIslemi(mailOrder);
                lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
            }
            else if (secilenOdemeTipi == "ApplePay")
            {
                ApplePay applePay= new ApplePay();
                odemeIslemi = new OdemeIslemi(applePay);
                lblSonuc.Text = odemeIslemi.OdemeYap(tutar);
            }
            */



            

        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
