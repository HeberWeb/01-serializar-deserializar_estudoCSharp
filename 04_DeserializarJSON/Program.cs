using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.Web.Script.Serialization;
using System.IO;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\01-serializar-deserializar\ArquivosTestes\02_SerializarJSON.json");
            string allLines = stream.ReadToEnd();
            stream.Close();

            JavaScriptSerializer deserializador = new JavaScriptSerializer();
            Usuario usuario =  (Usuario)deserializador.Deserialize(allLines, typeof(Usuario));

            Console.WriteLine("Usuário(Nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();
        }
    }
}
