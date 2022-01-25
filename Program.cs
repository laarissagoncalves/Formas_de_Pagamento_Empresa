namespace Formas_de_Pagamento {
    class Program {
        public static void Main (string[] args){

            /*Construa um programa que indique qual a melhor forma de pagamento 
            para a compra realizada por uma empresa. Essa compra será composta por 
            vários produtos e a entrada de dados deve parar quando o usuário digitar 
            como quantidade um valor negativo. O programa deve ler a quantidade de dinheiro 
            existente no caixa de uma empresa (CAIXA), a quantidade de cada item comprado 
            (QTD) e o preço de cada produto (PR). Caso o valor total da compra seja superior 
            a 80% do valor em caixa, a compra deve ser feita a prazo (3x), com juros de 10% 
            sobre o valor total. Caso contrário, a compra deverá ser realizada a vista, onde 
            a empresa receberá 5% de desconto. Apresentar a forma de pagamento escolhida e o 
            valor a ser pago (total a vista ou total a prazo), dependendo da escolha realizada 
            pelo programa.*/

            double caixa, qpc, qtt, pr, pp, ptt, porc, ttjuros, ttdesc;
            
            Console.WriteLine("Valor e forma de pagamento.");
            Console.WriteLine("- Para encerrar o programa digite um número negativo em quantidade de produtos.");
            Console.WriteLine("");
            Console.Write("Entre com a quantidade existente no caixa: ");
            caixa = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            qtt = 0;
            ptt = 0;
            //Calculo do valor a ser gasto com a compra
            do {
                Console.Write("Entre com a quantidade de produto a ser comprado: ");
                qpc = double.Parse(Console.ReadLine());
                if (qpc>0){
                    qtt = qtt+qpc;
                    Console.Write("Entre com o valor unitário do produto: ");
                    pr = double.Parse(Console.ReadLine());
                    pp = pr*qpc;
                    ptt = ptt+pp;
                }
                if (qpc<0)
                    Console.WriteLine("");
            } while (qpc>0);

            porc = caixa * 0.8;
            //Valor da compra superior a 80% do caixa: em 3x com 10% de juros
            if (ptt>porc){
                ttjuros = ((ptt*0.1)+ptt)/3;
                Console.WriteLine("A forma de pagamento é 3x com 10% de juros sobre o valor total R${0:N}, dando R${1:N} por mês.", ptt, ttjuros);
            }
            else
                //Valor da compra abaixo de 80% do caixa: a vista com 5% de desconto
                if (ptt<porc){
                    ttdesc = ptt - (ptt*0.05);
                    Console.WriteLine($"A forma de pagamento é a vista, com 5% de desconto, dando R${ttdesc:N}.");
                }
        }
    }
}
