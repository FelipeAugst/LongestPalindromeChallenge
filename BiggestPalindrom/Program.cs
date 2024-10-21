namespace BiggestPalindrome

{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            PalindromeFinder finder = new PalindromeFinder("asovodfksfdsracecarsçf~raod");
            PalindromeFinder finder2 = new PalindromeFinder("asovodfksfararadsracefdcarsçf~raod");
            PalindromeFinder finder3 = new PalindromeFinder("asodvodfksfardsardsadsracefdcarsçf~raod");
            Console.WriteLine(finder.Verify());
            Console.WriteLine(finder2.Verify());
            Console.WriteLine(finder3.Verify());
        }
    }
}
