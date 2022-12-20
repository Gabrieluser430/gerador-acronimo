try
{
    // Input do usuário
    Console.WriteLine("Please enter a phrase to convert to an acronym: ");
    String input = Console.ReadLine();

    // Exclusões opcionais
    String exclusions = input.Replace("and", "");
    String[] wordArr = exclusions.Split(" ");
    Console.WriteLine(wordArr.Length);

    // Loop
    String acronym = "";
    for (int i = 0; i < wordArr.Length; i++ ) 
    {
        if (wordArr[i] != "")
        {
            acronym += wordArr[i][0];
        }
        acronym = acronym.ToUpper();

        Console.WriteLine($"Your acronym is: {acronym}");
    }
}
catch(Exception e)
{
    Console.WriteLine(e.ToString());
}