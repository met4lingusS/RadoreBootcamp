using OdemeFormuV3.Classes;
using OdemeFormuV3.Models;

namespace OdemeFormuV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OdemeTipiClassOlustur();
            OdemeTipiGetir();
        }
        public void OdemeTipiGetir()
        {
            List<OdemeTipi> odemeTipleri = new List<OdemeTipi>
            {
                new OdemeTipi
                {
                    Id = -1,
                    ClassName = "seciniz",
                    DisplayName = "Lütfen bir ödeme yöntemi seçin"
                }
            };

            using (var context = new RadoreDbContext())
            {
                var dbOdemeTipleri = context.OdemeTipis.ToList();
                odemeTipleri.AddRange(dbOdemeTipleri);

                cmbOdemeTipi.DataSource = odemeTipleri;
                cmbOdemeTipi.ValueMember = "ClassName";
                cmbOdemeTipi.DisplayMember = "DisplayName";
            }
            
           

        }

        public void OdemeTipiClassOlustur()
        {
            try
            {
                using (var context = new RadoreDbContext())
                {
                    var odemeTipleri = context.OdemeTipis.ToList();
                    var propertyNames = new List<string> { "ClassName", "DisplayName" };

                    foreach (var odemeTipi in odemeTipleri)
                    {
                        var className = odemeTipi.ClassName; // Assuming ClassName is used as the filename
                        var classCode = CodeGenerator.GenerateClassCode(className, propertyNames);

                        var filePath = Path.Combine("C:\\Users\\metalinguss\\Documents\\DataCamp_Vault\\CSharp\\Radore Full Stack Bootcamp\\OdemeFormuV3\\OdemeFormuV3\\Classes\\OdemeTipleri", $"{className}.cs");
                        File.WriteAllText(filePath, classCode);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hata oluþtu: {e.Message}");
            }
        }


        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            var selectedOdemeTipi = cmbOdemeTipi.SelectedItem as OdemeTipi;
            double tutar;

            if (selectedOdemeTipi.ClassName == "seciniz")
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
                return;
            }
            if (!double.TryParse(txtTutar.Text, out tutar))
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");
                return;
            }

            if (selectedOdemeTipi != null)
            {
                using (var context = new RadoreDbContext())
                {
                    // Use the selectedOdemeTipi object for further processing
                    var className = selectedOdemeTipi.ClassName;
                    var displayName = selectedOdemeTipi.DisplayName;

                    tutar = Convert.ToDouble(txtTutar.Text);

                   lblSonuc.Text =$"{displayName} ile {tutar} TL iþlem yapýlmýþtýr.";
                }
                
            }
            else
            {
                MessageBox.Show("Bir ödeme tipi seçin.");
            }
        }
    

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            cmbOdemeTipi.SelectedIndex = -1;
            txtTutar.Text = string.Empty;
            lblSonuc.Text = string.Empty;
            OdemeTipiGetir();


        }
    }
}

