int number = 1458199756;
string numberInString = number.ToString();
char[] digitsInNumber = numberInString.ToArray();
List<char> digits = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

foreach (var digit in digits)
{
    int count = 0;
    foreach (var digitInNumber in digitsInNumber)
    {
        if (digitInNumber == digit)
        {
            count++;
        }
    }

    Console.WriteLine($"{digit} => {count}");
}