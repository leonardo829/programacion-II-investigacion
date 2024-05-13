using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionBE
{
    public class Usuarios
    {

        public DataTable ListaDT { get; set; } = new DataTable();



        public Usuarios()
        {
            ListaDT.TableName = "ListaUsuarios";
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Apellido");
            ListaDT.Columns.Add("Dni", typeof(Int64));
            ListaDT.Columns.Add("Linea");

            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Usuarios.xml"))
            {
                ListaDT.ReadXml("Usuarios.xml");
            }
        }

        public void InsertUsuario(NuevoUsuario aUsuario)
        {

            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aUsuario.Nombre;
            ListaDT.Rows[NuevoRenglon]["Apellido"] = aUsuario.Apellido;
            ListaDT.Rows[NuevoRenglon]["Dni"] = aUsuario.Dni;
            ListaDT.Rows[NuevoRenglon]["Linea"] = aUsuario.Linea;



            ListaDT.WriteXml("Usuario.xml");
        }
    }

}
    
