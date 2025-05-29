Console.Clear();

int numero, tabuada, tabuadaTotal;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine()!);
tabuada = 1;

Console.Clear();

mudaCor();
Console.WriteLine($"Tabuada do {numero}");
Console.ResetColor();

while (tabuada <= 10)
{
    tabuadaTotal = numero * tabuada;
    Console.WriteLine($"{numero} x {tabuada} = {tabuadaTotal}");
    tabuada++;
}

void mudaCor()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
}