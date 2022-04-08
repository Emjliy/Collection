using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Prog_Languages
{
    class Collections<T> where T : ProgLangs
    {
        public T[] langs;
        public Collections()
        {
            langs = new T[0];
        }
        public void AddProgLangs(T lang)
        {
            Array.Resize(ref langs, langs.Length + 1);
            langs[langs.Length - 1] = lang;
        }
        public void LangNameSort()
        {
            for (int i = 0; i < langs.Length; i++)
            {
                for (int j = 0; j < langs.Length; j++)
                {
                    Array.Sort(langs, (a, b) => String.Compare(a.LangName, b.LangName));
                }

            }
        }
        public void LangDateSort()
        {
            DateTime dates = new DateTime();
            static List<DateTime> SortAscending(List<DateTime> list)
            {
                list.Sort((a, b) => a.CompareTo(b));
                return list;
            }

        }
    }
}
