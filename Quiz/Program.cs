class Program
{
    class Answers
    {
        public string Answer { get; set; }
        public bool Flag { get; set; }

        public Answers(string Answer, bool Flag)
        {
            this.Answer = Answer;
            this.Flag = Flag;
        }
    }

    class QuestionAnswer
    {
        public string Question { get; set; }
        public List<Answers> Answer { get; set; }
       
        public QuestionAnswer(string Question, List<Answers> Answer)
        {
            this.Question = Question;
            this.Answer = Answer;
        }
    }

    static void Main()
    {
        Console.WriteLine("Добро пожаловать в QUIZ!");
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
        Console.WriteLine("Пожалуйства вводите только ID ответа!");
        foreach (var quest in questAnswer)
        {
            Console.WriteLine($"\nВопрос №{i++}. {quest.Question}.");

            var ansId = 1;
            foreach (var answer in quest.Answer)
                Console.WriteLine($"\t{ansId++}. {answer.Answer}.");          

            int chose = Convert.ToInt32(Console.ReadLine())!;
            if (quest.Answer[chose - 1].Flag == true)
                rightAnswer++;
        }

        Console.WriteLine($"Вы сдали тест на {(rightAnswer / (Convert.ToDouble(questAnswer.Count()))) * 100}%.");
    }
}
        