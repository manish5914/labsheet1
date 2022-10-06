using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Marks
    {
        public int mark = 0;
        //Manish
        //enum usually is in another library 
        enum Categories
        {
            E = 20,
            D = 40,
            C = 60,
            B = 80,
            A = 100
        }
        public Marks()
        {
            MainMenu();
           
        }

        public void MainMenu()
        {
            int endValue = -1;
            Boolean flag = false;
            do
            {
                ShowStartingMessage();
                mark = InputMark();
                if (mark != endValue)
                {
                    Console.WriteLine("The Category for the mark " + mark + " is " + CheckNumber(mark));
                    Console.WriteLine();
                    flag = true;
                }
                else 
                {
                    flag = false;
                }
            } while (flag);
        }
        public void ShowStartingMessage()
        {
            int lastValue = 0;

            foreach(int category in Enum.GetValues(typeof(Categories)))
            {  
                
                Console.WriteLine("Category: " + Enum.GetName(typeof(Categories), category)  + " has the range " + lastValue + "-" + category);
                lastValue = category + 1;
            }
            Console.WriteLine();
            
        }
        public int InputMark()
        {
            Console.Write("Enter Mark: ");
            var inputNumber = int.Parse(Console.ReadLine());
            return inputNumber;
        }

        public String CheckNumber(int mark)
        {
            int lastValue = 0;
            foreach (int category in Enum.GetValues(typeof(Categories)))
            {
                string currentCategory = Enum.GetName(typeof(Categories), category);
               
                if ((mark >= lastValue) && (mark <= category)){
                    return currentCategory;
                }
            }
            return "Error";
        }
    }
}