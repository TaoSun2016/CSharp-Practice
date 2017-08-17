using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunOfBoxes
{
    class Program
    {
        const int MaxTry = 40;
       
        public static void Main(string[] args)
        {
            Boxes boxes = new Boxes();
            boxes.ShowBoxes();
        }

   
    }
    public class Boxes
    {
        char[] boxes = new char[20];
        public Boxes()
        {
            int j = 0;
            char tmpLetter = ' ';
            boxes = "aabbccddeeffgghhiijj".ToArray();
            Random rd = new Random();
            for (int i =0;i<boxes.Length;i++)
            {
                j = rd.Next(i, boxes.Length);
                if (i!=j)
                {
                    tmpLetter = boxes[i];
                    boxes[i] = boxes[j];
                    boxes[j] = tmpLetter;
                }
            }
        }
        public void ShowBoxes()
        {
            for (int i=0;i<boxes.Length;i++)
            {
                if (boxes[i]!='0')
                {
                    Console.WriteLine("["+i+"] ");
                }
            }
        }
    }
}
