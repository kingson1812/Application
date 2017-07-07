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
            this.labelAlName = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.panelOptionalControl = new System.Windows.Forms.Panel();
            this.panelGraphic2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxLog = new System.Windows.Forms.TextBox();
            this.textboxRandomArrayNumber = new System.Windows.Forms.TextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.panelGraphic1 = new System.Windows.Forms.Panel();
            this.textboxStep = new System.Windows.Forms.TextBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panelGraphic1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28862F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.71138F));
            this.tableLayoutPanel.Controls.Add(this.comboboxAlgorithm, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelContent, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelAlName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panelDetail, 1, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.685968F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.31403F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1008, 473);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // comboboxAlgorithm
            // 
            this.comboboxAlgorithm.FormattingEnabled = true;
            this.comboboxAlgorithm.Location = new System.Drawing.Point(3, 3);
            this.comboboxAlgorithm.Name = "comboboxAlgorithm";
            this.comboboxAlgorithm.Size = new System.Drawing.Size(238, 21);
            this.comboboxAlgorithm.TabIndex = 1;
            this.comboboxAlgorithm.TextChanged += new System.EventHandler(this.comboboxAlgorithm_SelectedValueChanged);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Location = new System.Drawing.Point(3, 44);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(238, 426);
            this.panelContent.TabIndex = 2;
            // 
            // labelAlName
            // 
            this.labelAlName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAlName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAlName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlName.Location = new System.Drawing.Point(247, 0);
            this.labelAlName.Name = "labelAlName";
            this.labelAlName.Size = new System.Drawing.Size(758, 41);
            this.labelAlName.TabIndex = 3;
            this.labelAlName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetail.Controls.Add(this.panelOptionalControl);
            this.panelDetail.Controls.Add(this.panelGraphic2);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.textboxLog);
            this.panelDetail.Controls.Add(this.textboxRandomArrayNumber);
            this.panelDetail.Controls.Add(this.buttonRandom);
            this.panelDetail.Controls.Add(this.panelGraphic1);
            this.panelDetail.Location = new System.Drawing.Point(247, 44);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(758, 426);
            this.panelDetail.TabIndex = 4;
            // 
            // panelOptionalControl
            // 
            this.panelOptionalControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptionalControl.Location = new System.Drawing.Point(232, 318);
            this.panelOptionalControl.Name = "panelOptionalControl";
            this.panelOptionalControl.Size = new System.Drawing.Size(520, 51);
            this.panelOptionalControl.TabIndex = 9;
            // 
            // panelGraphic2
            // 
            this.panelGraphic2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraphic2.AutoScroll = true;
            this.panelGraphic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphic2.Location = new System.Drawing.Point(4, 58);
            this.panelGraphic2.Name = "panelGraphic2";
            this.panelGraphic2.Size = new System.Drawing.Size(748, 254);
            this.panelGraphic2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(148, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "numbers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textboxLog
            // 
            this.textboxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxLog.BackColor = System.Drawing.Color.White;
            this.textboxLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
            this.textboxLog.Location = new System.Drawing.Point(4, 375);
            this.textboxLog.Multiline = true;
            this.textboxLog.Name = "textboxLog";
            this.textboxLog.ReadOnly = true;
            this.textboxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxLog.Size = new System.Drawing.Size(748, 44);
            this.textboxLog.TabIndex = 6;
            // 
            // textboxRandomArrayNumber
            // 
            this.textboxRandomArrayNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxRandomArrayNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxRandomArrayNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxRandomArrayNumber.Location = new System.Drawing.Point(86, 334);
            this.textboxRandomArrayNumber.Name = "textboxRandomArrayNumber";
            this.textboxRandomArrayNumber.Size = new System.Drawing.Size(56, 23);
            this.textboxRandomArrayNumber.TabIndex = 5;
            this.textboxRandomArrayNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxRandomArrayNumber_KeyPress);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandom.BackColor = System.Drawing.Color.Gold;
            this.buttonRandom.FlatAppearance.BorderSize = 0;
            this.buttonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandom.Location = new System.Drawing.Point(5, 334);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 22);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.TabStop = false;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // panelGraphic1
            // 
            this.panelGraphic1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraphic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphic1.Controls.Add(this.textboxStep);
            this.panelGraphic1.Location = new System.Drawing.Point(4, 3);
            this.panelGraphic1.Name = "panelGraphic1";
            this.panelGraphic1.Size = new System.Drawing.Size(748, 51);
            this.panelGraphic1.TabIndex = 0;
            // 
            // textboxStep
            // 
            this.textboxStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxStep.Location = new System.Drawing.Point(333, 3);
            this.textboxStep.Multiline = true;
            this.textboxStep.Name = "textboxStep";
            this.textboxStep.Size = new System.Drawing.Size(409, 43);
            this.textboxStep.TabIndex = 0;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Tag = "No tag";
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
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
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.panelGraphic1.ResumeLayout(false);
            this.panelGraphic1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ComboBox comboboxAlgorithm;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelAlName;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxLog;
        private System.Windows.Forms.TextBox textboxRandomArrayNumber;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Panel panelGraphic1;
        private System.Windows.Forms.Panel panelGraphic2;
        private System.Windows.Forms.TextBox textboxStep;
        private System.Windows.Forms.Panel panelOptionalControl;
    }
}

