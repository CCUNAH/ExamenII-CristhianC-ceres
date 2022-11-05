using System;

namespace Entidades
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Identidad { get; set; }

        public string NombreCliente { get; set; }

        public string TipoSoporte { get; set; }

        public string Tipoequipo { get; set; }

        public decimal Costo{ get; set; }

        public string DescripcionProblema { get; set; }

        public string DescripcionSolucion { get; set; }

        public DateTime fecha { get; set; }
    }
}
