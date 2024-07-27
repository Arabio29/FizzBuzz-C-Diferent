
//Escribir un programa que muestre en pantalla los números del 1 al 100,
//sustituyendo los múltiplos de 3 por la palabra “fizz”,
//los múltiplos de 5 por “buzz” y los múltiplos de ambos,
//es decir, los múltiplos de 3 y 5 (o de 15), por la palabra “fizzbuzz”.
//C#


List<string> result = new List<string>();

for(int i = 1; i < 101; i++)
{
   if(i % 3 == 0 && i % 5 == 0)
    {
        result.Add("FizzBuzz");
    }
   else if(i % 3 == 0)
    {
        result.Add("Fizz");
    }
   else if(i % 5 == 0)
     {
          result.Add("Buzz");
     }
    else
    {
        result.Add(i.ToString());
    }
}


foreach(var miNumero in result)
{
    Console.WriteLine(miNumero);
}


Console.Read();
