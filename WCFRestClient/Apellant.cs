using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
