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




