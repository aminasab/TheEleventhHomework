namespace TheEleventhHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var otusDictionary = new OtusDictionary();
            //otusDictionary.Add(1,"thefirst");
            //otusDictionary.Add(1, "thefirst");
            for (int i = 1; i <= 32; i++)
            {
                otusDictionary.Add(i, $"Строка {i}");
            }
            Console.WriteLine(otusDictionary.Get(22));
            Console.WriteLine(otusDictionary.Get(77));
            // Проверка работы индексатора.
            Console.WriteLine(otusDictionary[0].Value);
        }
    }
}