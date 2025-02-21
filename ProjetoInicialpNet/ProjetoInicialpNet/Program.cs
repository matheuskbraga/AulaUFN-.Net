namespace ProjetoInicialpNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° valor: ");
            int n1 = primeiraFuncao(0);
            Console.WriteLine("Digite o 2° valor: ");
            int n2 = primeiraFuncao(0);

            funcaoSomar(n1, n2);
            funcaoSubtrair(n1, n2);
            funcaoMultiplicar(n1, n2);
            funcaoDividir(n1, n2);
            Console.WriteLine("-------------------------");
            dataMenu();
            
        }

        static int primeiraFuncao(int valor)
        {
            Console.WriteLine("Qual é o valor de N?");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }

        static void dataMenu()
        {
            var dt = new DateTime();
            Console.WriteLine(dt);

            Console.WriteLine("Dia = " + dt.Day);
            Console.WriteLine("Mês = " + dt.Month);
            Console.WriteLine("Ano = " + dt.Year);
            Console.WriteLine("Hora = " + dt.Hour);
            Console.WriteLine("Minuto = " + dt.Minute);
            Console.WriteLine("Pegando o datatime agora: ");
            dt = DateTime.Now;
            Console.WriteLine("Dia = " + dt.Day);
            Console.WriteLine("Mês = " + dt.Month);
            Console.WriteLine("Ano = " + dt.Year);
            Console.WriteLine("Hora = " + dt.Hour);
            Console.WriteLine("Minuto = " + dt.Minute);

        }

        static void funcaoSomar(int n1, int n2)
        {
            int resultado = n1 + n2;
            Console.WriteLine("A soma dos valores é: "+ resultado);
        }

        static void funcaoSubtrair(int n1, int n2)
        {
            int resultado = n1 - n2;
            Console.WriteLine("A subtração dos valores é: " + resultado);
        }

        static void funcaoMultiplicar(int n1, int n2)
        {
            int resultado = n1 * n2;
            Console.WriteLine("A multiplicação dos valores é: " + resultado);
        }

        static void funcaoDividir(int n1, int n2)
        {
            int resultado = n1 / n2;
            Console.WriteLine("A divisão dos valores é: " + resultado);
        }
    }
}