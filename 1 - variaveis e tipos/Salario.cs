/*
Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Entrada
O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

Saída
Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.
*/


using System;

class program
{
	public static void Main()
	{
		int numero = int.Parse(Console.ReadLine());
		int horaTrab = int.Parse(Console.ReadLine());
		double precoHora = double.Parse(Console.ReadLine());
	

		double salario = (horaTrab * precoHora);

		Console.WriteLine("NUMBER = {0}", numero);
		Console.WriteLine("SALARY = U$ {0:F2}", salario);
	}
}
















































































