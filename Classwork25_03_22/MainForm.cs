using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;

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
            //XML
            try
            {
                FitnessClub fitnessClubXML = new FitnessClub();

                XmlSerializer serial = new XmlSerializer(typeof(FitnessClub));
                string pathXML = "..\\..\\Files\\XMLFile.xml";
                using (FileStream fs = new FileStream(pathXML, FileMode.Open, FileAccess.Read))
                {
                    fitnessClubXML = serial.Deserialize(fs) as FitnessClub;
                }

                for (int i = 0; i < fitnessClubXML.Visitors.visitorsArray.Length; i++)
                {
                    VisitorsDGV.Rows.Add(fitnessClubXML.Visitors.visitorsArray[i].vName, fitnessClubXML.Visitors.visitorsArray[i].vSurname, 
                        fitnessClubXML.Visitors.visitorsArray[i].vAge, fitnessClubXML.Visitors.visitorsArray[i].vTariff.tName); //Обращаемся к тарифу пользователя
                }

                for (int i = 0; i < fitnessClubXML.Simulators.simulatorsArray.Length; i++)
                {
                    SimulatorsDGV.Rows.Add(fitnessClubXML.Simulators.simulatorsArray[i].sName, 
                        fitnessClubXML.Simulators.simulatorsArray[i].sPrice, fitnessClubXML.Simulators.simulatorsArray[i].sBodyPart);
                }
                for (int i = 0; i < fitnessClubXML.Tariffs.tariffsArray.Length; i++)
                {
                    TariffDGV.Rows.Add(fitnessClubXML.Tariffs.tariffsArray[i].tName, fitnessClubXML.Tariffs.tariffsArray[i].tPrice);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"XML-Ошибка: {ex}", "Ошибка");
            }

            ////JSON
            //try
            //{
            //    string pathJSON = "..\\..\\Files\\JSONFile.json";
            //    string jsonString = File.ReadAllText(pathJSON);

            //    FitnessClub fitnessClubJSON = new FitnessClub();

            //    fitnessClubJSON = JsonConvert.DeserializeObject<FitnessClub>(jsonString);

            //    for (int i = 0; i < fitnessClubJSON.Visitors.visitorsArray.Length; i++)
            //    {
            //        VisitorsDGV.Rows.Add(fitnessClubJSON.Visitors.visitorsArray[i].vName, fitnessClubJSON.Visitors.visitorsArray[i].vSurname,
            //            fitnessClubJSON.Visitors.visitorsArray[i].vAge, fitnessClubJSON.Visitors.visitorsArray[i].vTariff.tName); //Обращаемся к тарифу пользователя
            //    }

            //    for (int i = 0; i < fitnessClubJSON.Simulators.simulatorsArray.Length; i++)
            //    {
            //        SimulatorsDGV.Rows.Add(fitnessClubJSON.Simulators.simulatorsArray[i].sName,
            //            fitnessClubJSON.Simulators.simulatorsArray[i].sPrice, fitnessClubJSON.Simulators.simulatorsArray[i].sBodyPart);
            //    }
            //    for (int i = 0; i < fitnessClubJSON.Tariffs.tariffsArray.Length; i++)
            //    {
            //        TariffDGV.Rows.Add(fitnessClubJSON.Tariffs.tariffsArray[i].tName, fitnessClubJSON.Tariffs.tariffsArray[i].tPrice);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"JSON-Ошибка: {ex}", "Ошибка");
            //}
        }
    }
}
