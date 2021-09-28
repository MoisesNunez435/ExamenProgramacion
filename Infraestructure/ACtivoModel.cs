using DoMain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
    public class ActivoModel
    {
        public ActivoFijo[] activos;

        public void Add(ActivoFijo af, ref ActivoFijo[] acts)
        {
            if(acts == null)
            {
                acts = new ActivoFijo[1];
                acts[acts.Length - 1] = af;
                return;
            }

            ActivoFijo[] tmp = new ActivoFijo[acts.Length + 1];
            Array.Copy(acts, tmp, acts.Length);
            tmp[tmp.Length - 1] = af;
            acts = tmp;
        }

        //public decimal CalcularDprLineaRecta(ActivoFijo e)
        //{
        //    decimal[] TotalDpr = new decimal[];

        //}

        public string GetActiveAsJason()
        {
            return JsonConvert.SerializeObject(activos);
        }
    }
}
