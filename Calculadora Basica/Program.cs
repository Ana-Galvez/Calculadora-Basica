double num1;
double num2;
string simbolo = "";

Console.WriteLine("Bienvenido/s a mi calculadora básica \n");
while (simbolo !="salir")
{
    Console.WriteLine("Para salir del programa escriba salir cuando le pide el símbolo matemático");
    Console.WriteLine("Ingrese el primer número (Para decimal ponga ,)");
    while(!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Entrada no válida, vuelva a ingresar");
    }

    Console.WriteLine("");
    Console.WriteLine("Ingrese el segundo número (Para decimal ponga ,)");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Entrada no válida, vuelva a ingresar");
    }

    Console.WriteLine("");
    Console.WriteLine("Ingrese el símbolo matemático + - * /  o  salir");
    simbolo = Console.ReadLine();
    Console.WriteLine("");

    switch (simbolo)
    {
	    case "+":
		    Console.WriteLine($"El resultado de la suma es: {num1 + num2}"); 
		    break;
        case "-":
            Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
            break;
        case "*":
            Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
            break;
        case "/":
            if (num2!=0)
            {
                Console.WriteLine($"El resultado de la división es: {num1 / num2}");
            }else
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            break;
        case "salir":
            Console.WriteLine("Muchas gracias por usar calculadora básica");
            break;
        default:
            Console.WriteLine("El símbolo ingresado es incorrecto");
		    break;
    }
}


