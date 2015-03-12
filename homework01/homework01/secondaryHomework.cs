using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
/* 
 Still not complete. Had to erase and comment stuff out just to attempt to get it to still compile. Everytime I get 
 * close to something that is right  it just won't compile.
 */

namespace homework01
{
        class Program
    {
        //print all target data
        private static void PrintAllTargetData(List<Target> tar, int tarNum)
        {
            int count = tarNum;
            
            tar[count].printTargetData();
            /*for (int i = 0; i < 6; i++)
            {
                tar[0].printTargetData();
            }*/
        }
        
            
        //print target names
        private static void PrintTargetName(List<Target> tar)
        {            
            for (int i = 0; i < tar.Count; i++)
            {
                tar[i].printTargetName(tar.Count);
            }
            Target.iterator = 0;
        }
        
        //print targets in alphabetical order    
        private static void PrintOrderedTarget(List<Target> tar)
        {
            var ordered = tar.OrderBy(x => x.name.ToUpper()).ToList();
            for (int i = 0; i < ordered.Count; i++)
            {
                ordered[i].printTargetName(ordered.Count);
            }
        }

       //convert to pig latin
        private static void printPigLatin(List<Target> tar)
        {
            for (int i = 0; i < tar.Count; i++)
            {
                tar[i].printPiggyLatin();
            }
            
        }

       //is target a friend
        private static void friendTarget(List<Target> tar, int tarNum)
        {
            int count = tarNum;

            tar[count].isFriend();
        }
        static void Main(string[] args)
        {
            string stuff;
            List<Target> targets = new List<Target>();
            char[] delimiterChars = { '=', ' ', '\t'};
            string[] words;
            Target temp;
            int iter = 0;
            string info;
            int friendFoe;
            string exit;
            
            using (TextReader reader = File.OpenText(args[0]))
            {
                
                while ((stuff = reader.ReadLine()) != null)
                {
                    words = stuff.Split(delimiterChars);
                    
                        if (words[0] == "[Target]")
                        {
                            stuff = reader.ReadLine();
                            words = stuff.Split(delimiterChars);
                        }

                        temp = new Target();
                    
                    
 
                    while (words[0] != "[Target]" && stuff != null)
                     {           
 
                        if (words.ElementAt(0).ToUpper() == "NAME")
                         {
                             temp.name = words.ElementAt(1);
                         }
                         else if (words.ElementAt(0).ToUpper() == "X")
                         {
                             temp.xVal = Convert.ToDouble(words.ElementAt(1));
                         }
                         else if (words.ElementAt(0).ToUpper() == "Y")
                         {
                             temp.yVal = Convert.ToDouble(words.ElementAt(1));
                         }
                         else if (words.ElementAt(0).ToUpper() == "Z")
                         {
                             temp.zVal = Convert.ToDouble(words.ElementAt(1));
                         }
                         else if (words.ElementAt(0).ToUpper() == "FRIEND")
                         {
                              temp.friend = Convert.ToBoolean(words.ElementAt(1));
                         }
                         else if (words.ElementAt(0).ToUpper() == "POINTS")
                         {
                             temp.points = Convert.ToInt32(words.ElementAt(1));
                         }
                         else if (words.ElementAt(0).ToUpper() == "FLASHRATE")
                         {
                             temp.flashRate = Convert.ToInt32(words.ElementAt(1));
                         }
                         else if (words.ElementAt(0).ToUpper() == "SPAWNRATE")
                         {
                             temp.spawnRate = Convert.ToInt32(words.ElementAt(1));
                         }
                         else if (words.ElementAt(0).ToUpper() == "CANSWAPSIDESWHENHIT")
                         {
                             temp.canSwap = Convert.ToBoolean(words.ElementAt(1));
                         }
                             
                            stuff = reader.ReadLine();
                            if (stuff != null)
                            {
                                words = stuff.Split(delimiterChars);
                            }
                        
                     }
                        targets.Add(temp);

                       
                }
                    
                    //Switch statement for user choice
                    int menuchoice  = 0;  
                    while (menuchoice != 6)  
                   {  

                        Console.WriteLine("MENU");  
                        Console.WriteLine("Select your command:");  
                        Console.WriteLine("1. Print target names");  
                        Console.WriteLine("2. Print target info");  
                        Console.WriteLine("3. Print sort target names");                      
                        Console.WriteLine("4. Print Pig Latin");  
                        Console.WriteLine("5. isFriend");  
                        Console.WriteLine("6. Exit");  

                        menuchoice = int.Parse(Console.ReadLine()); 
                   
                        switch (menuchoice)
                         {
                            case 1:
                                PrintTargetName(targets);
                                break;
                            case 2:
                                Console.WriteLine("Choose a Target Number: ");
                                friendFoe = int.Parse(Console.ReadLine());
                                PrintAllTargetData(targets, friendFoe);
                                break;
                            case 3:
                                PrintOrderedTarget(targets);
                                break;
                            case 4:
                                printPigLatin(targets);
                                break;
                            case 5:
                                Console.WriteLine("Choose a Target Number: ");
                                friendFoe = int.Parse(Console.ReadLine());
                                friendTarget(targets, friendFoe - 1);
                                break;
                            case 6:
                                break;
                            default:
                                Console.WriteLine("Incorrect entry, must be an integer 1 through 6");
                                break;

                    }
                }
            
            }
           // Console.ReadLine();
        }
        
        
    

    }

}

