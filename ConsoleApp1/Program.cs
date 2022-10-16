int valor = 2;

switch (valor)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
        System.Console.WriteLine("Entre 0 e 4");
        break;
    case 5:
        System.Console.WriteLine("Igual a 5");
        break;
    default:
        System.Console.WriteLine("Menor do que 0 ou maior do que 5");
        break;
}
