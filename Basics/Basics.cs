using System;

namespace Basics
{


    class IHateCSharp
    {

        //Declare a constant of type unsigned 8 bit integer named sample1 with an initial value of 0x3A
        public const Byte sample1 = 0x3A;
        //Declare a variable of type unsigned 8 bit integer named sample2 with an initial value of 58
        public Byte sample2;
        //Declare an integer variable named heartRate with an initial value of 85
        public int heartRate;
        //Declare a double variable named deposits that has an initial value of 135002796
        public double deposits;
        //Declare a float constant named acceleration that has an initial value of 9.800
        public const float acceleration = 9.800F;
        //Declare a float variable named mass that has an initial value of 14.6
        public float mass;
        //Declare a double variable named distance that has an initial value of 129.763001
        public double distance;
        //Declare a boolean variable named lost that has an initial value of true
        public bool lost;
        //Declare a boolean variable named expensive that has an initial value of true
        public bool expensive;
        //Declare an integer variable named choice with an initial value of 2
        public int choice;
        //Declare a constant that is a character type named integral that has a value of “\u{ 222B}”
        public const char integral = '\u222B';
        //Create a string constant named greeting that has an initial value of “Hello”
        public const string greeting = "Hello";
        //Create a string variable named name that has an initial value of “Karen”
        public string name;

        public float force;

        public IHateCSharp()
        {

            sample2 = 58;
            heartRate = 85;
            deposits = 135002796;
            mass = (float)14.6;
            distance = 129.763001;
            lost = true;
            expensive = true;
            choice = 2;
            name = "Karen";
            force = mass * acceleration;

        }



        //Compare sample1 to sample2 and if they are equal display “The samples are equal.” otherwise display “The samples are not equal.”
        public void StringComparer()
        {
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }
        }

        //If heartRate is greater than equal to 40 and less than equal to 80 display “Heart rate is normal.” otherwise display “Heart rate is not normal.”
        public void HeartRateCheck()
        {
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }
        }

        //If deposits is greater than or equal to 100000000 display “You are exceedingly wealthy.” otherwise display “Sorry you are so poor.”
        public void depositCheck()
        {
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
        }

        //Display the calculated force preceded by the string “force = ”. The output should look like the following(actual value will be different): force = 2.345
        public void printForce()
        {
            Console.WriteLine($"force = {force}");
        }
        //Display the value of distance followed by “ is the distance.”
        public void printDistance()
        {
            Console.WriteLine($"{distance} is the distance.");
        }
        //Using lost and expensive display “I am really sorry!I will get the manager.” if lost and expensive are both true and “Here is coupon for 10 % off.” if lost is true and expensive is false.
        public void lostCheck()
        {
            if (lost && expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost && !expensive)
            {
                Console.WriteLine("Here is a coupon for 10% off");
            }
        }
        //Use switch/case and the variable choice to display “You chose 1.” if choice is 1, “You chose 2.” if choice is 2, “You chose 3.” if choice is 3, and “You made an unknown choice.” 
        //if choice is something other than 1, 2, or 3.

        public void choiceCheck()
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }
        }
            

       
        //Using the character constant integral, display the character in integral followed by the string “ is an integral.”
        public void printIntegral()
        {
            Console.WriteLine(integral);
        }
        //Using a “for” loop count from 5 to 10(inclusive of start and end) using an integer variable i. Inside the loop display each value of i with a line that is “i = ” 
        //followed by the value of i as in:

        //i = 5
        //i = 6
        //i = 7
        //i = 8
        //i = 9
        //i = 10
        public void forLoop()
        {
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine($"i = {i}");
            }
        }

            

        //Declare an integer variable age with an initial value of 0.Using a “while” loop that continues while age is less than 6 display the value of age in a line 
        //that begins with “age =" and is followed by the value of age. (Example: age = 3) After the age line is displayed increment the value of age by 1.
        public void ageLoop()
        {
            var age = 0;

            while(age < 6)
            {
                Console.WriteLine($"age = {age}");
                age++;
            }
        }


    }

    class Program
    {

       
        static void Main(string[] args)
        {

            var instanceOfIHateCSharp = new IHateCSharp();

            instanceOfIHateCSharp.StringComparer();
            instanceOfIHateCSharp.HeartRateCheck();
            instanceOfIHateCSharp.depositCheck();
            instanceOfIHateCSharp.printForce();
            instanceOfIHateCSharp.printDistance();
            instanceOfIHateCSharp.lostCheck();
            instanceOfIHateCSharp.choiceCheck();
            instanceOfIHateCSharp.printIntegral();
            instanceOfIHateCSharp.forLoop();
            instanceOfIHateCSharp.ageLoop();



        
           

        }

    }


}
