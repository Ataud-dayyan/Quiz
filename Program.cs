using QuizApp;

class Program 
{
    static void Main()
    {
        int count = 0;
        Console.WriteLine("Answer the following questions correctly");
        Console.WriteLine("\n1. Who is The President of Nigeria");
        Console.WriteLine("(A) Buhari \n(B) Tinubu \n(C) Obasonjo \n(D) Atiku ");
        if(QuizQuestions.Quiz("B"))
        {
            count++;
        }

        Console.WriteLine("\n 2. The song 'Die with a smile' was based on which anime");
        Console.WriteLine("(A) Naruto \n(B) Juijutsu Kaisen \n(C) Attack on Titan \n(D) Kaiju No8 ");
        if (QuizQuestions.Quiz("C"))
        {
            count++;
        }

        Console.WriteLine("\n 3. Who among the Companions of the was known as Lion of Allah");
        Console.WriteLine("(A) Hazrat Ali (ra) \n(B) Hazrat Abubakr (ra) \n(C) Hazrat Khadija (ra) \n(D) Hazrat Hamza (ra) ");
        if(QuizQuestions.Quiz("D"))
        {
            count++;
        }
        Console.WriteLine("\n 4. How many countries are in Africa");
        Console.WriteLine("(A) 54 \n(B) 26 \n(C) 38 \n(D) 44 ");
        if (QuizQuestions.Quiz("A"))
        {
            count++;
        }
        Console.WriteLine("\nTotal Score = {0}/4 ", count);

    }
}



