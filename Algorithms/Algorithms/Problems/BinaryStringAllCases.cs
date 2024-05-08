using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Problems
{
    public class BinaryStringAllCases
    {
        List<string> Calc(string input)
        {
            List<int> reference = new List<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '?') reference.Add(i);
            }

            List<string> all = new List<string>();

            GenerateBinary(all,new StringBuilder(),reference.Count);


            List<string> result = new List<string>();


            foreach (var item in all)
            {
                int counter = 0;
                StringBuilder s = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != '?')
                        s.Append(input[i]);
                    else
                    {
                        s.Append(item[counter]);
                        counter++;
                    }
                }
                result.Add(s.ToString());
            }

            return result;
        }


        private void GenerateBinary(List<string> result, StringBuilder current, int maxLength)
        {
            if (current.Length >= maxLength)
            {
                result.Add(current.ToString());
                return;
            }


            GenerateBinary(result,new StringBuilder(current.ToString()).Append(0), maxLength);
            GenerateBinary(result, new StringBuilder(current.ToString()).Append(1), maxLength);
        }



        public void Run()
        {
            var result = Calc("001?010?1");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
        
        
    }
}