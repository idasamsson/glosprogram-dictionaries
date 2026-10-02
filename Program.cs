Console.WriteLine("Glosprogram");

// snabb, fast
List<Word> words = [
/*   ["snabb", "fast"],
    ["snabb", "quick"],
    ["glad", "glad"],
*/
new Word("svenska", "english", "snabb", "fast"), //minnesreferens skapas
new Word("svenska", "english", "glad", "happy"),
    ];

// words [0] => samma minnesreferens


foreach (var word in words)
{
    Console.WriteLine($"{word.FromLanguage}: {word.FromWord} => {word.ToLanguage}: {word.ToWord}");
}

    // key    // value
Dictionary<string, Word> swedishToEnglish = 

// for each word in words
words.ToDictionary(
    word => word.FromWord, // ordet jag vill översätta från
    word => word // hela word objektet (med översättningen till)
);

Console.WriteLine($"Översättningen av snabb är:{swedishToEnglish["snabb"].ToWord}");
Console.WriteLine($"Översättningen av glad är:{swedishToEnglish["glad"].ToWord}");





