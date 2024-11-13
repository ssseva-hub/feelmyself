namespace BMI_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight: ");
            string weight = Console.ReadLine();
            Console.WriteLine("Enter your height: ");
            string height = Console.ReadLine();
            float w = float.Parse(weight);
            float h = float.Parse(height);
            float BMI = Convert.ToInt32(w / (h * h));
            if (BMI < 18.5)
            {
                Console.Write("Below normal weight. BMI is " + BMI);
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Normal weight. BMI is " + BMI);
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Overweight. BMI is " + BMI);
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("Class 1 Obesity. BMI is " + BMI);
            }
            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine("class 2 Obesity. BMI is " + BMI);
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("Class 3 Obesity. BMI is " + BMI);
            }
            
        }
    }
}
