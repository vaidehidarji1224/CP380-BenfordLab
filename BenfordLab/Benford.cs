using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BenfordLab
{
    public class BenfordData
    {
        public int Digit { get; set; }
        public int Count { get; set; }

        public BenfordData() { }
    }

    public class Benford
    {
       
        public static BenfordData[] calculateBenford(string csvFilePath)
        {
            // load the data
            var data = File.ReadAllLines(csvFilePath)
                .Skip(1) // For header
                .Select(s => Regex.Match(s, @"^(.*?),(.*?)$"))
                .Select(data => new
                {
                    Country = data.Groups[1].Value,
                    Population = int.Parse(data.Groups[2].Value)
                });

             
            int[] arr = new int[mi];  //new array    // manipulate the data!

            int o = 0;
            foreach (var p in data)     //   - Country
            {
                arr[o] = FirstDigit.getFirstDigit(p.Population);  //   - Digit (using: FirstDigit.getFirstDigit() )
                o++;
            }

            List<BenfordData> D = new List<BenfordData>();
            for (int j = 1;  j< 10; j++)   //   - you need to count how many of *each digit* there are
            {
                int a = 0;
                for (int a = 0; a < arr.Length; a++)
                {
                    if (a == arr[a])
                    {
                        a++;
                    }
                }
                D.Add(new BenfordData
                {
                    Digit = j,
                    Count = a
                });
                D.Concat(D);
            }
            var m = D;

            return m.ToArray();
        }
    }
        }
   