using Global;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Function
{
    public class UIContent
    {
        private static UIContent s_instance;
        private List<DictionaryStructure> m_DataSetting = new List<DictionaryStructure>();
        private List<DictionaryStructure> m_DataTable   = new List<DictionaryStructure>();

        public void CreateInstance()
        {
            if (s_instance == null)
                s_instance = new UIContent();
        }

        public static UIContent GetInstance()
        {
            return s_instance;
        }

        /// <summary>
        /// Update item for combobox
        /// </summary>
        /// <param name="cbo">combobox need to be updated</param>
        /// <param name="fs">file stream contains content</param>
        public void UpdateItem(ComboBox cbo)
        {
            cbo.Items.Clear();
            for(int i=0;i<m_DataTable.Count;i++)
            {
                if (m_DataTable[i].Key == Key.g_name[0])
                {
                    cbo.Items.Add(m_DataTable[i].Value);
                    cbo.AutoCompleteCustomSource.Add(m_DataTable[i].Value);
                }
            }
            cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        /// <summary>
        /// Update content for panel
        /// </summary>
        /// <param name="pnl">panel need to be upadated</param>
        public void UpdateItem(Panel pnl)
        {
            pnl.Controls.Clear();
            string cboString = GetDataByKey(Key.g_name[0]).ToLower();
            int itemSpacingVertical = 20;
            List<string> itemName = new List<string>();
            for (int i = 0; i < m_DataTable.Count; i++)
            {
                if (m_DataTable[i].Key.Contains(":" + cboString))
                    itemName.Add(m_DataTable[i].Value);
            }

            pnl.SuspendLayout();
            Label lb = new Label();
            lb.BackColor = Color.FromArgb(177, 242, 128);
            lb.ForeColor = Color.FromArgb(209, 23, 23);
            lb.Text = cboString.ToUpperInvariant();
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Font = new Font(lb.Font.FontFamily, 14, FontStyle.Bold,GraphicsUnit.Pixel);
            lb.Width = pnl.Width;
            lb.Height = itemSpacingVertical;
            lb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            pnl.Controls.Add(lb);
            for (int i = 0; i < itemName.Count; i++)
            {
                Button b = new Button();
                b.Name = itemName[i];
                b.Text = b.Name;
                b.FlatStyle = FlatStyle.Popup;
                b.BackColor = Color.FromArgb(209, 23, 23);
                b.ForeColor = Color.White;
                b.Font = new Font(b.Font,FontStyle.Bold);
                b.Width = pnl.Width / 2;
                b.Height = 48;
                b.Location = new Point(pnl.Width / 2 - b.Width/2, i * b.Height + (i+2) * itemSpacingVertical);
                b.Click += Button_Click;
                pnl.Controls.Add(b);
            }
            pnl.ResumeLayout(false);
            pnl.AutoScrollMinSize = new Size(1,1);
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            OnButtonClick(sender, e);
        }

        /// <summary>
        /// Update config database
        /// </summary>
        /// <param name="item">data item</param>
        public void UpdateDataConfig(DictionaryStructure item)
        {
            if (m_DataSetting.Count > 0)
            {
                for (int i = 0; i < m_DataSetting.Count; i++)
                {
                    if (item.Key == m_DataSetting[i].Key)
                    {
                        m_DataSetting[i] = item;
                        return;
                    }
                }
            }
            m_DataSetting.Add(item);
        }

        public void UpdateDataTable(DictionaryStructure item)
        {
            m_DataTable.Add(item);
        }
        /// <summary>
        /// Get value by key
        /// </summary>
        /// <param name="key">Key to find value</param>
        public string GetDataByKey(string key)
        {
            if (m_DataSetting.Count == 0)
                return null;
            string output = "";
            for (int i = 0; i < m_DataSetting.Count; i++)
            {
                if (m_DataSetting[i].Key == key)
                {
                    output = m_DataSetting[i].Value;
                    break;
                }
            }
            return output;
        }

        public void OnButtonClick(object sender, System.EventArgs e)
        {
            Flag.g_onButtonClick = true;
            Button b = (Button)sender;
            Define.g_currentAlgorithm = b.Text;


        }
    }
}
