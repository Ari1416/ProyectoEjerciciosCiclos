// Leer un número entero y mostrar todos los pares comprendidos entre 1 y el número leído.

Console.Write("Digite el numero por favor: ");
int Numeropar = Convert.ToInt32(Console.ReadLine());

int Contador = 0;

while (Contador <= Numeropar)
{
    Console.WriteLine(Contador);
    Contador+=2;
}

