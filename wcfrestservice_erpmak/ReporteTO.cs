using System;
using System.Runtime.Serialization;

namespace MyRESTService.Core
{
    [DataContract(Name = "ReporteTO")]
    public class ReporteTO
    {
        public ReporteTO()
        {
            this.Nombres = string.Empty;
            this.DNI = string.Empty;
            this.Descripcion = string.Empty;
            this.ValorAntes = string.Empty;
            this.ValorDespues = string.Empty;
            this.Tienda = string.Empty;
            this.JustificacionTraslado = string.Empty;
            this.MesNumero = 0;
        }
        [DataMember(Name = "Nombres", Order = 1)]
        public string Nombres { get; set; }
        [DataMember(Name = "DNI", Order = 2)]
        public string DNI { get; set; }
        [DataMember(Name = "Descripcion", Order = 3)]
        public string Descripcion { get; set; }
        [DataMember(Name = "ValorAntes", Order = 4)]
        public string ValorAntes { get; set; }
        [DataMember(Name = "ValorDespues", Order = 5)]
        public string ValorDespues { get; set; }
        [DataMember(Name = "Tienda", Order = 6)]
        public string Tienda { get; set; }
        [DataMember(Name = "Cargo", Order = 7)]
        public string Cargo { get; set; }
        [DataMember(Name = "Turno", Order = 8)]
        public string Turno { get; set; }
        [DataMember(Name = "MesNumero", Order = 9)]
        public int MesNumero { get; set; }
        [DataMember(Name = "Fecha", Order = 10)]
        public DateTime Fecha { get; set; }
        [DataMember(Name = "FechaDesde", Order = 11)]
        public DateTime FechaDesde { get; set; }
        [DataMember(Name = "FechaHasta", Order = 12)]
        public DateTime FechaHasta { get; set; }
        [DataMember(Name = "Estado", Order = 13)]
        public string Estado { get; set; }
        [DataMember(Name = "DistritoOrigen", Order = 14)]
        public string DistritoOrigen { get; set; }
        [DataMember(Name = "DistritoDestino", Order = 15)]
        public string DistritoDestino { get; set; }
        [DataMember(Name = "FecCese", Order = 16)]
        public DateTime FecCese { get; set; }
        [DataMember(Name = "MotivoCese", Order = 17)]
        public string MotivoCese { get; set; }
        [DataMember(Name = "FecIngreso", Order = 18)]
        public DateTime FecIngreso { get; set; }
        public DateTime FecCorte { get; set; }
        public int Num_semana { get; set; }
        public int Altas { get; set; }
        public int Bajas { get; set; }
        public int Req_Acum { get; set; }
        //>= 12 meses
        public int Tramo1 { get; set; }
        // < mayor a 1 mes y menor a 6 meses
        public int Tramo2 { get; set; }
        // < mayor a 6 mes y menor a 12 meses
        public int Tramo3 { get; set; }
        // 2 a 4 semanas
        public int Tramo4 { get; set; }
        // < 1 semana
        public int Tramo5 { get; set; }
        [DataMember(Name = "JustificacionTraslado", Order = 19)]
        public string JustificacionTraslado { get; set; }
    }
}