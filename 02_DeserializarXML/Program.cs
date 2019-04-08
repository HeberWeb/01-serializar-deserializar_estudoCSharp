using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\01-serializar-deserializar\ArquivosTestes\01_SerializarXML.xml");
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            Console.WriteLine("Usuário(Nome): {0}, CPF: {1}, Email: {2}", usuario.Nome, usuario.CPF, usuario.Email);
            Console.ReadKey();

            StreamReader streamList = new StreamReader(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\01-serializar-deserializar\ArquivosTestes\01_SerializarListaXML.xml");
            XmlSerializer serializarLista = new XmlSerializer(typeof(List<Usuario>));
            List<Usuario> listaUsuarios = (List<Usuario>)serializarLista.Deserialize(streamList);

            int index = 1;
            foreach (var item in listaUsuarios)
            {
                Console.WriteLine("Item: {0} - Usuário(Nome): {1}, CPF: {2}, Email: {3}", index, item.Nome, item.CPF, item.Email);
                index++;
            }
            Console.ReadKey();
        }
    }
}
