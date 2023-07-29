namespace ChessConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("ЦСКА");
            Console.WriteLine("Æ");
            Console.WriteLine("\u2614");
            Console.WriteLine("\u001B[0m f");
            Console.WriteLine("\u001B[97m f");
            Console.WriteLine("\u001B[30m f");
            Console.WriteLine("\u001B[0m f");

            Console.WriteLine("♙");
            Console.WriteLine('♙');
            Console.WriteLine("\u001B[47m \u001b[30m \u2614");
            Console.WriteLine("\u001B[0;100m♕");
            Console.WriteLine( "\u001B[45m f");
        }
    }
}