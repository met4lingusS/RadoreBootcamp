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
        // Form y�klenirken yap�lmas�n� istedi�imiz i�leri burada tan�mlar�z
        private void Form1_Load(object sender, EventArgs e)
        {
            OdemeTipiGetir();

        }

        public void OdemeTipiGetir()
        {
            string connectionString = @"Data Source=DESKTOP-9A51HHS\METALINGUSS;Initial Catalog=RadoreDB;Integrated Security=SSPI;";
            List<OdemeTipi> odemeTipleri = null;
            using SqlConnection conn = new SqlConnection(connectionString);
            {
                try
                {
                    // Ba�lant� a��lmas�
                    conn.Open();
                    string sorgu = "SELECT * FROM OdemeTipi";
                    // New Query alan�na eri�im verilen sorgunun olu�turulmas�
                    SqlCommand sqlCommand = new SqlCommand(sorgu, conn);
                    // Olu�turulan sorgunun execute edilmesi
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    odemeTipleri = new List<OdemeTipi>();
                    odemeTipleri.Add(new OdemeTipi()
                    {
                        id = -1,
                        className = "seciniz",
                        displayName = "�deme Tipi Se�iniz"

                    });
                    // Read() metodundan true d�nd��� s�rece -sat�rda veri varsa true d�ner- while daki i�lemleri yapar
                    while (reader.Read())
                    {
                        odemeTipleri.Add(new OdemeTipi()
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            className = Convert.ToString(reader["CLASS_NAME"]),
                            displayName = Convert.ToString(reader["DISPLAY_NAME"])
                        });
                    }
                    // OdemeTipi �eklinde veri alan listenin i�inde elemanlar�m�z olacak
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata olu�tu: {ex.ToString()}");
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
                MessageBox.Show("L�tfen bir �deme y�ntemi se�iniz.");
            }
            else if (txtTutar.Text.Length == 0)
            {
                MessageBox.Show("L�tfen tutar giriniz.");
            }
            else
            {
                // Kullan�c�n�n se�ti�i �deme y�nteminin kar��l��� olan className de�erini al�yoruz
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

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
