using System.Buffers;


namespace Activity2
{
    public class motor { 
    
         public string Brand { get; set; }

         public string Color { get; set; }
         public int Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            

            List<motor> list = new List<motor>();
            while (true)
            {
                Console.WriteLine("Enter [Y/N] to buy a new motorcyle");

                if (Console.ReadLine() == "N") {
                    break;
                }
                motor motor1 = new motor();

                Console.WriteLine("Enter the Brand of the Motorcyle you want: ");
                motor1.Brand = Console.ReadLine();

                Console.WriteLine("Enter the Color of the Motorcyle: ");
                motor1.Color = Console.ReadLine();

                Console.WriteLine("Enter the Price of the Motorcyle: ");
                motor1.Price = int.Parse(Console.ReadLine());

                list.Add(motor1);
            }

            list.ForEach(motor =>
            {
                Console.WriteLine("====================");
                Console.Write("MOTOR BRAND: ");
                Console.WriteLine(motor.Brand);
                Console.Write("MOTOR COLOR: ");
                Console.WriteLine(motor.Color);
                Console.Write("MOTOR PRICE: ");
                Console.WriteLine(motor.Price);
                Console.WriteLine("====================");
                Console.WriteLine("\n");
            });
         
        }



    }
}