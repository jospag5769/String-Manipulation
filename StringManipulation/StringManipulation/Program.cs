using System;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "MyString";
            string myString2;
            int input, input2;

            //get the number from the user and convert to an integer
            //input2 is used for the output, input changes if its value is greater than the length of the string
            Console.Write("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());
            input2 = input;

            //While loop makes sure that the input number is not greater than the length of the string
            //If the input is greater, the length of the string is subtracted from input until it is not.
            while (input > myString.Length)
            {
                input -= myString.Length;
            }

            //create a StringBuilder object and give it the value of the string
            StringBuilder mine = new StringBuilder(myString);

            //keep a reference as to what characters will be inserted to the front of the string
            //determined by the number the user inputs
            myString2 = myString.Substring(myString.Length - input);

            
            //Remove the characters at the end of the string
            //Insert the characters at the front of the string
            //display the output
            mine.Remove(myString.Length - input, input);
            mine.Insert(0, myString2);
            Console.WriteLine("{0} rotated by {1} is: {2}", myString, input2, mine);
            
            
        }
    }
}
