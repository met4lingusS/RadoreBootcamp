using Microsoft.Data.SqlClient;
using RegisteringForm.Models;
using RegisteringClassLibrary;
using RegisteringClassLibrary.AttributeClasses;
using System.Xml.Serialization;


namespace RegisteringForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetFormType();
        }

        public void GetFormType()
        {
            List<FormType> formTypes = null;
            using (var context = new RadoreDbContext())
            {
                try
                {
                    formTypes = new List<FormType>();
                    formTypes.Add(new FormType
                    {
                        FormId = -1,
                        FClassName = "seciniz",
                        FDisplayName = "Bir form türü seçiniz"
                    });
                    var dbformTypes = context.FormTypes.ToList();
                    formTypes.AddRange(dbformTypes);

                    cmbFormType.DataSource = formTypes;
                    cmbFormType.DisplayMember = "FDisplayName";
                    cmbFormType.ValueMember = "FClassName";

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata oluþtu: {ex.ToString()}");
                }


                }

            }

        private void btnSelectFormType_Click(object sender, EventArgs e)
        {
            string selectedFormType = cmbFormType.SelectedValue.ToString();
            using (var context = new RadoreDbContext())
            {
                var choosedForm = context.FormTypes.Where(formID => formID.FClassName == selectedFormType).FirstOrDefault();
                if (choosedForm != null)
                {
                    int choosedFormId = Convert.ToInt32(choosedForm.FormId);
                    var questions = context.FormQuestions.Where(form => form.FormId == choosedFormId).ToList();
                    List<Label> labels = new List<Label>
                    {
                        lblQ1,
                        lblQ2,
                        lblQ3
                    };

                    for (int i = 0; i < questions.Count && i < labels.Count; i++)
                    {

                        var questionText = questions[i].QuestionDisplayValue;


                        if (questionText != null)
                        {
                            labels[i].Text = $"{i + 1}. {questionText}:";
                        }
                        else
                        {
                            MessageBox.Show("Soru bulunamadý.");
                        }
                    }
                }
                                                
            }
        }

        private void btnFormKaydet_Click(object sender, EventArgs e)
        {
            
            if (cmbFormType.SelectedValue.ToString() == "seciniz")
            {
                MessageBox.Show("Lütfen bir form tipi seçiniz.");
            }
            else {


                FormData formData = new FormData
                {
                    answer1 = txtAnswer1.Text,
                    answer2 = txtAnswer2.Text,
                    answer3 = txtAnswer3.Text,
                };


                if (!RegisteringRequirementsChecker.Dogrula(formData))
                {
                    MessageBox.Show("Her kutucuðu doldurmanýz gerekmektedir.");
                }
                else
                {
                    XmlSerializer xs = new XmlSerializer(typeof(FormData));
                    FileStream fsout = new FileStream($"{cmbFormType.SelectedValue.ToString()}.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                    try
                    {
                        using (fsout)
                        {
                            xs.Serialize(fsout, formData);
                            MessageBox.Show("Xml dosyasý oluþturukdu!");
                            txtAnswer1.Text = "";
                            txtAnswer2.Text = "";
                            txtAnswer3.Text = "";


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

                    lblSonuc.Text = "Form kaydedildi.";
                }

            }

        }

        private void btnYeniForm_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
