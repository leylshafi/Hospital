namespace Hospital;

class Menu
{
    public User User { get; set; }
    public Doctor[] Pediatria =
    {
        new Doctor(1,"Doc1Pedi","Surname1",4),
        new Doctor(2,"Doc2Pedi","Surname2",10),
        new Doctor(3,"Doc3Pedi","Surname3",7)
    };
    Doctor[] Travmatologiya =
    {
        new Doctor(1,"Doc1Trav","Surname1",7),
        new Doctor(2,"Doc2Trav","Surname2",18)
    };
    Doctor[] Stamotologiya =
    {
        new Doctor(1,"Doc1Stom","Surname1",10),
        new Doctor(2,"Doc2Stom","Surname2",3),
        new Doctor(3,"Doc3Stom","Surname3",12),
        new Doctor(4,"Doc4Stom","Surname4",30)
    };

    private int SelectedIndex;
    private string[] Options;
    public Menu(string[] options)
    {
        SelectedIndex = 0;
        Options = options;
    }

    private void DisplayOptions()
    {
        Console.WriteLine();
        for (int i = 0; i < Options.Length; i++)
        {
            string prefix;
            string currentOption = Options[i];
            if (SelectedIndex == i)
            {
                prefix = "*";
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                prefix = "";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

            }
            Console.WriteLine($"{prefix}<<{currentOption}>>");
        }
        Console.ResetColor();
    }
    public int Run()
    {

        ConsoleKey key;
        do
        {
            Console.Clear();
            DisplayOptions();
            ConsoleKeyInfo info = Console.ReadKey(true);
            key = info.Key;

            if (key == ConsoleKey.UpArrow)
            {
                SelectedIndex--;
                if (SelectedIndex == -1)
                    SelectedIndex = Options.Length - 1;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                SelectedIndex++;
                if (SelectedIndex == Options.Length)
                    SelectedIndex = 0;
            }


        } while (key != ConsoleKey.Enter);
        return SelectedIndex;

    }

    public void RunMenu(int selectedIndex)
    {
        int id;
        switch (selectedIndex)
        {
            case 0:
                for (int i = 0; i < Pediatria.Length; i++)
                {
                    Console.WriteLine(Pediatria[i]);
                }
                Console.WriteLine("Enter the id of doctor: ");
                id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Pediatria.Length; i++)
                {
                    if (id == Pediatria[i].Id)
                    {
                        for (int j = 0; j < Pediatria[i].Worktime.Count; j++)
                        {
                            Console.WriteLine($@"{j+1}) {Pediatria[i].Worktime[j]}");
                        }
                        int choose;
                        Console.WriteLine("Enter the num of work: ");
                        choose=Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine(Pediatria[i].Worktime[choose-1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Pediatria[i].Worktime[choose - 1]}. Please don't be late");
                                Pediatria[i].Worktime.RemoveAt(choose - 1);
                                break;
                            case 2:
                                Console.WriteLine(Pediatria[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Pediatria[i].Worktime[choose - 1]}. Please don't be late");
                                Pediatria[i].Worktime.RemoveAt(choose - 1);
                                break;
                            case 3:
                                Console.WriteLine(Pediatria[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Pediatria[i].Worktime[choose - 1]}. Please don't be late");
                                Pediatria[i].Worktime.RemoveAt(choose - 1);
                                break;
                            default:
                                break;
                        }
                        
                        break;
                        
                    }
                }
                break;
            case 1:
                for (int i = 0; i < Travmatologiya.Length; i++)
                {
                    Console.WriteLine(Travmatologiya[i]);
                }
                Console.WriteLine("Enter the id of doctor: ");
                id = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Travmatologiya.Length; i++)
                {
                    if (id== Pediatria[i].Id)
                    {
                        for (int j = 0; j < Travmatologiya[i].Worktime.Count; j++)
                        {
                            Console.WriteLine($@"{j + 1}) {Travmatologiya[i].Worktime[j]}");
                        }
                        int choose;
                        Console.WriteLine("Enter the num of work: ");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine(Travmatologiya[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Travmatologiya[i].Worktime[choose - 1]}. Please don't be late");
                                Travmatologiya[i].Worktime.RemoveAt(choose - 1);
                                break;
                            case 2:
                                Console.WriteLine(Travmatologiya[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Travmatologiya[i].Worktime[choose - 1]}. Please don't be late");
                                Travmatologiya[i].Worktime.RemoveAt(choose - 1);
                                break;
                            case 3:
                                Console.WriteLine(Travmatologiya[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Travmatologiya[i].Worktime[choose - 1]}. Please don't be late");
                                Travmatologiya[i].Worktime.RemoveAt(choose - 1);
                                break;
                            default:
                                break;
                        }

                        break;

                    }
                }
                break;
            case 2:
                for (int i = 0; i < Stamotologiya.Length; i++)
                {
                    Console.WriteLine(Stamotologiya[i]);
                }
                Console.WriteLine("Enter the id of doctor: ");
                id = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Stamotologiya.Length; i++)
                {
                    if ( id== Pediatria[i].Id)
                    {
                        for (int j = 0; j < Stamotologiya[i].Worktime.Count; j++)
                        {
                            Console.WriteLine($@"{j + 1}) {Stamotologiya[i].Worktime[j]}");
                        }
                        int choose;
                        Console.WriteLine("Enter the num of work: ");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine(Stamotologiya[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Stamotologiya[i].Worktime[choose - 1]}. Please don't be late");
                                Stamotologiya[i].Worktime.RemoveAt(choose - 1);
                                break;
                            case 2:
                                Console.WriteLine(Stamotologiya[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Stamotologiya[i].Worktime[choose - 1]}. Please don't be late");
                                Stamotologiya[i].Worktime.RemoveAt(choose - 1);
                                break;
                            case 3:
                                Console.WriteLine(Stamotologiya[i].Worktime[choose - 1]);
                                Console.WriteLine($"Thank you {User.Name}, You're written to {Stamotologiya[i].Worktime[choose - 1]}. Please don't be late");
                                Stamotologiya[i].Worktime.RemoveAt(choose - 1);
                                break;
                            default:
                                break;
                        }

                        break;

                    }
                }
                break;
            default:
                break;
        }
    }

}
class Program
{

    static void Main()
    {
        
        string[] options = { "Pediatriya", "Travmatologiya", "Stamotologiya" };
        Menu menu = new Menu(options);



        while(true)
        {
            Console.WriteLine("Please enter your name: ");
            string name= Console.ReadLine();

            Console.WriteLine("Please enter your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter your email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your phone: ");
            string phone = Console.ReadLine();
            try
            {
                menu.User = new User(name, surname, email, phone);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error ocurred {ex.Message} ");
                Thread.Sleep(3000);
                Console.WriteLine("Please enter your email: ");
                email = Console.ReadLine();
                menu.User = new User(name, surname, email, phone);
               
            }
            

            Console.Clear();

            Console.WriteLine("Welcome to the Hospital");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Which one do you want?");
            Thread.Sleep(1000);

            menu.RunMenu(menu.Run());
            Thread.Sleep(5000);
            Console.Clear();

        }

    }
}


