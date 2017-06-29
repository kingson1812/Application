using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class DictionaryStructure
    {
        private string m_key;
        private string m_value;

        public DictionaryStructure(string key,string value)
        {
            m_key = key;
            m_value = value;
        }
        public string Key
        {
            get
            {
                return m_key;
            }

            set
            {
                if (m_key != value)
                    m_key = value;
            }
        }

        public string Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (m_value != value)
                    m_value = value;
            }
        }
    }
}
