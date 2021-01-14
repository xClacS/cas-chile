using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using cDatos;

namespace cNegocio
{
    public class CommonBC
    {
        private static PruebaVB_198810045Entities _modPrueba;
        public static PruebaVB_198810045Entities ModPrueba
        {
            get
            {
                if (_modPrueba == null)
                {
                    _modPrueba = new PruebaVB_198810045Entities();
                }
                return _modPrueba;
            }
        }
        public CommonBC() { }
    }
}
