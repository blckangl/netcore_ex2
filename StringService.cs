using System.Collections.Generic;
using System.Linq;
using ex2.Models;

namespace ex2
{
    public class StringService
    {
        private List<StringItem> list = new List<StringItem>();
        private int id = 0;
        public List<StringItem> getAll()
        {
            return list;
        }

        public StringItem? getStringByIndex(int index)
        {
            if (index < 0 || index > list.Count)
            {
                return null;
            }

            return list[index];
        }

        public void AddString(StringItem item)
        {
            id++;
            item.Id = id;
            list.Add(item);
        }

        public StringItem UpdateItem(int id,StringItem item)
        {
            
            //method1
            // var selectedItem = list.Where(x => x.Id == id).Select(x => x).ToList();
            // selectedItem[0].name = item.name;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list[i].name = item.name;
                    return list[i];
                }
            }

            return null;
        }
    }
}