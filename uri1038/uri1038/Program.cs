using System;
using System.Globalization;

namespace uri1038 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| Codigo | Expecificação   |  Preço  |");
            Console.WriteLine("| 1      | Cachorro quente |  R$4.00 |");
            Console.WriteLine("| 2      | X-Salada        |  R$4.50 |");
            Console.WriteLine("| 3      | X-Bacon         |  R$5.00 |");
            Console.WriteLine("| 4      | Torrada Simples |  R$2.00 |");
            Console.WriteLine("| 5      | Refrigerante    |  R$1.50 |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("Digite o codigo do produto e a quantidade que deseja para saber o valor da compra: ");
            
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
