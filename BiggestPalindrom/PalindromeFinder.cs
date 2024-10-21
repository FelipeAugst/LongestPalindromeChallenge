using System;
using System.Collections.Generic;
using System.Text;



namespace BiggestPalindrome
{
    public class PalindromeFinder

    {
        private string str;
        private string longest;
        private int size;
        private string token = "123456789";

        public PalindromeFinder(string str)
        {
            this.str = str;
            this.longest = "";

        }
        public bool IsPalindrome(string str)

        {
            int begin = 0;
            for (int end = str.Length-1; begin <= end; end--, begin++)
            {
                if (str[begin] != str[end])
                {
                    return false;

                }

            }
            return true;

        }
        public string Verify()

        {
            
   
            for (int begin = 0; begin < this.str.Length; begin++)
            {
                for (int end = begin; end != this.str.Length; end++)

                {
                    

                    if ((!IsPalindrome(str[begin..end]) || (str[begin..end].Length < 2)))
                    {
                        continue;
                    }
                    if (str[begin..end].Length > size)
                    {
                        this.size = str[begin..end].Length;
                        this.longest = str[begin..end];
                    }



                }

            }
            
            
                return this.size ==0? TokenGenerator("none") : TokenGenerator(this.longest);
        }
        private string TokenGenerator(string str)
        { var tokenizedString = new StringBuilder();
            var tokenIndex = 0;
            var tokenSize = this.token.Length - 1;
            foreach(var letter in str)
            {
                tokenizedString.Append(letter);
                tokenizedString.Append(this.token[tokenIndex]);
                tokenIndex++;
                
            }
            
            if (tokenSize - tokenIndex > 0)
            {
                
                tokenizedString.Append(this.token[tokenIndex..tokenSize]);
            }

            return tokenizedString.ToString();

        }
    }

}
