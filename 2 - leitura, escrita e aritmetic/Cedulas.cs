/*
Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
*/



using System;

class program
{
	public static void Main()
	{
		int N = int.Parse(Console.ReadLine());

		int cem = N / 100;
		int resto = N % 100;
		int cinquenta = resto / 50;
		int vinte = ((resto % 50) / 20);
		int dez = (((resto % 50) % 20) / 10);
		int cinco = ((((resto % 50) % 20) % 10) / 5);
		int dois = (((((resto % 50) % 20) % 10) % 5) / 2);
		int um = ((((((resto % 50) % 20) % 10) % 5) % 2) / 1);

		Console.WriteLine("{0}", N);
		Console.WriteLine("{0} nota(s) de R$ 100,00", cem);
		Console.WriteLine("{0} nota(s) de R$ 50,00", cinquenta);
		Console.WriteLine("{0} nota(s) de R$ 20,00", vinte);
		Console.WriteLine("{0} nota(s) de R$ 10,00", dez);
		Console.WriteLine("{0} nota(s) de R$ 5,00", cinco);
		Console.WriteLine("{0} nota(s) de R$ 2,00", dois);
		Console.WriteLine("{0} nota(s) de R$ 1,00", um);
	}
}