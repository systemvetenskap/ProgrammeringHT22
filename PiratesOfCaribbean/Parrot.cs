using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesOfCaribbean
{
    public class Parrot
    {
        public string Name { get; set; }

        public string Talk(string sentence)
        {
            string response = "Kraa ";
            string[] words = sentence.Split(' ');

            for (int i = 0; i < 3; i++)
            {
                response += words[words.Length - 1];
                response += " ";
            }
            // Det här hade också gått att lösa med en loop, men jag valde att...
            // response += words[words.Length - 1] + " " + words[words.Length - 1] + " " + words[words.Length - 1];
            response += "ahoy!!";
            return response;
        }
    }
}
