using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestPalindrom
{
    public class PalindromFinder

    {
        private string str;
        private string token = "123456789";

        public PalindromFinder(string str)
        {
            this.str = str;

        }
        public bool IsPalindrom(string str)

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
            int size = 0;
            string biggest = "";
            for (int begin = 0; begin < this.str.Length; begin++)
            {
                for (int end = begin; end != this.str.Length; end++)

                {
                    Range substring = begin..end;

                    if ((!IsPalindrom(str[substring]) || (str[substring].Length < 3)))
                    {
                        continue;
                    }
                    if (str[substring].Length > size)
                    {
                        size = str[substring].Length;
                        biggest = str[substring];
                    }



                }

            }
            if(size== 0)
            {
                return TokenGenerator("none");
            }
            return TokenGenerator(biggest);
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
                Range range = tokenIndex..tokenSize;
                tokenizedString.Append(this.token[range]);
            }

            return tokenizedString.ToString();

        }
    }

}
