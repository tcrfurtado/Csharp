Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

MAIOR AB = (a+b+abs(a-b))/2

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".


using System;

class program
{
	public static void Main()
	{
		int A = int.Parse(Console.ReadLine());
		int B = int.Parse(Console.ReadLine());
		int C = int.Parse(Console.ReadLine());

		int maiorAB = (A + B + Math.Abs(A - B)) / 2;
		int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;
		
		if (maiorABC > maiorAB)
		{
			Console.WriteLine("{0} eh o maior", maiorABC);
		}
		else
		{
		Console.WriteLine("{0} eh o maior", maiorAB);
		}
	}
}



















