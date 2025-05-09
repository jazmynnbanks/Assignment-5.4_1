static void IndividualDigits(int x)
{

    if (x < 10)
    {
        Console.Write($"{x}" + " ");
    }
    else
    {
       IndividualDigits( x / 10);
        Console.Write(( x % 10 ) + " ");

    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
IndividualDigits(num);