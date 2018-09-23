// Authur : Yoke Sam Chin
// Date: 09/22/2018
// Description : 
//              Given a string as input, write a program which parses the string and prints it out as a horizontal tree. If the string input is invalid, your program should print, "Invalid!" and exit.
//                    - Individual elements are delimited with a comma followed by space(e.g., ", ")
//                    - Individual groupings are designated with an open bracket[and a close bracket]
//                    - Your program should accomplish this task in the most efficient way possible.
//                    - Empty elements are valid.
// Variables:
//         len_inp_str => number of arguments in application
//         inp_str     => concatenated string of all the arguments.
//         numspc      => number of indentations for grouping string.
//         arr_inp_str => array of string that is delimited with comma.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_DD_Prompt
{
    class Program
    {
        
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int len_inp_str = args.Length;
            string inp_str = string.Empty;
            int numspc = 0;
            
            if (len_inp_str == 0)
            {
                Console.WriteLine("Please input the string. Example: [1, 2, [A, B, C, [5^&, ) ()6, , 7], D, E], 3, 4]");
                return;
            }
            
           // Console.WriteLine(len_inp_str);
           
            for (int i = 0; i < len_inp_str; i++)
            {
                inp_str +=  args[i];
            }

            //Console.WriteLine(inp_str);

            if (inp_str[0] != '[' || (inp_str.Count(e => e == '[') != inp_str.Count(f => f == ']')))
            {
                Console.WriteLine("Invalid!");
                return;
            }

            string[] arr_inp_str = inp_str.Split(',');

           // Console.WriteLine(arr_inp_str.Length);

            for (int i = 0; i < arr_inp_str.Length; i++)
            {
                if ((i > 0) && (arr_inp_str[i].Contains('[')))
                {
                    numspc += 1;
                }

               // Console.WriteLine("number of indentations:" + numspc.ToString());
                Console.WriteLine(new string(' ', numspc) + (arr_inp_str[i].Trim(new char[] { '[', ']' }).PadRight(2)));

                if ((i > 0) && (arr_inp_str[i].Contains(']')))
                {
                    numspc -= 1;
                }              
               
               
            }            

            
        }
    }
}
