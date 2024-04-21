using System;
using System.Runtime.Serialization;

namespace MyRESTService.Core
{
    [DataContract(Name = "ReportEntity")]
    public class ReportEntity
    {
        public ReportEntity()
        {
            this.Key = "";
            this.Idmotexce = 0;
            this.IdMotivo = 0;
            this.Fec_fin_t = string.Empty;
            this.Fec_ini_t = string.Empty;

        }

        [DataMember(Name = "key", Order = 1)]
        public string Key { get; set; }

        [DataMember(Name = "idmotexce", Order = 2)]
        public int Idmotexce { get; set; }

        [DataMember(Name = "idMotivo", Order = 3)]
        public int IdMotivo { get; set; }

        [DataMember(Name = "idsoldot", Order = 4)]
        public int Idsoldot { get; set; }

        [DataMember(Name = "fec_ini", Order = 5)]
        public DateTime Fec_ini { get; set; }

        [DataMember(Name = "fec_fin", Order = 6)]
        public DateTime Fec_fin { get; set; }

        [DataMember(Name = "fec_ini_t", Order = 7)]
        public string Fec_ini_t { get; set; }

        [DataMember(Name = "fec_fin_t", Order = 8)]
        public string Fec_fin_t { get; set; }

    }

    [DataContract(Name = "ReportType")]
    public class ReportType
    {
        public ReportType()
        {
            this.Name = string.Empty;
            this.Key = string.Empty;
        }

        [DataMember(Name = "name", Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = "key", Order = 2)]
        public string Key { get; set; }

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
