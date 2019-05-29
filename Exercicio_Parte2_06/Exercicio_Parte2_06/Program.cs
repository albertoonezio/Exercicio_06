using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiraNota = 0; //Recebe o valor da primeira Nota
            int segundaNota = 0; //Recebe o valor da segunda Nota
            int terceiraNota = 0; //Recebe o valor da terceira Nota
            int mediaNotas = 0;

            //Pede o usuário para digitar o valor da primeira nota
            Console.Write("Digite o valor da Primeira nota: ");
            primeiraNota = int.Parse(Console.ReadLine());

            //Pede o usuário para digitar o valor da segunda nota
            Console.Write("Digite o valor da Segunda nota: ");
            segundaNota = int.Parse(Console.ReadLine());

            //Pede o usuário para digitar o valor da terceira nota
            Console.Write("Digite o valor da Terceira nota: ");
            terceiraNota = int.Parse(Console.ReadLine());

            mediaNotas = (primeiraNota + segundaNota + terceiraNota) / 3;

            if (mediaNotas >= 6)
            {
                Console.WriteLine("Aluno APROVADO");
            }

            else
            {
                Console.WriteLine("Aluno REPROVADO");
            }
        }
    }
}
