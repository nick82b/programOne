using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;



namespace homework01
{
    class Program
    {
        List<Target> targets;


        static void Main(string[] args)
        {
            string stuff;
            Target[] targets = new Target[25];
            int counter = 0;
            int dataCount = 0;
            char[] delimiterChars = { '=' };
           
            using (TextReader reader = File.OpenText(args[0]))
            {
                while ((stuff = reader.ReadLine()) != null)
                {
                    string[] words = stuff.Split(delimiterChars);
                    
                    if (stuff != "[Target]" && stuff != "\n" && stuff != null &&  !string.IsNullOrEmpty(stuff))
                    {
                        Console.WriteLine(words.ElementAt(1));
                    }
                    
                    

                    if (stuff.ToUpper() == "[Target]")
                    {
                        
                    }

                    else if (!string.IsNullOrEmpty(stuff))
                    {
                        targets = TargetClassData(words, targets, counter);

                        dataCount++;

                        Console.WriteLine("The count is {0}", dataCount);


                    }
                }
            }
            Console.ReadLine();
        }
 public static Target[] TargetClassData(string[] words, Target[] targets, int counter)
        {
            if (words.ElementAt(0).ToUpper() == "NAME")
                targets[counter].name = words.ElementAt(1);

            if (words.ElementAt(0).ToUpper() == "X")
                targets[counter].xVal = Convert.ToDouble(words.ElementAt(1));

            if (words.ElementAt(0).ToUpper() == "Y")
                targets[counter].yVal = Convert.ToDouble(words.ElementAt(1));

            if (words.ElementAt(0).ToUpper() == "Z")
                targets[counter].zVal = Convert.ToDouble(words.ElementAt(1));

            if (words.ElementAt(0).ToUpper() == "FRIEND")
                targets[counter].friend = Convert.ToBoolean(words.ElementAt(1));

            if (words.ElementAt(0).ToUpper() == "POINTS")
                targets[counter].points = Convert.ToInt32(words.ElementAt(1));

            if (words.ElementAt(0).ToUpper() == "FLASHRATE")
                targets[counter].flashRate = Convert.ToInt32(words.ElementAt(1));

            if (words.ElementAt(0).ToUpper() == "SPAWNRATE")
                targets[counter].spawnRate = Convert.ToInt32(words.ElementAt(1));

            if (words.ElementAt(0).ToUpper() == "CANSWAPSIDESWHENHIT")
                targets[counter].canSwap = Convert.ToBoolean(words.ElementAt(1));

            return targets;
        }
    }

}

