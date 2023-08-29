namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = "";

            var result = (answer < 9) ? response = $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(result);

            //original code to convert:
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + "is greater than or equal to nine";
            //}
            //Console.WriteLine(response);

            //an alternate solution
            //var answer = 4;
            //var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            //Console.WriteLine(response);


        }
    }
}
