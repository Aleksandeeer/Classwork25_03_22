using System.Collections.Generic;
using System.Xml.Serialization;

namespace Classwork25_03_22
{
    [XmlRoot("FitnessClub")]
    public class FitnessClub
    {
        [XmlElement("Visitors")]
        public Visitors Visitors { get; set; }

        [XmlElement("Simulators")]
        public Simulators Simulators { get; set; }

        [XmlElement("Tariffs")]
        public Tariffs Tariffs { get; set; }
    }   

    public class Visitors
    {
        [XmlElement("visitor")]
        public Visitor[] visitorsArray { get; set; }
    }
    public class Simulators
    {
        [XmlElement("simulator")]
        public Simulator[] simulatorsArray { get; set; }
    }
    public class Tariffs
    {
        [XmlElement("tariff")]
        public Tariff[] tariffsArray { get; set; }
    }
    public class Visitor
    {
        [XmlAttribute("id", Namespace = "")]
        public int vId { get; set; }

        [XmlElement("name", Namespace = "")]
        public string vName { get; set; }

        [XmlElement("surname", Namespace = "")]
        public string vSurname { get; set; }

        [XmlElement("age", Namespace = "")]
        public byte vAge { get; set; }

        [XmlElement("tariff", Namespace = "")]
        public Tariff vTariff { get; set; }

    }

    [XmlRoot("Tariffs")]
    public class Tariff
    {
        [XmlAttribute("id", Namespace = "")]
        public int tId { get; set; }

        [XmlElement("name", Namespace = "")]
        public string tName { get; set; }

        [XmlElement("price", Namespace = "")]
        public string tPrice { get; set; }
    }

    [XmlRoot("Simulators")]
    public class Simulator
    {
        [XmlAttribute("id", Namespace = "")]
        public int sId { get; set; }

        [XmlElement("name", Namespace = "")]
        public string sName { get; set; }

        [XmlElement("price", Namespace = "")]
        public string sPrice { get; set; }

        [XmlElement("bodyPart", Namespace = "")]
        public string sBodyPart { get; set; }
    }
}
