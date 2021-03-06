﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace homework01
{
   
    class Target
    {
        
        public Target()
        {
            
         /*   this.name = "noData";

            this.xVal = -99.0;
            this.yVal = -99.0;
            this.zVal = -99.0;
            this.friend = true;
            this.points = -99;
            this.flashRate = -99;
            this.spawnRate = -99;
            this.canSwap = true;
            */
        }
         public Target(string n, double x, double y, double z, bool frn, int pts, int flash, int spawn, bool swap)
        {
            name = n;
            xVal = x;
            yVal = y;
            zVal = z;
            friend = frn;
            points = pts;
            flashRate = flash;
            spawnRate = spawn;
            canSwap = swap;
         }
        public string name { get; set; }
        public double xVal { get; set; }
        public double yVal { get; set; }
        public double zVal { get; set; }
        public bool friend { get; set; }
        public int points { get; set; }
        public int flashRate { get; set; }
        public int spawnRate { get; set; }
        public bool canSwap { get; set; }

        //print all target data
        public void printTargetData()
        {
            
                    Console.WriteLine(name);
                    Console.WriteLine(xVal);
                    Console.WriteLine(yVal);
                    Console.WriteLine(zVal);
                    Console.WriteLine(friend);
                    Console.WriteLine(points);
                    Console.WriteLine(flashRate);
                    Console.WriteLine(spawnRate);
                    Console.WriteLine(canSwap);
                    Console.WriteLine('\n');
         }
        //print target names
        public static int iterator = 0;
        public void printTargetName(int counter)
        {

                       

           for (int i = 1; i <= 1; i++)
           {
               Console.WriteLine("{0}:     {1}", ++iterator, name);

           }
            
            
                       
        }
    
       
       //convert to pig latin
        public void printPiggyLatin()
        {
            //Char[] names = name.ToCharArray();            
            
            string tempName;
            String names = name;
            tempName = names.Substring(1);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Nick\Documents\Piggy.ini", true))
            {

                file.WriteLine("[argetTay]");
                file.Write("ameNay={0}", tempName);
                if (names[0] == 'A' || names[0] == 'E' || names[0] == 'I' || names[0] == 'O' || names[0] == 'U')
                {
                    file.Write("{0}way\n", names[0]);
                }
                else if (names[0] != 'A' || names[0] != 'E' || names[0] != 'I' || names[0] != 'O' || names[0] != 'U')
                {
                    file.Write("{0}ay\n", names[0]);
                }
                file.WriteLine("Xway={0}", xVal);
                file.WriteLine("Yway={0}", yVal);
                file.WriteLine("Zway={0}", zVal);
                file.Write("riendFay=");
                if (friend == true)
                {
                    file.Write("rueTay\n");
                }
                else if (friend == false)
                {
                    file.Write("alseFay\n");
                }
                file.WriteLine("ointsPay={0}", points);
                file.WriteLine("lashRateFay={0}", flashRate);
                file.WriteLine("pawnRateSay={0}", spawnRate);
                file.Write("anSwapCay=");
                if (canSwap == true)
                {
                    file.Write("rueTay\n");
                }
                else if (canSwap == false)
                {
                    file.Write("alseFay\n");
                }
                file.WriteLine("\n");
            }
        }

        //determine if target is a friend
        public void isFriend()
        {
            if (friend == true)
            {
                Console.WriteLine("Aye Captain");
            }
            else if (friend != true)
            {
                Console.WriteLine("Nay Scallywag");
            }

        }
    }
}
