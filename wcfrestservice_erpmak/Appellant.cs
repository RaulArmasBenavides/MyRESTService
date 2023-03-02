using System.Runtime.Serialization;

namespace wcfrestservice.erpmak.entity
{
    [DataContract]
    public class Appellant
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string AppealStatus { get; set; }
        [DataMember]
        public string StatusDate { get; set; }
    }
}