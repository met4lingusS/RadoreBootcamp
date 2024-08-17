using OdemeFormu.Classes;
using OdemeFormu.Interfaces;
using System.Data.SqlClient;

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
        // Form yüklenirken yapýlmasýný istediðimiz iþleri burada tanýmlarýz
        private void Form1_Load(object sender, EventArgs e)
        {
            OdemeTipiGetir();

        }

        public void OdemeTipiGetir()
        {
            string connectionString = @"ConnectionString";
            List<OdemeTipi> odemeTipleri = null;
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                try
                {
                    // Baðlantý açýlmasý
                    conn.Open();
                    string sorgu = "SELECT * FROM OdemeTipi";
                    // New Query alanýna eriþim verilen sorgunun oluþturulmasý
                    SqlCommand sqlCommand = new SqlCommand(sorgu, conn);
                    // Oluþturulan sorgunun execute edilmesi
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    odemeTipleri = new List<OdemeTipi>();
                    odemeTipleri.Add(new OdemeTipi()
                    {
                        id = -1,
                        className = "seciniz",
                        displayName = "Ödeme Tipi Seçiniz"

                    });
                    // Read() metodundan true döndüðü sürece -satýrda veri varsa true döner- while daki iþlemleri yapar
                    while (reader.Read())
                    {
                        odemeTipleri.Add(new OdemeTipi()
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            className = Convert.ToString(reader["CLASS_NAME"]),
                            displayName = Convert.ToString(reader["DISPLAY_NAME"])
                        });
                    }
                    // OdemeTipi þeklinde veri alan listenin içinde elemanlarýmýz olacak
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata oluþtu: {ex.ToString()}");
                }
                finally
                {
                    conn.Close();
                }

                cmbOdemeTipi.DataSource = odemeTipleri;
                cmbOdemeTipi.DisplayMember = "displayName";
                cmbOdemeTipi.ValueMember = "className";
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTipi.SelectedValue.ToString() == "seciniz")
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
            else if (txtTutar.Text.Length == 0)
            {
                MessageBox.Show("Lütfen tutar giriniz.");
            }
            else
            {
                // Kullanýcýnýn seçtiði ödeme yönteminin karþýlýðý olan className deðerini alýyoruz
                string secilenOdemeTipi = cmbOdemeTipi.SelectedValue.ToString();
                double tutar = Convert.ToDouble(txtTutar.Text);
                OdemeIslemiFactory factory = new OdemeIslemiFactory();
                IOdemeTipi odemeTipi = factory.NesneOlustur(secilenOdemeTipi);

                if (odemeTipi != null)
                {
                    lblSonuc.Text = odemeTipi.ode(tutar);
                }
                else
                {
                    lblSonuc.Text = "Geçersiz ödeme tipi seçildi.";
                }
            }

            /* Aþaðýdaki if-else if yapýsý sonuca götürse de yeni özellikler eklenmesi zahmetlidir
            // Reflection ve Factory Design Pattern dinamik kod yazmamýza imkan verir
            
            // pop-up iletiþim kutusu çýkarmak için:
            // MessageBox.Show($"Seçtiðiniz ödeme tipi: {secilenOdemeTipi}");
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

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
