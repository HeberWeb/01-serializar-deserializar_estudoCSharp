using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _00_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Maria Costa Silva",
                CPF = "333.333.333-00",
                Email = "maria@teste.com"
            };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string serialisado = serializador.Serialize(usuario);

            StreamWriter stream = new StreamWriter(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\01-serializar-deserializar\ArquivosTestes\02_SerializarJSON.json");
            stream.WriteLine(serialisado);
            stream.Close();
        }
    }
}
