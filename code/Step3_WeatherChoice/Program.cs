// See https://aka.ms/new-console-template for more information
Console.WriteLine("Выбор Одежды по погоде");
Console.Write("Введите текущую температуру (С):");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    Console.WriteLine("Наденьте легкую одежду");
}
else
{
    Console.WriteLine("Наденьте теплую одежду");
}
Console.WriteLine("Хорошего дня!");
