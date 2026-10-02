using System.Runtime.InteropServices;

Console.WriteLine("Glosprogram");

List<Word> words = [];

// läser in wordlists
string filePath = Path.Combine("wordlists", "swedish-english.csv");
string[] swedish_english = File.ReadAllLines(filePath); //"wordlists/swedish-english.csv"
Console.WriteLine(swedish_english[0]);
// iterera över en wordlist och splitta varje entry (snabb,fast) till [snabb,fast]

for (int i = 0; i < swedish_english.Length; i++)
{
    var pair = swedish_english[i].Split(",");
    words.Add(new Word ("svenska", "english", pair[0], pair[1]));
}

while (true)
{
    Console.WriteLine("Välj vilka språk du vill översätta mellan, 1:");
    string? toLanguage = Console.ReadLine();

       Console.WriteLine("2:");
    string? fromLanguage = Console.ReadLine();

    Console.WriteLine($"Vill du översätta från {toLanguage} till {fromLanguage} eller tvärtom?");
    string? response = Console.ReadLine();

    bool reverse = false;

    if(response == "tvärtom")
    {
        reverse = true;
    }

    // felhantera genom att kolla om språket jag ber om finns som ToLanguage i listan

                                    // key  // value      // for each word in words
    Dictionary<string, List <Word>> wordDict = words
    .Where(word => word.FromLanguage == fromLanguage)
    .Where(word => word.ToLanguage == toLanguage)
    .GroupBy(word => reverse ? word.ToWord : word.FromWord)
    .ToDictionary(
        group => group.Key, // ordet jag vill översätta från
        group => group.ToList() // lista med våra word objekt som matchar nyckeln
    );

    Console.WriteLine("Välj vilket ord du vill översätta?");
    string? fromWord = Console.ReadLine();

    foreach (var word in wordDict [fromWord!])
    {
        Console.WriteLine($"Översättning: {(reverse ? word.ToWord : word.FromWord)}");
    }

}





