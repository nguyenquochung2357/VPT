using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dictionary
{
   public class DictionaryManage
    {
        #region properties
        private string filePath = "data.xml";
        private DictionaryItem items;
        
        public DictionaryItem Items { get {return items; } set { items = value; } }
        // Load du lieu vao combobox
        #endregion
        #region method
            public DictionaryManage()
        {

            items = (DictionaryItem)DeserializeFromXML(filePath);
        }
        public void LoadDataToCombobox(System.Windows.Forms.ComboBox combo)
        {
            combo.DataSource = items.Items;
        }
        public void Serialize()
        {
            SerializeToXML(Items, filePath);
        }
        private void SerializeToXML(object data,string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            sr.Serialize(fs, data);
            fs.Close();
        }
        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            object obj = sr.Deserialize(fs);
            fs.Close();
            return obj;
        }
        #endregion

    }
}
