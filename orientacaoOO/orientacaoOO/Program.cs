using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Testando a classe!");

            Pessoa p = new Pessoa();
            p.nome = "Matheus Braga";
            p.email = "matheuskbraga9@gmail.com";
            p.idade = 22;
            Console.WriteLine("Existe a pessoa P");
            Console.WriteLine(p.nome);
            Console.WriteLine(p.email);
            Console.WriteLine(p.idade);

            
            Pessoa p2 = new Pessoa();
            p2.nome = "Matheus Faccin";
            p2.email = "faccin.matheus@gmail.com";
            p2.idade = 22;
            Console.WriteLine("Existe a pessoa P");
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.email);
            Console.WriteLine(p2.idade);


            Pessoa p3 = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa: ");
            p3.nome = Console.ReadLine();
            Console.WriteLine("Digite o email da pessoa: ");
            p3.email = Console.ReadLine();
            Console.WriteLine("Digite a idade da pessoa: ");
            p3.idade = int.Parse(Console.ReadLine());
            Console.WriteLine(p3.idade);
            */

            Carro c = new Carro();
            Console.WriteLine("Digite a marca do carro: ");
            c.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro: ");
            c.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação do carro: ");
            c.anoFabricacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Marca do carro: " + c.marca);
            Console.WriteLine("Modelo do carro: " + c.modelo);
            Console.WriteLine("Ano de fabricação do carro: " + c.anoFabricacao);



        }
    }
}
