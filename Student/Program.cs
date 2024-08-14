class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        string command = "";

        while(command != "exit")
        {
            Console.WriteLine("Buyuruq kiriting(add, view, delete, exit): ");
            command = Console.ReadLine();

            switch(command)
            {
                case "add":
                    AddStudent();
                    break;
                case "view":
                    ViewStudent();
                    break;
                case "delete":
                    DeleteStudent();
                    break;
                default:
                    Console.WriteLine("Noto'g'ri buyuruq");
                    break;
            } 
        }
    }

    static void AddStudent()
    {
        Console.Write("Talabaning ismi: ");
        string name = Console.ReadLine();
        Console.Write("Talabaning yoshi: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Talabaning telefon raqami: ");
        int phNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Talabaning uyning adresi: ");
        string homeAddr = Console.ReadLine();

        students.Add(new Student(name, age, phNum, homeAddr));
        Console.WriteLine("Talaba qo'shildi.");
    }

    static void ViewStudent()
    {
        Console.WriteLine("Talabalar ro'yxati: ");
        for(int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"{i+1}. Ismi: {students[i].Age} ");
        }
    }

    static void DeleteStudent()
    {
        ViewStudent();
        Console.WriteLine("O'chirish uchun talaba raqamini kiriting: ");
        int studentNumber = Convert.ToInt32(Console.ReadLine());
        if(studentNumber > 0 && studentNumber <= students.Count)
        {
            students.RemoveAt(studentNumber-1);
            Console.WriteLine("Talaba o'chiriladi.");
        }    
        else
        {
            Console.WriteLine("Noto'g'ri raqam.");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set;}

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}

//Class Program - bu kod Program nomli sinfni aniqlaydi.
//C# dasturlari Main metodini o'z ichida olgan sinfdan boshlanadi

//static List<Student> students - new List<Student>(); - bu yerda students nomli List<Student>
//turdagi static o'zgaruvchi yaratilmoqda. Bu ro'yxat barcha talaba obyektlarini saqlaydi.

//Static void Main(string[] args) - Main metodi dastur ishga tushirilganda birinchi bo'lib bajarilgan metoddir
//string[] args parametrini qabul qiladi, bu orqali dasturga komanda qatori argumentlari yuborilish mumkin

//