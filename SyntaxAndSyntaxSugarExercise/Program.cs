namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}

            var liftingYears = 4;
           
            var response = liftingYears <= 9 ? $"With {liftingYears}? You're still just a baby!" : $"With {liftingYears}? You're just starting to get it!";

            Console.WriteLine(response);
            
            
        }
    }
}
  