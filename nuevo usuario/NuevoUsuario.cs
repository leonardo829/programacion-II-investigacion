using System;
using programacionBE;


namespace programacionBE
{
    public class NuevoUsuario

    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }
        

        public void Aceptar(string aNombre,
                            string aApellido,
                            string aDni)

        {
            Nombre = aNombre;
            Apellido = aApellido;
            Dni = Convert.ToInt64(aDni);



        }

    }
}
