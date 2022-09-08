int CountStrings(string[] Mass)
{
    int length = Mass.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (Mass[i].Length < 4)
        {
            count++;
        }
    }
    return count;
}

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
    string[] Mass2 = new string[CountStrings(Mass)];
    int length = Mass.Length;
    int ind = 0;

    for (int i = 0; i < length; i++)
    {
        if (Mass[i].Length < 4)
        {
            Mass2[ind] = Mass[i];
            ind++;
        }
    }

    PrintMass(Mass2);
}

Test();