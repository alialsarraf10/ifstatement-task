

string name, language;

Console.Write("Write your name:");
name = Console.ReadLine();

Console.Write("Write your language (en/es/fr/tr): ");
language = Console.ReadLine();




if (language == "en")
{
    Console.WriteLine($"Hello {name}");
}
else if (language == "es")
{
    Console.WriteLine($"Hola {name}");
}
else if (language == "fr")
{
    Console.WriteLine($"Bonjour {name}");
}
else if (language ==  "tr")
{
    Console.WriteLine($"Merhaba {name}");
}
else
{
    Console.WriteLine("incorrect input");
}



Console.Write("Write the 1st number:");
string num1 = Console.ReadLine();

Console.Write("Write the 2nd number:");
string num2 = Console.ReadLine();


int value1 = Convert.ToInt32(num1);
int value2 = Convert.ToInt32(num2);

if (value1 > value2)
{
    Console.WriteLine($"{value1} is greater than {value2}");
}
else if (value1 < value2)
{
    Console.WriteLine($"{value1} is less than {value2}");
}
else
{
    Console.WriteLine("They are equal");
}


Console.Write("Write the 2nd number:");
string mark = Console.ReadLine();

int grade = Convert.ToInt32(mark);

if  (grade >= 80)
{
    Console.WriteLine("A");
}
else if (grade >= 70)
{
    Console.WriteLine("B");
}
else if (grade >= 60)
{
    Console.WriteLine("C");
}
else if (grade >= 50)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}