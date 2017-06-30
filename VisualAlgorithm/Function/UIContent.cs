using Global;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Function
{
    public class UIContent
    {
        private static UIContent s_instance;
        private List<DictionaryStructure> m_DataSetting = new List<DictionaryStructure>();
        private List<DictionaryStructure> m_DataTable = new List<DictionaryStructure>();

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
            for (int i = 0; i < m_DataTable.Count; i++)
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
            lb.BackColor = Color.Gold;
            lb.ForeColor = Color.FromArgb(209, 23, 23);
            lb.Text = cboString.ToUpperInvariant();
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Font = new Font(lb.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Pixel);
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
                b.Font = new Font(b.Font, FontStyle.Bold);
                b.Width = pnl.Width / 2;
                b.Height = 48;
                b.FlatStyle = FlatStyle.Flat;
                b.Location = new Point(pnl.Width / 2 - b.Width / 2, i * b.Height + (i + 2) * itemSpacingVertical);
                b.Click += Button_Click;
                pnl.Controls.Add(b);
            }
            pnl.AutoScrollMinSize = new Size(1, 1);
            pnl.ResumeLayout(true);
        }

        public void UpdateOptionalPanel(Panel panel)
        {
            string alTitle = GetDataByKey(Key.g_name[0]).ToLower();
            if (alTitle == "sort")
            {
                //Create Sort button
                Button b = new Button();
                b.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
                b.BackColor = Color.Gold;
                b.FlatAppearance.BorderSize = 0;
                b.FlatStyle = FlatStyle.Flat;
                b.Location = new Point(5, panel.Height / 2 - b.Height / 2);
                b.Size = new Size(75, 22);
                b.TabStop = false;
                b.Text = "Sort";
                b.UseVisualStyleBackColor = false;
                b.Click += B_Click;

                //Create ASC radiobutton
                RadioButton rb1 = new RadioButton();
                rb1.Text = "ASC";
                rb1.Width = 64;
                rb1.Checked = true;
                rb1.TextAlign = ContentAlignment.MiddleLeft;
                rb1.Location = new Point(15 + b.Location.X + b.Width, panel.Height / 2 - rb1.Height / 2);

                RadioButton rb2 = new RadioButton();
                rb2.Text = "DESC";
                rb2.Checked = false;
                rb2.TextAlign = ContentAlignment.MiddleLeft;
                rb2.Width = 64;
                rb2.Location = new Point(5 + rb1.Location.X + rb1.Width, rb1.Location.Y);

                //Add to panel
                panel.SuspendLayout();
                panel.Controls.Add(b);
                panel.Controls.Add(rb1);
                panel.Controls.Add(rb2);
                panel.ResumeLayout(false);
            }
            else if (alTitle == "seek")
            {

            }
        }

        private void B_Click(object sender, EventArgs e)
        {

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

        public void OnRandomClick(TextBox text, Panel panel)
        {
            panel.Controls.Clear();
            if (text.Text.Trim() != "")
            {
                try
                {
                    int numbers = int.Parse(text.Text);
                    Random r = new Random();
                    panel.SuspendLayout();

                    //Calculate x and y of item
                    int nextX, nextY, newX = 0, newY = 0;
                    for (int i = 0; i < numbers; i++)
                    {
                        Label lb = new Label();
                        lb.Width = numbers > 100 ? 18 : 40;
                        lb.Height = numbers > 100 ? 12 : 30;
                        nextX = 10 + (i - newX) * (lb.Width + 10);
                        nextY = 10 + newY * (lb.Height + 10);
                        if (nextX + lb.Width > panel.Width)
                        {
                            newX = i + 1;
                            newY++;
                        }

                        //Set property
                        lb.AutoSize = false;
                        lb.TextAlign = ContentAlignment.MiddleCenter;
                        lb.Location = new Point(nextX, nextY);
                        lb.Text = r.Next(-255, 255) + "";
                        lb.BackColor = Color.Teal;
                        lb.ForeColor = Color.White;
                        panel.Controls.Add(lb);
                    }
                    panel.AutoScrollMinSize = new Size(1, 1);
                    panel.ResumeLayout(true);
                }
                catch (Exception ex)
                {
                    Log.ERROR(ex.ToString());
                }
            }
        }
    }
}
