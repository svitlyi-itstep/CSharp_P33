using System.Text;
using Game;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.InputEncoding = UTF8Encoding.UTF8;

Random rnd = new Random();

Character player1 = new Character();
player1.Print();
Console.WriteLine();


Character player2 = new Character("James", 90, 8, 0, CharacterRace.Ork);
player2.Print();

while (player1.IsAlive() && player2.IsAlive())
{
    Console.WriteLine();
    int player1_damage = player1.Attack(player2);
    Console.WriteLine($"{player1.name} атакував {player2.name} і наніс {player1_damage} шкоди.");
    Console.WriteLine($"У {player2.name} залишилось {player2.Health} здоров\'я.");
    int player2_damage = player2.Attack(player1);
    Console.WriteLine($"{player2.name} атакував {player1.name} і наніс {player2_damage} шкоди.");
    Console.WriteLine($"У {player1.name} залишилось {player1.Health} здоров\'я.");
}

//player1.GetHealth();
//player1.SetHealth(-100);
//player1.Health = -100;
//Console.WriteLine(player1.Health);
//player1.Race = (CharacterRace)rnd.Next(0, 3);

Console.WriteLine("\n");
player1.Print();
player2.Print();

int number = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Red;


/*

    Змінити механіку атаки таким чином, щоб для персонажів різних рас шкода розраховувалась
    наступним чином:
    Коли Human атакує Ork: -10%
    Коли Human атакує Elf: +10%
    Коли Ork атакує Human: +10%
    Коли Ork атакує Elf: -10%
    Коли Elf атакує Human: -10%
    Коли Elf атакує Ork: +10%
    
    Якщо у персонажів однакова раса, то шкода не змінюється.

    У файлі program.cs додати третього гравця. При атаці кожен гравець випадковим чином обирає
    кого атакувати з двох інших гравців. Повідомлення про атаку так само мають виводитись та
    показувати якого саме персонажа було атаковано.

    Зафіксувати за кожним гравцем свій колір. Виводити імена персонажів їх кольорами.

 */
