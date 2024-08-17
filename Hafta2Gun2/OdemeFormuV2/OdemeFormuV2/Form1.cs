using OdemeFormuV2.Models;

namespace OdemeFormuV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OdemeTipiGetir();
        }

        public void OdemeTipiGetir()
        {
            List<OdemeTipi> odemeTipleri = null;

            using (var context = new RadoreDbContext()) 
            {
                try 
                {
                    odemeTipleri = new List<OdemeTipi>();
                    odemeTipleri.Add(new OdemeTipi
                    {
                        Id = -1,
                        ClassName = "seciniz",
                        DisplayName = "Lütfen bir ödeme yöntemi seçin"
                    
                    });

                    var dbOdemeTipleri = context.OdemeTipis.ToList();
                    odemeTipleri.AddRange(dbOdemeTipleri);
                    cmbOdemeTipi.DataSource = odemeTipleri;
                    cmbOdemeTipi.DisplayMember = "DisplayName";
                    cmbOdemeTipi.ValueMember = "ClassName";
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Hata oluþtu: {ex.ToString()}");
                }

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

                lblSonuc.Text = $"{cmbOdemeTipi.SelectedValue.ToString()} ile {txtTutar.Text} TL tutarýnda iþlem yapýlmýþtýr.";

            }
        }
    }
}
