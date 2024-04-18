int numeroInicial = 0, numeroFinal = 0, aux = 0;
Console.WriteLine("Escreva o numeroInicial:");
numeroInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Escreva o numeroFinal:" );
numeroFinal = int.Parse(Console.ReadLine());
aux = numeroInicial + 1; 
while (aux < numeroFinal)
{
    if(aux % 2 == 0)
    {
        Console.WriteLine(aux + " Numero par");
        aux++;
    }
    else 
    { 
        Console.WriteLine(aux + " Numero Impar");
        aux++;
    }
}

