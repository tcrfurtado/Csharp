/*
Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
*/



using System;

class program
{
	public static void Main()
	{
	    string[] vetor;
		vetor = Console.ReadLine().Split(' ');
		int cod1 = int.Parse(vetor[0]);
		int qtd1 = int.Parse(vetor[1]);
		double valorUni1 = double.Parse(vetor[2]);

		vetor = Console.ReadLine().Split(' ');
		int cod2 = int.Parse(vetor[0]);
		int qtd2 = int.Parse(vetor[1]);
		double valorUni2 = double.Parse(vetor[2]);

		double valor = (qtd1 * valorUni1) + (qtd2 * valorUni2);

		Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", valor);
	}
}
























