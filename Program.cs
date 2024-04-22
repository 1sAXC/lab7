namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполнение дерева:");
            Tree tree = Tree.CreateTree(10, 100, 10);
            Console.WriteLine("\n");

            Console.WriteLine("Слева направо:");
            tree.LeftToRight();
            Console.WriteLine("\n");

            Console.WriteLine("Сверху вниз:");
            tree.PrintTopDown();
            Console.WriteLine("\n");

            Console.WriteLine("Снизу вверх:");
            tree.DownTop();
            Console.WriteLine("\n");
        }
    }
}
