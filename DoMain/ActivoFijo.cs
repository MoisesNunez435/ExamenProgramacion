using DoMain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoMain
{
    public class ActivoFijo
    {
        public int ID { get; set; }
        public string CodigoActivo { get; set; }
        public string NombreActivo { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivoFijo TipoAFijo { get; set; }
        public MetodoDepreciacion MetodoDpr { get; set; }


    }
}
