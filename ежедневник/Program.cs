using System;


namespace ежедневник
{
    internal class Program
    {
        static void Main()
        {
            List<Note> notes = new List<Note>();

            Note zam1 = new Note();
            zam1.name = "   1. помыть кота";
            zam1.into = "  моем";
            zam1.created = new DateTime(2022, 10, 19);
            notes.Add(zam1);
            zam1.knopka = 1;

            Note zam2 = new Note();
            zam2.name = "  1. жоска убираться";
            zam2.into = "убираюсь";
            zam2.created = new DateTime(2022, 10, 18);
            notes.Add(zam2);
            zam2.knopka = 2;

            Note zam3 = new Note();
            zam3.name = "  2. ладно";
            zam3.into = "прохладно";
            zam3.created = new DateTime(2022, 10, 18);
            notes.Add(zam3);
            zam3.knopka = 3;

            Note zam4 = new Note();
            zam4.name = "  3. сыр косичка";
            zam4.into = "косичка";
            zam4.created = new DateTime(2022, 10, 18);
            notes.Add(zam4);
            zam4.knopka = 4;

            Note zam5 = new Note();
            zam5.name = "  1. жоска сижу ";
            zam5.into = "сижу??";
            zam5.created = new DateTime(2022, 10, 20);
            notes.Add(zam5);
            zam5.knopka = 5;

            DateTime date = DateTime.Now;
            
            int posi = 1;

            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    posi--;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {

                    posi++;

                }
                Console.Clear();
                Console.WriteLine(date.ToShortDateString());


                for (int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].created.Date == date.Date)
                    {
                        Console.WriteLine(notes[i].name);

                    }
                }
                Console.SetCursorPosition(0, posi);
                Console.WriteLine("=>");

            }
        

            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();

                for (int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].created.Date == date.Date)
                    {

                        Console.WriteLine(notes[i].name);                 // выводит все описания заметок, где их больше одной.. T_T
                        Console.WriteLine(notes[i].into);
                        Console.WriteLine(notes[i].created);           
                    }

                }


            }


        }






    }

}


