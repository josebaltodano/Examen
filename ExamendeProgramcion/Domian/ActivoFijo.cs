using System;
using System.Collections.Generic;
using System.Text;

namespace Domian
{
     public class ActivoFijo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string  Nombre { get; set; }
        public string  Descripcion { get; set; }
        public  decimal  ValorActivo { get; set; }
        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaDeAdquision { get; set; }
        public TipoActivo TipoActivo { get; set; }
        public MetodoDeDepreciacion  Metodo  { get; set; }

        public decimal Depreciacion { get; set; }
    }
   }
   

