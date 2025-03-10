using System;
using System.Globalization;

namespace ExerciciosProposto09 {
    class URI {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            string[] nomeMercadoria = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for(int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nomeMercadoria[i] = vet[0];
                precoCompra[i] = double.Parse(vet[1],CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(vet[2],CultureInfo.InvariantCulture);
            }

            double lucro;
            int countMenor10 = 0;
            int countEntre10E20 = 0;
            int countAcima20 = 0;

            //Calculando a Porcentagem dos produtos vendidos
            for(int i = 0; i < n; i++) {
                lucro = ((precoVenda[i] - precoCompra[i]) / precoCompra[i] * 100);
                if(lucro < 10.0) {
                    countMenor10++;
                } else if(lucro >= 10.0 && lucro <= 20.0) {
                    countEntre10E20++;
                } else if(lucro > 20.0) {
                    countAcima20++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + countMenor10);
            Console.WriteLine("Lucro entre 10% e 20%: " + countEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + countAcima20);

            //Calculando a soma dos produtos a preco de custo
            double custo = 0;

            for(int i = 0; i < n; i++) {
                custo = custo + precoCompra[i];
            }
            Console.WriteLine("Valor total de compra: " + custo.ToString("F2",CultureInfo.InvariantCulture));

            //Calculando a soma dos produtos a preco de venda
            double venda = 0;

            for(int i = 0; i < n; i++) {
                venda = venda + precoVenda[i];
            }
            Console.WriteLine("Valor total de venda: " + venda.ToString("F2",CultureInfo.InvariantCulture));

            //Calculando o total de lucro da venda

            double lucroTotal = 0;

            lucroTotal = venda - custo;
            
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}



