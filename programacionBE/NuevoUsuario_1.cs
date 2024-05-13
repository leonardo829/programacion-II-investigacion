using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionBE
{
    public class NuevoUsuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }

        public string Linea { get; set; }


        public void Aceptar(string aNombre,
                            string aApellido,
                            string aDni,
                            string aLinea)

        {
            Nombre = aNombre;
            Apellido = aApellido;
            Dni = Convert.ToInt64(aDni);
            Linea = aLinea;




        }
    }
}
