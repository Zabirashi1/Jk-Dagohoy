using System;

namespace Activity1 {

    public class Math
    {
        public int Add(int num1,int num2) {
            return num1 + num2;
        }
    
       public int Sub(int num1,int num2)
        {
            return num1 - num2;
        }
        public int Dev(int num1, int num2)
        {
            return num1 / num2;
        }
        public int Tims(int num1, int num2)
        {
            return num1 * num2; ;
        }

        //main method

        class Program { 
          static void Main(string[] args)
            {
                //object
                Math math = new Math();


                int num1, num2;

                // ADD
                Console.WriteLine("Enter NUMBER to ADD");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Other NUMBER to ADD ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("TOTAL : " +math.Add(num1,num2));
                Console.WriteLine("                                           ");

                //SUB
                Console.WriteLine("Enter NUMBER to SUB");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Other NUMBER to SUB ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("TOTAL : " + math.Sub(num1, num2));
                Console.WriteLine("                                           ");

                //Dev
                Console.WriteLine("Enter NUMBER to DEVIDE");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Other NUMBER to DEVIDE ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("TOTAL : " + math.Dev(num1, num2));
                Console.WriteLine("                                           ");

                // Tims
                Console.WriteLine("Enter NUMBER to MULTIPLY");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Other NUMBER to MULTIPLY ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("TOTAL : " + math.Tims(num1, num2));
                Console.WriteLine("                                           ");


            }
        }







    }


}