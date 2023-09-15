/*Faça um programa que leia as notas referentes às duas avaliações de um aluno. 
Calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas 
(uma nota válida deve pertencer ao intervalo [0,10]). 
Cada nota deve ser validada separadamente.

A entrada contém vários valores reais, positivos ou negativos. O programa deve ser 
encerrado quando forem lidas duas notas válidas.

Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem 
"media = " seguido do valor do cálculo.*/

double nota1, nota2, media;

nota1 = double.Parse(Console.ReadLine());

while(nota1 <0 || nota1 > 10)
{
    Console.WriteLine("nota invalida");
    nota1 = double.Parse(Console.ReadLine());
}

nota2 = double.Parse(Console.ReadLine());

while (nota2 < 0 || nota2 > 10)
{
    Console.WriteLine("nota invalida");
    nota2 = double.Parse(Console.ReadLine());
}

media = (nota1 + nota2) / 2;

Console.WriteLine($"media = {media}");