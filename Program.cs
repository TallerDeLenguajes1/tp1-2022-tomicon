// See https://aka.ms/new-console-template for more information


// problema1();
// problema2();
problema3();

void problema1(){
    int a, b;
    Console.WriteLine("Ingrese un numero para calcular su cuadrado");
    try
    {
    a = Convert.ToInt32(Console.ReadLine());
    b= a * a;
    Console.WriteLine("El cuadrado de " + a + " es " + b);
    }
    catch 
    {
        Console.WriteLine("No se puede realizar el cuadrado del valor ingresado. Asegurese de haber ingresado un numero entero");
    }
}

void problema2(){
    int a, b, c;
    Console.WriteLine("Ingrese dos numeros para calcular su division");
    try
    {
        
    a= Convert.ToInt32(Console.ReadLine());
    b= Convert.ToInt32(Console.ReadLine());
    c = a/b;
    Console.WriteLine(a + " dividido en " + b + " es igual a " + c);
    }
    catch 
    {
        Console.WriteLine("No se pudo realizar la division. Asegurese de haber ingresado dos numeros enteros \ny que el segundo sea distinto de 0");
    }
}

void problema3(){
    double kilometros, litros;
    try
    {
        Console.WriteLine("Ingrese los kilometros recorridos");
        kilometros = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese los litros gastados");
        litros = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Error al calcular. Asegurese de haber ingresado numeros reales y que los litros gastados no sean 0");
    }
}