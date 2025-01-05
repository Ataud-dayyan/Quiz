namespace QuizApp;

public static class QuizQuestions
{
    public static bool Quiz (string correctAnswer)
    {
        List<string> options = new List<string> { "A", "B", "C", "D"};
        bool correct = false;
        while(!correct)
        {
            Console.Write("Your answer: ");
            string answer = Console.ReadLine()!.ToUpper();
            if(!options.Contains(answer))
            {
                Console.WriteLine("You didnt input a valid option Try Again");
            } 
            else if(answer == correctAnswer)
            {
                Console.WriteLine("Your answer is correct");
                correct = true;
                return true;
            } 
            else
            {
                Console.WriteLine("Your answer is incorrect");
                break;
            }
        }
        return false; 
    }
}
