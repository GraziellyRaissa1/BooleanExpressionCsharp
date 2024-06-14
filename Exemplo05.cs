using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

//Uma abordagem ainda melhor seria agrupar o código acima em uma if...else,
//para que possamos executar ações diferentes dependendo do resultado:

namespace BooleanExpressionCsharp
{
    internal class Exemplo05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor digite a sua idade:");

            int Idade = Convert.ToInt32(Console.ReadLine ());
    
            if (Idade >= 18) 
            {
                Console.WriteLine("Pode votar!");
            }

            else
            {
                Console.WriteLine("Não pode votar");
            }
        }
    }
}
