namespace VisualAlgorithm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboboxAlgorithm = new System.Windows.Forms.ComboBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.labelAlName = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28862F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.71138F));
            this.tableLayoutPanel.Controls.Add(this.comboboxAlgorithm, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelContent, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelAlName, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.685968F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.31403F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1008, 473);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // comboboxAlgorithm
            // 
            this.comboboxAlgorithm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboboxAlgorithm.FormattingEnabled = true;
            this.comboboxAlgorithm.Location = new System.Drawing.Point(5, 10);
            this.comboboxAlgorithm.Name = "comboboxAlgorithm";
            this.comboboxAlgorithm.Size = new System.Drawing.Size(233, 21);
            this.comboboxAlgorithm.TabIndex = 1;
            this.comboboxAlgorithm.SelectedValueChanged += new System.EventHandler(this.comboboxAlgorithm_SelectedValueChanged);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Location = new System.Drawing.Point(3, 44);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(238, 426);
            this.panelContent.TabIndex = 2;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Tag = "No tag";
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // labelAlName
            // 
            this.labelAlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAlName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAlName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlName.Location = new System.Drawing.Point(247, 0);
            this.labelAlName.Name = "labelAlName";
            this.labelAlName.Size = new System.Drawing.Size(758, 41);
            this.labelAlName.TabIndex = 3;
            this.labelAlName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1024, 512);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorithm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ComboBox comboboxAlgorithm;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelAlName;
    }
}

