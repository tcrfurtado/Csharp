/*
Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada
O arquivo de entrada contém 4 valores inteiros.

Saída
Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.
*/


using System;

class program
{
	public static void Main()
	{
		int A = int.Parse(Console.ReadLine());
		int B = int.Parse(Console.ReadLine());
		int C = int.Parse(Console.ReadLine());
		int D = int.Parse(Console.ReadLine());
		
		int DIFERENCA = (A * B - C * D);
		
		Console.WriteLine("DIFERENCA = {0}", DIFERENÇA);
	}
}





































































