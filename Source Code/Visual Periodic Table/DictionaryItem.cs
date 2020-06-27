using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    [Serializable]
    public class DictionaryItem
    {
        private List<DictionaryData> items;
        public List<DictionaryData> Items
        {
            get { return items; }
            set { items = value; }
        }
        

    }
}
