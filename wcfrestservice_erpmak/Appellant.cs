using System.Runtime.Serialization;

namespace MyRESTService.Core
{
    [DataContract]
    public class Appellant
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; } = string.Empty;
        [DataMember]
        public string AppealStatus { get; set; } = string.Empty;
        [DataMember]
        public string StatusDate { get; set; } = string.Empty;
    }
}