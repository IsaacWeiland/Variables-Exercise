namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jebidiah";
            int myPatience = 0;
            char hatedLtr = 'q';
            bool doSee = true;
            decimal someAmount = 2.40m;
            double otherAmount = 9.6;
            Console.WriteLine($"I am {myName} when do see letter {hatedLtr} is {doSee} my patience is {myPatience}.\nMy bank's interest rate " +
                              $"is {otherAmount} and I get {someAmount} every month!");
        }
    }
}
