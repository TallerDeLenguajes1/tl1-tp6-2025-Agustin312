// See https://aka.ms/new-console-template for more information
float b;
float numero;

b=0;
Console.WriteLine("Ingrese un numero mayor a 0 para encontrarle su inverso: ");

if(float.TryParse(Console.ReadLine(),out numero)){
    if (numero > 0)
    {
        b = 1/numero;

        Console.WriteLine("El valor del inverso es:"+b);
    }else{
        Console.WriteLine("El valor ingresado es menor o igual a 0 por lo que no se puede hacer la inversion ");
    }

    Console.WriteLine("El valor de numero ingresado es:"+numero);
}else{
    Console.WriteLine("No ingreso ningun valor");
}

