using System.Collections.Generic;

namespace ex2
{
    public class StringService
    {
        private List<string> list = new List<string>(new []{"string1","string2","string3"});

        public List<string> getAll()
        {
            return list;
        }

        public string? getStringByIndex(int index)
        {
            if (index < 0 || index > list.Count)
            {
                return null;
            }

            return list[index];
        }

        public void AddString(string name)
        {
            list.Add(name);
        }
    }
}