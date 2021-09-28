using System;
using System.Collections.Generic;
using System.Text;
using Domian;


namespace Domian
{
   public  class Metodos
    {
        ActivoFijo[] activos;

        public ActivoFijo jp { get; private set; }

        public void add(ActivoFijo fijo)
        {
            if (activos.Length ==0)
            {
                activos[0] = jp;


            }else if (activos.Length > 0)
            {
                ActivoFijo[] fijos = new ActivoFijo[activos.Length + 1];
                Array.Copy(activos, fijos, activos.Length);
                fijos[fijos.Length - 1] = jp;
                activos = fijos;            }

        }
        public void LineaDepreciacion()
        {

        }            
    }
}
