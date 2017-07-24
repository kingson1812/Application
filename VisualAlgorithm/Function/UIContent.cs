using Global;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
            panel.Controls.Clear();
            string alTitle = Define.g_currentAlgorithm.ToLower();
            if (alTitle.Contains("sort"))
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
                b.Click += ButtonSort_Click;

                //Create ASC radiobutton
                RadioButton rb1 = new RadioButton();
                rb1.Text = "ASC";
                rb1.Width = 64;
                rb1.Checked = true;
                rb1.TextAlign = ContentAlignment.MiddleLeft;
                rb1.Location = new Point(15 + b.Location.X + b.Width, panel.Height / 2 - rb1.Height / 2);
                rb1.CheckedChanged += Rb1_CheckedChanged;

                RadioButton rb2 = new RadioButton();
                rb2.Text = "DESC";
                rb2.Checked = false;
                rb2.TextAlign = ContentAlignment.MiddleLeft;
                rb2.Width = 64;
                rb2.Location = new Point(5 + rb1.Location.X + rb1.Width, rb1.Location.Y);
                rb2.CheckedChanged += Rb2_CheckedChanged;

                //Add to panel
                panel.SuspendLayout();
                panel.Controls.Add(b);
                panel.Controls.Add(rb1);
                panel.Controls.Add(rb2);
                panel.ResumeLayout(false);
            }
            else if (alTitle.Contains("seek"))
            {

            }
        }

        private void Rb2_CheckedChanged(object sender, EventArgs e)
        {
            Define.g_isASC = !(((RadioButton)sender).Checked);
        }

        private void Rb1_CheckedChanged(object sender, EventArgs e)
        {
            Define.g_isASC = ((RadioButton)sender).Checked;
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            CSNI.CreateAlgorithm();
            CSNI.SetData(CSNI.ConvertToString(CSNI.g_dataArray));
            string data = Marshal.PtrToStringAnsi(CSNI.GetData());
            CSNI.Sort(GetAlgIndexByName(Define.g_currentAlgorithm), Define.g_isASC);
            Flag.g_processing = true;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Flag.g_onButtonClick = true;
            Flag.g_needUpdateOptionalPanel = true;
            Button b = (Button)sender;
            Define.g_currentAlgorithm = b.Text;
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

        /// <summary>
        /// Get algorithm by name.
        /// </summary>
        /// <param name="algName">Algorithm name</param>
        /// <returns>index of Alg</returns>
        public int GetAlgIndexByName(string algName)
        {
            int alg = -1;
            if (algName.ToLower().Contains("insertion"))
            {
                alg = 0;
            }
            else if (algName.ToLower().Contains("selection"))
            {
                alg = 1;
            }
            else if (algName.ToLower().Contains("bubble"))
            {
                alg = 2;
            }
            else if (algName.ToLower().Contains("quick"))
            {
                alg = 3;
            }
            return alg;
        }

        /// <summary>
        /// Randomize some numbers for input data
        /// </summary>
        /// <param name="text">Number of numbers in Label Text</param>
        /// <param name="panel">Panel contains numbers in type Label</param>
        /// <param name="log">Log out text for detail</param>
        public void OnRandomClick(TextBox text, Panel panel, TextBox log)
        {
            if (text.Text.Trim() != "")
            {
                int numbers = int.Parse(text.Text);
                if (numbers > 300 || numbers < 1)
                {
                    log.AppendText(numbers + " is too many. You should randomize 1 ~ 300 numbers to reduce lagging\r\n");
                    return;
                }
                try
                {
                    panel.Controls.Clear();
                    if (CSNI.g_dataArray.Count > 0)
                        CSNI.g_dataArray.Clear();
                    Random r = new Random();
                    panel.SuspendLayout();

                    //Calculate x and y of item
                    int nextX, nextY, newX = 0, newY = 0;
                    for (int i = 0; i < numbers; i++)
                    {
                        Label lb = new Label();
                        lb.Width = numbers > 100 ? 35 : 40;
                        lb.Height = numbers > 100 ? 20 : 30;
                        nextX = 10 + (i - newX) * (lb.Width + 10);
                        nextY = 10 + newY * (lb.Height + 10);
                        if (nextX + lb.Width > panel.Width)
                        {
                            newX = i + 1;
                            newY++;
                        }

                        //Set property
                        lb.AutoSize = false;
                        lb.Name = "label" + i;
                        lb.TextAlign = ContentAlignment.MiddleCenter;
                        lb.Location = new Point(nextX, nextY);
                        int nextNum = r.Next(-255, 255);
                        CSNI.g_dataArray.Add(nextNum);
                        lb.Text = nextNum + "";
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

        public async void UpdatePanelDetail(Panel panel, TextBox log)
        {
            try
            {
                Panel pnlGraphic2 = (Panel)panel.Controls["panelGraphic2"];
                Panel pnlGraphic1 = (Panel)panel.Controls["panelGraphic1"];

                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lblCompare = new Label();

                lbl1.Width = 40;
                lbl1.Height = 30;
                lbl1.AutoSize = false;
                lbl1.Name = "label1";
                lbl1.TextAlign = ContentAlignment.MiddleCenter;
                lbl1.Location = new Point(pnlGraphic1.Location.X + 10, pnlGraphic1.Height / 2 - lbl1.Height / 2);
                lbl1.BackColor = Color.Brown;
                lbl1.ForeColor = Color.White;

                lblCompare.Width = 40;
                lblCompare.Height = 30;
                lblCompare.BackColor = pnlGraphic1.BackColor;
                lblCompare.ForeColor = Color.Black;
                lblCompare.AutoSize = false;
                lblCompare.Name = "labelCompare";
                lblCompare.TextAlign = ContentAlignment.MiddleCenter;
                lblCompare.Location = new Point(lbl1.Location.X + lbl1.Width + 10, pnlGraphic1.Height / 2 - lbl1.Height / 2);

                lbl2.Width = 40;
                lbl2.Height = 30;
                lbl2.AutoSize = false;
                lbl2.Name = "label2";
                lbl2.TextAlign = ContentAlignment.MiddleCenter;
                lbl2.Location = new Point(lblCompare.Location.X + lblCompare.Width + 10, pnlGraphic1.Height / 2 - lbl1.Height / 2);
                lbl2.BackColor = Color.Gold;
                lbl2.ForeColor = Color.Black;

                //Add 3 labels to panelGraphic1
                pnlGraphic1.SuspendLayout();
                pnlGraphic1.Controls.Clear();
                pnlGraphic1.Controls.Add(lbl1);
                pnlGraphic1.Controls.Add(lbl2);
                pnlGraphic1.Controls.Add(lblCompare);
                pnlGraphic1.ResumeLayout();

                string process = Marshal.PtrToStringAnsi(CSNI.GetProcess());
                string[] processArray = process.Split(new char[] { ';' });
                for (int i = 0; i < processArray.Length; i++)
                {
                    Label lbl = null;
                    int startIndex = 0;
                    lbl2.Text = ((Label)pnlGraphic2.Controls["label" + i]).Text;
                    for (int j = 0; j < processArray[i].Length; j++)
                    {
                        if (processArray[i][j] == '[' || processArray[i][j] == '<')
                        {
                            startIndex = j;
                            continue;
                        }

                        if (processArray[i][j] == ']')
                        {
                            //Console.WriteLine(int.Parse(processArray[i].Substring(startIndex + 1, j - startIndex-1)));
                            pnlGraphic2.SuspendLayout();
                            lbl = ((Label)pnlGraphic2.Controls[("label" + int.Parse(processArray[i].Substring(startIndex + 1, j - startIndex - 1)))]);
                            lbl.BackColor = Color.Brown;
                            lbl1.Text = lbl.Text;
                            pnlGraphic2.ResumeLayout(true);

                            //Delay for viewing UI clearly
                            await Task.Delay(10000);
                        }

                        if (processArray[i][j] == '>')
                        {
                            string action = processArray[i].Substring(startIndex + 1, j - startIndex - 1);
                            if (action == "swap")
                            {
                                log.AppendText("Swap " + lbl1.Text + " with " + lbl2.Text+"\r\n");
                            }
                            else if (action == "noswap")
                            {
                                log.AppendText("Don't need to swap, go to next number\r\n");
                            }
                            
                        }
                        if (lbl != null)
                            lbl.BackColor = Color.Teal;
                    }
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
