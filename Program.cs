double milhas, km;

Console.Write("Entre com a medida (em milhas): ");
milhas = Convert.ToDouble(Console.ReadLine());

km = 1609 * milhas;
Console.WriteLine($"{km} km");