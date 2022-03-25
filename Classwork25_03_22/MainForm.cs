using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace Classwork25_03_22
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FitnessClub fitnessClub = new FitnessClub();

            XmlSerializer serial = new XmlSerializer(typeof(FitnessClub));
            string path = "..\\..\\Files\\XMLFile.xml";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                fitnessClub = serial.Deserialize(fs) as FitnessClub;
            }

            for (int i = 0; i < 5; i++)
            {
                //VisitorsDGV.Rows.Add(fitnessClub.Visitors[i].vAge, fitnessClub.Visitors[i].vSurname
                //    , fitnessClub.Visitors[i].vAge, fitnessClub.Visitors[i].vTariff);
            }
            //VisitorsDGV.DataSource = fitnessClub.Visitors;
            //SimulatorsDGV.DataSource = fitnessClub.Simulators;
            //TariffDGV.DataSource = fitnessClub.Tariffs;




            //string path = "..\\..\\Files\\XMLFile.xml";
            //XmlDocument document = new XmlDocument();
            //try
            //{
            //    document.Load(path);
            //}
            //catch
            //{
            //    MessageBox.Show($"Файл {path} не доступен", "Ошибка");
            //}
            //XmlSerializer xmls = new XmlSerializer(typeof(FitnessClub));

            //FileStream filestream = new FileStream(path, FileMode.Open);
            ////Экземпляру frmSizeSetup передаем данные, полученные в процессе десериализации
            //var frmSizeSetup = (FitnessClub)xmls.Deserialize(filestream);

            ////MemoryStream memstr = new MemoryStream();
            ////var xmlList = (FitnessClub)xmls.Deserialize(memstr);
        }
    }
}
