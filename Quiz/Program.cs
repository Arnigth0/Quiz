using System;

class Program
{
    class Answers
    {
        public string Answer { get; set; }
        public bool flag { get; set; }

        public Answers(string Answer, bool flag)
        {
            this.Answer = Answer;
            this.flag = flag;
        }
    }

    class QuestionAnswer
    {
        public string question { get; set; }
        public List<Answers> Answer { get; set; }
       
        public QuestionAnswer(string question, List<Answers> Answer)
        {
            this.question = question;
            this.Answer = Answer;
        }
    }

    static void Main()
    {
        Console.WriteLine("Welcome to our test!");
        List<QuestionAnswer> questAnswer = new()
        {
            new QuestionAnswer("Функция задана формулой у = х^2 - 3х. Значение функции, соответствующее значению аргумента -2, равно:", new()
            {
                new Answers("10", true),
                new Answers("-2", false),
                new Answers("2", false),
                new Answers("-10", false),
            }),
            new QuestionAnswer("Где правильно создана переменная?", new()
            {
                new Answers("int num = \"1\";", false),
                new Answers("char symbol = 'A';", true),
                new Answers("x = 0;", false),
                new Answers("float big_num = 23.2234;", false)
            }),
            new QuestionAnswer("В чем отличие между break и continue?", new()
            {
                new Answers("Break используется в Switch case, а continue в циклах", false),
                new Answers("Continue работает только в циклах, break дополнительно в методах", false),
                new Answers("Continue пропускает итерацию, break выходит из цикла", true),
                new Answers("Нет отличий", false)
            }),
            new QuestionAnswer("Где правильно создан массив?", new()
            {
                new Answers("int[] arr = new Array [2, 5];", false),
                new Answers("int[] arr = new int [2] {2, 5};", true),
                new Answers("int arr = {2, 5};", false),
                new Answers("int arr = [2, 5];", false)
            }),
            new QuestionAnswer("Для чего можно использовать язык C#?", new()
            {
                new Answers("Для создания программ под ПК", false),
                new Answers("Для написания игр", false),
                new Answers("Всё перечисленное", true),
                new Answers("Для создания веб сайтов", false)
            })
        };

        int i = 1;
        double rightAnswer = 0;
        int chose = 0;
        Console.WriteLine("Please chose ID answer!");
        foreach (var quest in questAnswer)
        {
            Console.WriteLine($"\nQuestion N{i++}. {quest.question}");

            var ansId = 1;
            foreach (var answer in quest.Answer)
                Console.WriteLine($"\t{ansId++}. {answer.Answer}");
            

            chose = Convert.ToInt32(Console.ReadLine())!;
            if (Convert.ToInt32(chose) > 0 && Convert.ToInt32(chose) < 10 && quest.Answer[chose - 1].flag == true)
                rightAnswer++;
        }

        Console.WriteLine($"You pass this quiz for {(rightAnswer / (Convert.ToDouble(questAnswer.Count()))) * 100}%");
    }
}
        