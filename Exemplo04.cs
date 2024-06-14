using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExpressionCsharp
{
    internal class Exemplo04
    {
        public static void Main(string[] args)
        {
            int MinhaIdade = 35;
            int IdadeVotacao = 18;

            Console.WriteLine(MinhaIdade >= IdadeVotacao); //   Retorna verdadeiro pois pessoas a partir de 18 anos podem votar e a pessoa com 35 anos atinge os pré requisitos para exercer essa ação
        }

    }
}
