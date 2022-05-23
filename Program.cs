int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int contador = 0;
int numeroIngresado;

do
{
    
    Console.WriteLine("Ingrese un número entre en el 1 y el 20 por favor: ");
    numeroIngresado = int.Parse(Console.ReadLine());

    if (numeroIngresado != numeroSecreto)
    {
        if (numeroIngresado > numeroSecreto)
        {
            Console.WriteLine($"El numero {numeroIngresado} es muy GRANDE..!\nVuelva a intentarlo...");
        }
        else
        {
            Console.WriteLine($"El numero {numeroIngresado} es muy CHICO...!\nVuelva a intentarlo...");
        }
    }
    else
    {
        Console.WriteLine($"¡¡Felicitaciones!! Has adivinado, el número secreto era: **{numeroSecreto}**\n Lo has logrado en {contador+1} intentos!!");
        break;
    }

    contador++;
} while (true);

