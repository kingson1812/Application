using System;
using System.Windows.Forms;
using Function.IO;
using Function;
using Global;
using System.Runtime.InteropServices;

namespace VisualAlgorithm
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new UIContent().CreateInstance();
            new File(Define.g_prePath + Define.g_configPath).Read();
            UIContent.GetInstance().UpdateItem(comboboxAlgorithm);
            CSNI.g_dataArray = new System.Collections.Generic.List<int>();
        }

        private void comboboxAlgorithm_SelectedValueChanged(object sender, EventArgs e)
        {
            UIContent.GetInstance().UpdateDataConfig(new DictionaryStructure(Key.g_name[0], comboboxAlgorithm.Text.ToString()));
            Flag.g_needUpdateContentPanel = true;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if(Flag.g_needUpdateContentPanel)
            {
                UIContent.GetInstance().UpdateItem(panelContent);
                Flag.g_needUpdateContentPanel = false;
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

            if(Flag.g_processing)
            {
                UIContent.GetInstance().UpdatePanelDetail(panelDetail,textboxLog);
                Flag.g_processing = false;
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
