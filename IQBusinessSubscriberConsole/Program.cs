using Subscriber.Subscriber.SC;
using System;

namespace IQBusinessSubscriberConsole
{
    public class Program
    {
       static void Main(string[] args)
        {
             
            try
            {          
                Console.WriteLine("Hello Please Enter Your Name! :");

                //Saving the input string  on the Name variable
                string Name = Console.ReadLine();


                //Checking if the inputstring is empty or not
                if (string.IsNullOrEmpty(Name))
                {
                    // Error when the input string is empty
                    Console.WriteLine("Parameter cannot be null, Please Enter Your Name:");
                }
                else
                {
                    //passing the input string to the Logic
                     SubscriberService _subscriberContract = new SubscriberService();
                    _subscriberContract.SendInputString(Name);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
         

            
        }
    }
}
