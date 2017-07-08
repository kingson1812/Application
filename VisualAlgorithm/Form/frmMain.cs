using System;
using System.Windows.Forms;
using Function.IO;
using Function;
using Global;

namespace VisualAlgorithm
{
    public partial class frmMain : Form
    {
        File        fs = new File(Define.g_prePath + Define.g_configPath);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new UIContent().CreateInstance();
            fs.Read();
            UIContent.GetInstance().UpdateItem(comboboxAlgorithm);
            CSNI.g_dataArray = new System.Collections.Generic.List<int>();
        }

        private void comboboxAlgorithm_SelectedValueChanged(object sender, EventArgs e)
        {
            UIContent.GetInstance().UpdateDataConfig(new DictionaryStructure(Key.g_name[0], comboboxAlgorithm.Text.ToString()));
            Flag.g_needUpdatePanel = true;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if(Flag.g_needUpdatePanel)
            {
                UIContent.GetInstance().UpdateItem(panelContent);
                Flag.g_needUpdatePanel = false;
            }

            if(Flag.g_onButtonClick)
            {
                labelAlName.Text = Define.g_currentAlgorithm; 
            }

            if(Flag.g_needUpdateOptionalPanel)
            {
                UIContent.GetInstance().UpdateOptionalPanel(panelOptionalControl);
                Flag.g_needUpdateOptionalPanel = false;
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            UIContent.GetInstance().OnRandomClick(textboxRandomArrayNumber,panelGraphic2,textboxLog);
        }

        private void textboxRandomArrayNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonRandom_Click(buttonRandom, new EventArgs());
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
