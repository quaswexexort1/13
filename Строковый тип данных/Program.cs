public class FindDuplicateWords
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение (слова через пробел):");
        string sentence = Console.ReadLine().ToLower();

        string[] words = sentence.Split(' ');

        var kolichestvoslov = words.GroupBy(x => x).Where(g => g.Count() == 2).Select(g => g.Key);

        if (kolichestvoslov.Count() > 0)
        {
            Console.WriteLine("Одинаковые слова: " + kolichestvoslov.First());
        }
        else
        {
            Console.WriteLine("Одинаковых слов не найдено или их больше двух.");
        }
    }
}