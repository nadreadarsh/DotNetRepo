using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public  class FirstOccurance
    {
        static void Main(string[] args)
        {
            string str = "This is a sample string with the word 'is' in it";
            for (int  i=0;i<str.Length;i++) {
                string temp = "";
                int j;
                for( j =0; j<str.Length && str[j] != ' '; j++)
                {
                    temp = temp + str[j];
                }
                if (temp.Equals("is")){
                    Console.WriteLine("The Index Of The Word Is " + (j - temp.Length));
                }
            }
          
        }
    }
}
