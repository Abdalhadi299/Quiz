    ﻿int points = 0;
Console.WriteLine("Välkommen till Abdalhadis frågesport!");


Console.WriteLine("1: vad har sveriges flagga för färger?");
Console.WriteLine("a) blå och svart  b) gul och blå  c) gul och rött");
string answer1 = Console.ReadLine();
if (answer1 == "b")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}


Console.WriteLine("2: vilken bil märke har sverige tillverkats och som är mest känd i sverige ?");
Console.WriteLine("a) volkswagen  b) toyota  c) volvo");
string answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}


Console.WriteLine("3:vad heter sveriges kung?");
Console.WriteLine("a) Carl Gustaf Folke Hubertus b) Harald V  c) Charles III av huset Windsor");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("CORRECT");
}
else
{
  Console.WriteLine("INCORRECT");
}


Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du har alltså ingen koll alls.");
}
else if (points < 3)
{
  Console.WriteLine("grattis du e grym.");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt!");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();




























// string name = "Abdalhadi";

//     bool isAlive = name == "Abdalhadi";

// int hp = 100;

// hp = hp + 10;
// hp += 10;

// hp += 1;
// hp++;
// Console.WriteLine($"du har {hp} hp kvar");

// if (hp > 0)
// {
//     Console.WriteLine("yay! du lever!");
// }

Console.WriteLine();



Console.ReadLine();