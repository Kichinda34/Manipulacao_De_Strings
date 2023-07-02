using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_De_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexação ([])
            string nome = "Guilherme";
            char letra = nome[4];
            Console.WriteLine(letra);

            //Concatenação (String.Concat)
            string sobrenome = " Silva Sauro";
            string nomecompleto = nome + sobrenome;
            Console.WriteLine(nomecompleto);

            string nomecompleto2 = string.Concat(nome, sobrenome);
            Console.WriteLine(nomecompleto2);

            //Substituição de strings (Replace)
            string endereco = "Rua das Rosas Verdes";
            endereco = endereco.Replace("Verdes","Vermelhas");
            Console.WriteLine(endereco);

            //Remoção de strings (Replace, Remove)
            string endereco2 = "Rua das Rosas Verdes";
            endereco2 = endereco2.Replace(" Verdes", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Rua das Rosas Azuis";
            endereco3 = endereco3.Remove(0, 4);
            Console.WriteLine(endereco3);

            //Captalização de strings (ToUpper, ToLower)
            string nome2 = "Joao da Silva";
            nome2 = nome2.ToUpper();
            Console.WriteLine(nome2);
            nome2 = nome2.ToLower();
            Console.WriteLine(nome2);

            //Verificando se contém dentro da String (Contains)
            string nome3 = "Joao da Silva";
            bool contem = nome3.Contains("Joao");
            Console.WriteLine(contem);
            contem = nome3.Contains("Marcos");
            Console.WriteLine(contem);

            //Localização de Textos (IndexOf)
            string nome4 = "Joao da Silva";
            int indice = nome4.IndexOf("da");
            Console.WriteLine(indice);

            //Dividindo Strings (Split)
            string nome5 = "Joao da Silva";
            string[] divisores = { "da" };
            string[] resultadoDaDivisão = nome5.Split(divisores, StringSplitOptions.None);
            foreach (string texto in resultadoDaDivisão)
            {
                Console.WriteLine(texto);
            }

            //Número de carácteres (Length)
            string nome6 = "João da Silva";
            int numeroCaracteres = nome6.Length;
            Console.WriteLine(numeroCaracteres);

            //Substring (Substring)
            string nome7 = "João da Silva";
            string ultimoNome = nome7.Substring(8, 5);
            Console.WriteLine(ultimoNome);

            //Formatação Composta
            string nome8 = "João {0} {1}";
            Console.WriteLine(nome8, "da Silva", "Sauro");
            string nomecompleto6 = string.Format(nome8, "da Silva", "Sauro");
            Console.WriteLine(nomecompleto6);

            Console.ReadKey();
        }
    }
}
