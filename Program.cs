void PrintMass(string[] Mass)
{
    int length = Mass.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(Mass[i]);
    }
}

void Test()
{
    string[] Mass = new string[] {"hello", "2", "world", ":-)"}; //Проверяемый массив
    int length = Mass.Length;
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (Mass[i].Length < 4)
        {
            count++;
        }
    }

    string[] Mass1 = new string[count];
    int ind = 0;

    for (int i = 0; i < length; i++)
    {
        if (Mass[i].Length < 4)
        {
            Mass1[ind] = Mass[i];
            ind++;
        }
    }

    PrintMass(Mass1);
}

Test();