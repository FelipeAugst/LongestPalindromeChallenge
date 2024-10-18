namespace BiggestPalindrom

{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            PalindromFinder finder = new PalindromFinder("asovodfksfdsracecarsçf~raod");
            PalindromFinder finder2 = new PalindromFinder("asovodfksfararadsracefdcarsçf~raod");
            PalindromFinder finder3 = new PalindromFinder("asodvodfksfardsardsadsracefdcarsçf~raod");
            Console.WriteLine(finder.Verify());
            Console.WriteLine(finder2.Verify());
            Console.WriteLine(finder3.Verify());
        }
    }
}
