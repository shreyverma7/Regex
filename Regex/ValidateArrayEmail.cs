using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class ValidateArrayEmail
    {
        ValidateEmail check = new ValidateEmail();
        //string[] EmailArray = new string[8];
        public void read(string filePath) {
            string readAllText = File.ReadAllText(filePath);
            string[] emails = readAllText.Split(",");
            int i = 0;
            foreach (var data in emails)
            {
                emails[i] = data;
                i++;
            }
            int j = 0;

            foreach (var data in emails)
            {
                
                Console.Write(data+" is ");
               
                check.UC5_Validate(data);
                Console.WriteLine();
            }

        }
        
    }
}
