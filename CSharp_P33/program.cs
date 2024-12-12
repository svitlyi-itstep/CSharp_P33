using System.Text;
using Game;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.InputEncoding = UTF8Encoding.UTF8;

Character player1 = new Character();
player1.Print();
Console.WriteLine();


Character player2 = new Character("James", 90, 8, 0);
player2.Print();

while (player1.IsAlive() && player2.IsAlive())
{
    player1.Attack(player2);
    player2.Attack(player1);
}

player1.GetHealth();
player1.SetHealth(-100);
player1.Health = -100;
Console.WriteLine(player1.Health);

Console.WriteLine("\n");
player1.Print();
player2.Print();

int number = Convert.ToInt32(Console.ReadLine());

