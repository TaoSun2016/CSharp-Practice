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
            int tryTimes = 0;
            int oldIndex = -1;
            int newIndex = -1;
            char oldValue = '0';
            char newValue = '0';
            Boxes boxes = new Boxes();
            boxes.ShowBoxes();
            do
            {
                Console.Clear();
                boxes.ShowBoxes();
                
                Console.WriteLine("Please input a valid box number:");

                newIndex = int.Parse(Console.ReadLine());
                Console.WriteLine($"input[{newIndex}]");
                newValue = boxes.GetValue(newIndex);
                Console.WriteLine($"value={newValue}");


                if (newValue == '0')
                {
                    continue;
                }

                tryTimes++;

                if (oldIndex!=-1)
                {
                    oldValue = boxes.GetValue(oldIndex);
                }
                else
                {
                    oldValue = '0';
                }
                
                if (oldValue == newValue)
                {
                    boxes.SetValue(oldIndex,'0');
                    boxes.SetValue(newIndex, '0');
                    if (boxes.GetCount() == 0)
                    {
                        Console.WriteLine("Congratulation! You win!!!");
                        return;
                    }
                    oldIndex = -1;
                }
                else
                {
                    oldIndex = newIndex;
                }
            } while (tryTimes < MaxTry);
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
                    Console.Write("["+i+":"+boxes[i]+"] ");
                }
            }
            Console.WriteLine();
        }

        public char GetValue(int index)
        {
            return boxes[index];
        }
        public void SetValue(int index, char value)
        {
            boxes[index] = value;
        }
        public int GetCount()
        {
            int count = 0;
            for (int i=0;i<boxes.Length;i++)
            {
                if (boxes[i]!='0')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
