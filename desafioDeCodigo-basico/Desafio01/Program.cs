/*Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e 
a soma de seus dígitos.*/

using System;
Console.WriteLine("Digite um valor inteiro ");
int inteiro = Convert.ToInt32(Console.ReadLine());
int produto = 1, soma=0;
while(inteiro>0){
    int dezena = inteiro%10;
    produto= produto * dezena;
    soma= soma + dezena;
    inteiro = inteiro/10;
}

Console.WriteLine(produto - soma);






// int centena=0;
// if(inteiro>100&&inteiro>1000)
// {centena = inteiro /100;
// }
// Console.WriteLine(centena);
