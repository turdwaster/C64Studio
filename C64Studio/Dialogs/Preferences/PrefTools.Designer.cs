﻿namespace RetroDevStudio.Dialogs.Preferences
{
  partial class PrefTools
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnExportSettings = new System.Windows.Forms.Button();
      this.btnImportSettings = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.alistTools = new RetroDevStudio.Controls.ArrangedItemList();
      this.checkPassLabelsToEmulator = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnMacros = new System.Windows.Forms.Button();
      this.editToolCartArguments = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.editToolTrueDriveOffArguments = new System.Windows.Forms.TextBox();
      this.label24 = new System.Windows.Forms.Label();
      this.editToolTrueDriveOnArguments = new System.Windows.Forms.TextBox();
      this.label23 = new System.Windows.Forms.Label();
      this.editToolDebugArguments = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.editToolPRGArguments = new System.Windows.Forms.TextBox();
      this.comboToolType = new System.Windows.Forms.ComboBox();
      this.editToolName = new System.Windows.Forms.TextBox();
      this.editWorkPath = new System.Windows.Forms.TextBox();
      this.btnBrowseToolWorkPath = new System.Windows.Forms.Button();
      this.btnBrowseTool = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.labelToolPath = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnExportSettings
      // 
      this.btnExportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExportSettings.Location = new System.Drawing.Point(819, 376);
      this.btnExportSettings.Name = "btnExportSettings";
      this.btnExportSettings.Size = new System.Drawing.Size(75, 23);
      this.btnExportSettings.TabIndex = 12;
      this.btnExportSettings.Text = "Export here";
      this.btnExportSettings.UseVisualStyleBackColor = true;
      this.btnExportSettings.Click += new System.EventHandler(this.btnExportSettings_Click);
      // 
      // btnImportSettings
      // 
      this.btnImportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnImportSettings.Location = new System.Drawing.Point(738, 376);
      this.btnImportSettings.Name = "btnImportSettings";
      this.btnImportSettings.Size = new System.Drawing.Size(75, 23);
      this.btnImportSettings.TabIndex = 13;
      this.btnImportSettings.Text = "Import here";
      this.btnImportSettings.UseVisualStyleBackColor = true;
      this.btnImportSettings.Click += new System.EventHandler(this.btnImportSettings_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.alistTools);
      this.groupBox1.Controls.Add(this.checkPassLabelsToEmulator);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Controls.Add(this.comboToolType);
      this.groupBox1.Controls.Add(this.editToolName);
      this.groupBox1.Controls.Add(this.editWorkPath);
      this.groupBox1.Controls.Add(this.btnBrowseToolWorkPath);
      this.groupBox1.Controls.Add(this.btnBrowseTool);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.labelToolPath);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnExportSettings);
      this.groupBox1.Controls.Add(this.btnImportSettings);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(900, 405);
      this.groupBox1.TabIndex = 18;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Emulators/Tools";
      // 
      // alistTools
      // 
      this.alistTools.AddButtonEnabled = true;
      this.alistTools.AllowClone = true;
      this.alistTools.DeleteButtonEnabled = false;
      this.alistTools.HasOwnerDrawColumn = true;
      this.alistTools.HighlightColor = System.Drawing.SystemColors.HotTrack;
      this.alistTools.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
      this.alistTools.Location = new System.Drawing.Point(6, 40);
      this.alistTools.MoveDownButtonEnabled = false;
      this.alistTools.MoveUpButtonEnabled = false;
      this.alistTools.MustHaveOneElement = false;
      this.alistTools.Name = "alistTools";
      this.alistTools.SelectedIndex = -1;
      this.alistTools.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      this.alistTools.SelectionTextColor = System.Drawing.SystemColors.HighlightText;
      this.alistTools.Size = new System.Drawing.Size(253, 349);
      this.alistTools.TabIndex = 28;
      this.alistTools.AddingItem += new RetroDevStudio.Controls.ArrangedItemList.AddingItemEventHandler(this.alistTools_AddingItem);
      this.alistTools.CloningItem += new RetroDevStudio.Controls.ArrangedItemList.CloningItemEventHandler(this.alistTools_CloningItem);
      this.alistTools.ItemAdded += new RetroDevStudio.Controls.ArrangedItemList.ItemModifiedEventHandler(this.alistTools_ItemAdded);
      this.alistTools.ItemRemoved += new RetroDevStudio.Controls.ArrangedItemList.ItemModifiedEventHandler(this.alistTools_ItemRemoved);
      this.alistTools.ItemMoved += new RetroDevStudio.Controls.ArrangedItemList.ItemExchangedEventHandler(this.alistTools_ItemMoved);
      this.alistTools.SelectedIndexChanged += new RetroDevStudio.Controls.ArrangedItemList.ItemModifiedEventHandler(this.alistTools_SelectedIndexChanged);
      // 
      // checkPassLabelsToEmulator
      // 
      this.checkPassLabelsToEmulator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.checkPassLabelsToEmulator.Location = new System.Drawing.Point(275, 349);
      this.checkPassLabelsToEmulator.Name = "checkPassLabelsToEmulator";
      this.checkPassLabelsToEmulator.Size = new System.Drawing.Size(155, 24);
      this.checkPassLabelsToEmulator.TabIndex = 27;
      this.checkPassLabelsToEmulator.Text = "Forward labels to emulator";
      this.checkPassLabelsToEmulator.UseVisualStyleBackColor = true;
      this.checkPassLabelsToEmulator.CheckedChanged += new System.EventHandler(this.checkPassLabelsToEmulator_CheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnMacros);
      this.groupBox2.Controls.Add(this.editToolCartArguments);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.editToolTrueDriveOffArguments);
      this.groupBox2.Controls.Add(this.label24);
      this.groupBox2.Controls.Add(this.editToolTrueDriveOnArguments);
      this.groupBox2.Controls.Add(this.label23);
      this.groupBox2.Controls.Add(this.editToolDebugArguments);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.editToolPRGArguments);
      this.groupBox2.Location = new System.Drawing.Point(274, 151);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(539, 192);
      this.groupBox2.TabIndex = 24;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Runtime Arguments";
      // 
      // btnMacros
      // 
      this.btnMacros.Location = new System.Drawing.Point(16, 152);
      this.btnMacros.Name = "btnMacros";
      this.btnMacros.Size = new System.Drawing.Size(75, 23);
      this.btnMacros.TabIndex = 5;
      this.btnMacros.Text = "Macros";
      this.btnMacros.UseVisualStyleBackColor = true;
      this.btnMacros.Click += new System.EventHandler(this.btnMacros_Click);
      // 
      // editToolCartArguments
      // 
      this.editToolCartArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.editToolCartArguments.Location = new System.Drawing.Point(83, 45);
      this.editToolCartArguments.Name = "editToolCartArguments";
      this.editToolCartArguments.Size = new System.Drawing.Size(450, 20);
      this.editToolCartArguments.TabIndex = 1;
      this.editToolCartArguments.TextChanged += new System.EventHandler(this.editToolCartArguments_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 22);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "PRG/T64:";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(6, 48);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(52, 13);
      this.label12.TabIndex = 3;
      this.label12.Text = "Cartridge:";
      // 
      // editToolTrueDriveOffArguments
      // 
      this.editToolTrueDriveOffArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.editToolTrueDriveOffArguments.Location = new System.Drawing.Point(83, 123);
      this.editToolTrueDriveOffArguments.Name = "editToolTrueDriveOffArguments";
      this.editToolTrueDriveOffArguments.Size = new System.Drawing.Size(450, 20);
      this.editToolTrueDriveOffArguments.TabIndex = 4;
      this.editToolTrueDriveOffArguments.TextChanged += new System.EventHandler(this.editToolTrueDriveOffArguments_TextChanged);
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.Location = new System.Drawing.Point(6, 126);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(75, 13);
      this.label24.TabIndex = 3;
      this.label24.Text = "True Drive off:";
      // 
      // editToolTrueDriveOnArguments
      // 
      this.editToolTrueDriveOnArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.editToolTrueDriveOnArguments.Location = new System.Drawing.Point(83, 97);
      this.editToolTrueDriveOnArguments.Name = "editToolTrueDriveOnArguments";
      this.editToolTrueDriveOnArguments.Size = new System.Drawing.Size(450, 20);
      this.editToolTrueDriveOnArguments.TabIndex = 3;
      this.editToolTrueDriveOnArguments.TextChanged += new System.EventHandler(this.editToolTrueDriveOnArguments_TextChanged);
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.Location = new System.Drawing.Point(6, 100);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(75, 13);
      this.label23.TabIndex = 3;
      this.label23.Text = "True Drive on:";
      // 
      // editToolDebugArguments
      // 
      this.editToolDebugArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.editToolDebugArguments.Location = new System.Drawing.Point(83, 71);
      this.editToolDebugArguments.Name = "editToolDebugArguments";
      this.editToolDebugArguments.Size = new System.Drawing.Size(450, 20);
      this.editToolDebugArguments.TabIndex = 2;
      this.editToolDebugArguments.TextChanged += new System.EventHandler(this.editToolDebugArguments_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 74);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(42, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Debug:";
      // 
      // editToolPRGArguments
      // 
      this.editToolPRGArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.editToolPRGArguments.Location = new System.Drawing.Point(83, 19);
      this.editToolPRGArguments.Name = "editToolPRGArguments";
      this.editToolPRGArguments.Size = new System.Drawing.Size(450, 20);
      this.editToolPRGArguments.TabIndex = 0;
      this.editToolPRGArguments.TextChanged += new System.EventHandler(this.editToolPRGArguments_TextChanged);
      // 
      // comboToolType
      // 
      this.comboToolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboToolType.FormattingEnabled = true;
      this.comboToolType.Location = new System.Drawing.Point(357, 69);
      this.comboToolType.Name = "comboToolType";
      this.comboToolType.Size = new System.Drawing.Size(450, 21);
      this.comboToolType.TabIndex = 23;
      this.comboToolType.SelectedIndexChanged += new System.EventHandler(this.comboToolType_SelectedIndexChanged);
      // 
      // editToolName
      // 
      this.editToolName.Location = new System.Drawing.Point(357, 40);
      this.editToolName.Name = "editToolName";
      this.editToolName.Size = new System.Drawing.Size(450, 20);
      this.editToolName.TabIndex = 22;
      this.editToolName.TextChanged += new System.EventHandler(this.editToolName_TextChanged);
      // 
      // editWorkPath
      // 
      this.editWorkPath.Location = new System.Drawing.Point(357, 125);
      this.editWorkPath.Name = "editWorkPath";
      this.editWorkPath.Size = new System.Drawing.Size(266, 20);
      this.editWorkPath.TabIndex = 26;
      this.editWorkPath.TextChanged += new System.EventHandler(this.editWorkPath_TextChanged);
      // 
      // btnBrowseToolWorkPath
      // 
      this.btnBrowseToolWorkPath.Location = new System.Drawing.Point(629, 123);
      this.btnBrowseToolWorkPath.Name = "btnBrowseToolWorkPath";
      this.btnBrowseToolWorkPath.Size = new System.Drawing.Size(24, 23);
      this.btnBrowseToolWorkPath.TabIndex = 20;
      this.btnBrowseToolWorkPath.Text = "...";
      this.btnBrowseToolWorkPath.UseVisualStyleBackColor = true;
      // 
      // btnBrowseTool
      // 
      this.btnBrowseTool.Location = new System.Drawing.Point(629, 95);
      this.btnBrowseTool.Name = "btnBrowseTool";
      this.btnBrowseTool.Size = new System.Drawing.Size(24, 23);
      this.btnBrowseTool.TabIndex = 21;
      this.btnBrowseTool.Text = "...";
      this.btnBrowseTool.UseVisualStyleBackColor = true;
      this.btnBrowseTool.Click += new System.EventHandler(this.btnBrowseTool_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(271, 43);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(38, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Name:";
      // 
      // labelToolPath
      // 
      this.labelToolPath.AutoEllipsis = true;
      this.labelToolPath.Location = new System.Drawing.Point(354, 100);
      this.labelToolPath.Name = "labelToolPath";
      this.labelToolPath.Size = new System.Drawing.Size(269, 23);
      this.labelToolPath.TabIndex = 25;
      this.labelToolPath.Text = "Tool Path";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(271, 72);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(34, 13);
      this.label6.TabIndex = 17;
      this.label6.Text = "Type:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(271, 128);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(75, 13);
      this.label8.TabIndex = 18;
      this.label8.Text = "Working Path:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(271, 100);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 19;
      this.label3.Text = "Executable:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(269, 18);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 13);
      this.label2.TabIndex = 14;
      this.label2.Text = "Tool Settings:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Available Tools:";
      // 
      // PrefTools
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "PrefTools";
      this.Size = new System.Drawing.Size(900, 405);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.Button btnImportSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.ArrangedItemList alistTools;
        private System.Windows.Forms.CheckBox checkPassLabelsToEmulator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMacros;
        private System.Windows.Forms.TextBox editToolCartArguments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox editToolTrueDriveOffArguments;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox editToolTrueDriveOnArguments;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox editToolDebugArguments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editToolPRGArguments;
        private System.Windows.Forms.ComboBox comboToolType;
        private System.Windows.Forms.TextBox editToolName;
        private System.Windows.Forms.TextBox editWorkPath;
        private System.Windows.Forms.Button btnBrowseToolWorkPath;
        private System.Windows.Forms.Button btnBrowseTool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelToolPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
