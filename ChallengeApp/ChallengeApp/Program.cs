var name = "Zuzia";
var isFemale = true;
var age = 25;

if (isFemale && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!isFemale && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}