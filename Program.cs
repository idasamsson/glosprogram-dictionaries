Console.WriteLine("Glosprogram");

// snabb, fast
List<Word> words = [
/*   ["snabb", "fast"],
    ["snabb", "quick"],
    ["glad", "glad"],
*/
new Word("svenska", "english", "snabb", "fast"), //minnesreferens skapas
new Word("svenska", "english", "snabb", "quick"),
new Word("svenska", "english", "snabb", "rapid"),
new Word("svenska", "english", "snabb", "speedy"),
new Word("svenska", "english", "glad", "happy"),
new Word("svenska", "english", "glad", "glad"),
new Word("svenska", "english", "stark", "strong"),
new Word("svenska", "english", "stark", "powerful"),
new Word("svenska", "italiano", "snabb", "rapido"),
new Word("svenska", "italiano", "stark", "forte"),
new Word("svenska", "italiano", "stark", "robusto"),
new Word("svenska", "italiano", "glad", "felice"),
    ];


while (true)
{
    Console.WriteLine("Välj vilket språk du vill översätta till:");
    string? toLanguage = Console.ReadLine();

       Console.WriteLine("Välj vilket språk du vill översätta från:");
    string? fromLanguage = Console.ReadLine();

    Console.WriteLine("Vilket ord vill du översätta?");
    string? wordToTranslate = Console.ReadLine();

    // felhantera genom att kolla om språket jag ber om finns som ToLanguage i listan

                                    // key  // value      // for each word in words
    Dictionary<string, List <Word>> wordDict = words
    .Where(word => word.FromLanguage == fromLanguage)
    .Where(word => word.ToLanguage == toLanguage)
    .GroupBy(word => word.FromWord)
    .ToDictionary(
        group => group.Key, // ordet jag vill översätta från
        group => group.ToList() // lista med våra word objekt som matchar nyckeln
    );

    foreach (var word in wordDict [wordToTranslate!])
    {
        Console.WriteLine($"Översättning: {word.ToWord}");
    }

}





