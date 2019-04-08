using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José Costa Silva",
                CPF = "222.222.222-22",
                Email = "jose@teste.com"
            };

            StreamWriter stream = new StreamWriter(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\01-serializar-deserializar\ArquivosTestes\01_SerializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            serializador.Serialize(stream, usuario);

            List<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios.Add(new Usuario()
            {
                Nome = "João Costa Silva",
                CPF = "345.575.567-22",
                Email = "joao@teste.com"
            });

            listaUsuarios.Add(new Usuario()
            {
                Nome = "José Costa Silva",
                CPF = "222.222.222-22",
                Email = "jose@teste.com"
            });

            StreamWriter streamList = new StreamWriter(@"C:\Users\hpietrafeza\Documents\ProjetosCursos\01-serializar-deserializar\ArquivosTestes\01_SerializarListaXML.xml");

            XmlSerializer serializadorList = new XmlSerializer(typeof(List<Usuario>));
            serializadorList.Serialize(streamList, listaUsuarios);
        }
    }
}
