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

            for (int i = 0; i < fitnessClub.Visitors.visitorsArray.Length; i++)
            {
                VisitorsDGV.Rows.Add(fitnessClub.Visitors.visitorsArray[i].vName, fitnessClub.Visitors.visitorsArray[i].vSurname
                    , fitnessClub.Visitors.visitorsArray[i].vAge, fitnessClub.Visitors.visitorsArray[i].vTariff.tName); //Обращаемся к объекту-тарифу
            }
                                                                                                                      
            for (int i = 0; i < fitnessClub.Simulators.simulatorsArray.Length; i++)
            {
                SimulatorsDGV.Rows.Add(fitnessClub.Simulators.simulatorsArray[i].sName, fitnessClub.Simulators.simulatorsArray[i].sPrice, fitnessClub.Simulators.simulatorsArray[i].sBodyPart);
            }
            for (int i = 0; i < fitnessClub.Tariffs.tariffsArray.Length; i++)
            {
                TariffDGV.Rows.Add(fitnessClub.Tariffs.tariffsArray[i].tName, fitnessClub.Tariffs.tariffsArray[i].tPrice);
            }
        }
    }
}
