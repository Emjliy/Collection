using System;

namespace Collection_Prog_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfPython = new DateTime(2020,7,14);
            ProgLangs Python = new ProgLangs("Python", dateOfPython);

            DateTime dateOfJava = new DateTime(2002,8,16);
            ProgLangs Java = new ProgLangs("Java", dateOfJava);

            DateTime dateOfC = new DateTime(2001,2,11);
            ProgLangs C = new ProgLangs("C", dateOfC);

            Collections<ProgLangs> collections = new Collections<ProgLangs>();
            collections.AddProgLangs(Python);

            collections.AddProgLangs(Java);

            collections.AddProgLangs(C);

            //collections.LangNameSort();
            collections.LangDateSort();

            foreach (ProgLangs item in collections.langs)
            {
                Console.WriteLine($"{item.LangName} {item.TimeOfLangName}");
            }
        }
    }
    }
