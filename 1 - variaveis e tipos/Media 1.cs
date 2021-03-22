using System;

class program
{
	public static void Main()
	{
		string[] vetor = Console.ReadLine().Split(' ');
		int cod1 = int.Parse(vetor[0]);
		int qtd1 = int.Parse(vetor[1]);
		double valorUni1 = double.Parse(vetor[2]);

		string[] vetor = Console.ReadLine().Split(' ');
		int cod2 = int.Parse(vetor[0]);
		int qtd2 = int.Parse(vetor[1]);
		double valorUni2 = double.Parse(vetor[2]);


		double valor = (quantidade1 * valorUni1) + (quantidade2 * valorUni2);

		Console.WriteLine("VALOR A PAGAR = R$ {0:F2}", valor);
	}
}




























