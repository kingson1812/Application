﻿using System;
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
        }
    }
}