using System;

namespace TpFinal_Hernandez
{
    class Program
    {
        static void Main(string[] args)
        {
             //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

//a. El mayor de los números pares.
//b. La cantidad de números impares
//c. El menor de los números primos.
int num;
int mayorNumPar=0;
int cantImpares=0;
int contPrimo=0;
int menorNumPrimo=0;
int i=0;
Console.WriteLine("ingrese un numero: ");
num=int.Parse(Console.ReadLine());
while(num!=0)
{
if(num%2==0 && num>mayorNumPar)
{
    mayorNumPar=num;
}
else if (num%2 != 0)
{
    cantImpares++;
}

    if(esPrimo(num))
    {
        i++;
    }
   if(i==1 || num<menorNumPrimo)
   {
    menorNumPrimo=num;
   }
   
    
    
    
Console.WriteLine("ingrese un numero: ");
num=int.Parse(Console.ReadLine());
}
   
Console.WriteLine("el mayor numero par es: " + mayorNumPar);
Console.WriteLine("el menor numero primo es: " + menorNumPrimo);
Console.WriteLine("la cantidad de numeros impares es: " + cantImpares);
    

}  
static bool esPrimo(int num)
{
    int contPrimo=0;
for(int x=1;x<=num;x++)
{
    if(num%x==0)
    {
        contPrimo++;
    }}
    if(contPrimo==2)
       { 
        return true;
   contPrimo=0;
       }  
       else return false; 
       
}   
}
}