using System;
using System.Linq;

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
            
           do
            {
                Console.Clear();
                boxes.ShowBoxes();
                Console.Write($"{tryTimes+1} times try,Please input a valid box number:");

                newIndex = Convert.ToInt32(Console.ReadLine());

                newValue = boxes.GetValue(newIndex);
               
                if (newValue == '0')
                {
                    continue;
                }

                tryTimes++;

                if (oldIndex==-1)
                {
                    oldIndex = newIndex;
                    oldValue = '0';
                    continue;
                    
                }

                oldValue = boxes.GetValue(oldIndex);

                if (oldValue == newValue && oldIndex!=newIndex)
                {
                    boxes.SetValue(oldIndex,'0');
                    boxes.SetValue(newIndex, '0');
                    Console.WriteLine($"Good job! You delete two boxes![{oldIndex}][{newIndex}]");
                    if (boxes.GetCount() == 0)
                    {
                        Console.WriteLine("Congratulation! You win!!!");
                        return;
                    }
                    oldIndex = -1;
                    oldValue = '0';
                    Console.Write("Press any key to continue:");
                    Console.ReadLine();
                }
                else
                {
                    oldIndex = newIndex;
                    oldValue = newValue;
                }
            } while (tryTimes < MaxTry);
            Console.WriteLine("Sorry, You failed the game!");
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
            Console.WriteLine("========================================");
            for (int i=0;i<boxes.Length;i++)
            {
                if (boxes[i]!='0')
                {
                    Console.Write("["+i+":"+boxes[i]+"] ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("========================================");
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
