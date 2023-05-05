using System.Security.Cryptography;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Point p;
            //Console.WriteLine(p);

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();

            p.X = 30;
            p.Y = 15;
            Console.WriteLine(p);*/

            //double x = null; Impossivel

            /*
            double? x = null;

            double? y = 10.0;
            
            
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            

            if (x.HasValue) 
            {
                Console.WriteLine(x.Value);
            }
            else 
            {
                Console.WriteLine("x é nulo");
            }

            if (y.HasValue) 
            {
                Console.WriteLine(y.Value);
            }
            else 
            {
                Console.WriteLine("y é nulo");
            }
            */


            /*
            Console.WriteLine("Quantas entradas vai inserir: ");
            int n = int.Parse(Console.ReadLine());
            double[] vetAlturas = new double[n];

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Indique uma altura: ");
                vetAlturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            double soma = 0.0;

            for (int i = 0;i < n; i++) 
            {
                soma += vetAlturas[i]; 
            }

            double media = soma / n;

            Console.WriteLine("A média das altura é: "+ media.ToString("F2"));
            */

            /*
            Console.WriteLine("Quantos produtos vai inserir: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine());
                vet[i]= new Produto {Nome = nome, Preco = preco};
            }

            double soma = 0.0;

            for (int i = 0;i < n; i++) 
            {
                soma += vet[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("A média do preço dos produtos é: " + media.ToString("F2"));
            */

            /*
            Console.WriteLine("Quantos produtos vai inserir: ");
            int n = int.Parse(Console.ReadLine());
            */

            int n;
            Produto[] vet = new Produto[9];

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Nome da pessoa: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email da pessoa: ");
                string email = (Console.ReadLine());
                Console.WriteLine("Quarto desejado: ");
                
                vet[i] = new Produto { Nome = nome, Email = email, Quarto = quarto };
            }
            /*
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine("A média do preço dos produtos é: " + media.ToString("F2"));
            */





        }  

    }
}