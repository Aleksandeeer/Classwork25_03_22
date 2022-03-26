using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Classwork25_03_22
{
    [XmlRoot("FitnessClub")]
    [JsonArray("FitnessClub")]
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
        [JsonProperty("visitors")]
        public Visitor[] visitorsArray { get; set; }
    }
    public class Simulators
    {
        [XmlElement("simulator")]
        [JsonProperty("simulators")]
        public Simulator[] simulatorsArray { get; set; }
    }
    public class Tariffs
    {
        [XmlElement("tariff")]
        [JsonProperty("tariffs")]
        public Tariff[] tariffsArray { get; set; }
    }

    public class Visitor
    {
        [XmlAttribute("id", Namespace = "")]
        [JsonIgnore]
        public int vId { get; set; }

        [XmlElement("name", Namespace = "")]
        [JsonProperty("name")]
        public string vName { get; set; }

        [XmlElement("surname", Namespace = "")]
        [JsonProperty("surname")]
        public string vSurname { get; set; }

        [XmlElement("age", Namespace = "")]
        [JsonProperty("age")]
        public byte vAge { get; set; }

        [XmlElement("tariff", Namespace = "")]
        [JsonProperty("tariff")]
        public Tariff vTariff { get; set; }

    }

    [XmlRoot("Tariffs")]
    public class Tariff
    {
        [XmlAttribute("id", Namespace = "")]
        [JsonIgnore]
        public int tId { get; set; }

        [XmlElement("name", Namespace = "")]
        [JsonProperty("name")]
        public string tName { get; set; }

        [XmlElement("price", Namespace = "")]
        [JsonProperty("price")]
        public string tPrice { get; set; }
    }

    [XmlRoot("Simulators")]
    public class Simulator
    {
        [XmlAttribute("id", Namespace = "")]
        [JsonIgnore]
        public int sId { get; set; }

        [XmlElement("name", Namespace = "")]
        [JsonProperty("name")]
        public string sName { get; set; }

        [XmlElement("price", Namespace = "")]
        [JsonProperty("price")]
        public string sPrice { get; set; }

        [XmlElement("bodyPart", Namespace = "")]
        [JsonProperty("bodyPart")]
        public string sBodyPart { get; set; }
    }
}
