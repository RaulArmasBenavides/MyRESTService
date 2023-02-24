using System;
using System.Runtime.Serialization;

namespace MyRESTService.Entity
{
    [DataContract(Name = "ReportEntity")]
    public class ReportEntity
    {
        public ReportEntity()
        {
            this.key = "";
            this.idmotexce = 0;
            this.idMotivo = 0;
            this.fec_fin_t = string.Empty;
            this.fec_ini_t = string.Empty;

        }

        [DataMember(Name = "key", Order = 1)]
        public string key { get; set; }

        [DataMember(Name = "idmotexce", Order = 2)]
        public int idmotexce { get; set; }

        [DataMember(Name = "idMotivo", Order = 3)]
        public int idMotivo { get; set; }

        [DataMember(Name = "idsoldot", Order = 4)]
        public int idsoldot { get; set; }

        [DataMember(Name = "fec_ini", Order = 5)]
        public DateTime fec_ini { get; set; }

        [DataMember(Name = "fec_fin", Order = 6)]
        public DateTime fec_fin { get; set; }

        [DataMember(Name = "fec_ini_t", Order = 7)]
        public string fec_ini_t { get; set; }

        [DataMember(Name = "fec_fin_t", Order = 8)]
        public string fec_fin_t { get; set; }

    }

    [DataContract(Name = "ReportType")]
    public class ReportType
    {
        public ReportType()
        {
            this.name = string.Empty;
            this.key = string.Empty;
        }

        [DataMember(Name = "name", Order = 1)]
        public string name { get; set; }

        [DataMember(Name = "key", Order = 2)]
        public string key { get; set; }

    }


    [DataContract(Name = "FilterEntity")]
    public class FilterEntity
    {
        public FilterEntity()
        {
            this.Turno = string.Empty;
        }

        [DataMember(Name = "Turno", Order = 1)]
        public string Turno { get; set; }
    }
}
