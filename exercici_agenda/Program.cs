
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercicio_01
{
    class Program
    {
        public class Pessoa
        {
            private int codigoPessoa { get; set; }
            private int Idade { get; set; }
            private int numTelefone { get; set; }
            public Pessoa()
            {
                codigoPessoa = 0;
                Idade = 0;
                numTelefone = 0;
            }
            public void Dados()
            {
                Console.WriteLine("Informe codigo da Pessoa");
                codigoPessoa = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a Idade: ");
                Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a Altura: ");
                numTelefone = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            public void Imprimir()
            {
                Console.WriteLine("Codigo da Pessoa: { 0}" + codigoPessoa);
                Console.WriteLine("Idade é: { 0}", +Idade);
                Console.WriteLine("O telefone é : { 0}", +numTelefone);
            }
        }


        static void Main(string[] args)
        {
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Dados();
            novaPessoa.Imprimir();
        }
    }
}
