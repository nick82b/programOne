using System;
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
        public void printTargetData(/*pass in the values here*/)
        {
            /*bool nameFind = false;
            for (int i = 0; i <= num; i++)
            {
                if (target[i].name.ToUpper() == fileString.Substring(6).ToUpper())
                {*/
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
                   /* nameFind = true;
                }
            }

            if (nameFind == false)
            {
                Console.WriteLine("There is no target with that name.");
            }*/
        }
        //print target names
        public void printTargetName()
        {
            Console.WriteLine(name);           
        }
    
       
       //convert to pig latin
        public void printPigLatin()
        {

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
