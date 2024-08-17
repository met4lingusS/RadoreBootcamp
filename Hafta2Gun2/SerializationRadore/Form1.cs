using Newtonsoft.Json;
using System.Xml.Serialization;

namespace SerializationRadore
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

        private void btnSerilestir_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                name = txtAd.Text,
                phone = txtTelefon.Text,
                dob = dateTimePicker1.Value,
                department = txtDepartman.Text,
                salary = Convert.ToInt32(txtMaas.Text),
                additionalInfo = "Serileþtirme olmayacak"
            };
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    xs.Serialize(fsout, employee);
                    MessageBox.Show("Veri serileþtirildi!");
                    txtAd.Text = "";
                    txtTelefon.Text = "";
                    txtDepartman.Text = "";
                    txtMaas.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message.ToString()}");
            }
            finally
            {
                fsout.Close();
            }

        }

        private void btnDeserilestir_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    employee = (Employee)xs.Deserialize(fsin);
                    txtAd.Text = employee.name;
                    txtTelefon.Text = employee.phone;
                    txtDepartman.Text = employee.department;
                    txtMaas.Text = employee.salary.ToString();
                    dateTimePicker1.Value = employee.dob;
                    MessageBox.Show("Veri Deserialize edildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message.ToString()}");
            }
            finally
            {
                fsin.Close();
            }
        }

        private void btnJsonSerialize_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.name = "Product 1";
            product.expireDate = DateTime.Now;
            product.price = 3.14;

            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"C:\Users\metalinguss\Documents\DataCamp_Vault\CSharp\Radore Full Stack Bootcamp\product.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                jsonSerializer.Serialize(writer, product);
                MessageBox.Show("Seileþtirildi");
            }
        }

        private void btnJsonDeserialize_Click(object sender, EventArgs e)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(@"C:\Users\metalinguss\Documents\DataCamp_Vault\CSharp\Radore Full Stack Bootcamp\product.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product readedProduct = (Product)jsonSerializer.Deserialize(reader, typeof(Product));
                MessageBox.Show($"Ürün Adý: {readedProduct.name}\nFiyatý: {readedProduct.price.ToString()}");
            }
        }
    }
}
