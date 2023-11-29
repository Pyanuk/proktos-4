
namespace test_na_beremennoct
{
    class NameTable
    {
        static void Main(string[] args) => Load();

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("МС Справа представьтесь:");
            string text = Console.ReadLine();

            new TypingMenu(0, 20, new TypingData(text));
        }
    }
}