﻿using HaCreator.CustomControls;

namespace HaCreator.GUI
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.loadButton = new System.Windows.Forms.Button();
            this.WZSelect = new System.Windows.Forms.RadioButton();
            this.XMLSelect = new System.Windows.Forms.RadioButton();
            this.XMLBox = new System.Windows.Forms.TextBox();
            this.HAMBox = new System.Windows.Forms.TextBox();
            this.HAMSelect = new System.Windows.Forms.RadioButton();
            this.tabControl_maps = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mapBrowser = new HaCreator.CustomControls.MapBrowser();
            this.searchBox = new HaCreator.CustomControls.WatermarkTextBox();
            this.tabControl_maps.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.loadButton.Enabled = false;
            this.loadButton.Location = new System.Drawing.Point(12, 901);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(1148, 45);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // WZSelect
            // 
            this.WZSelect.AutoSize = true;
            this.WZSelect.Checked = true;
            this.WZSelect.Location = new System.Drawing.Point(16, 94);
            this.WZSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WZSelect.Name = "WZSelect";
            this.WZSelect.Size = new System.Drawing.Size(61, 27);
            this.WZSelect.TabIndex = 6;
            this.WZSelect.TabStop = true;
            this.WZSelect.Text = "WZ";
            this.WZSelect.UseVisualStyleBackColor = true;
            this.WZSelect.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // XMLSelect
            // 
            this.XMLSelect.AutoSize = true;
            this.XMLSelect.Location = new System.Drawing.Point(16, 58);
            this.XMLSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XMLSelect.Name = "XMLSelect";
            this.XMLSelect.Size = new System.Drawing.Size(68, 27);
            this.XMLSelect.TabIndex = 3;
            this.XMLSelect.Text = "XML";
            this.XMLSelect.UseVisualStyleBackColor = true;
            this.XMLSelect.CheckedChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // XMLBox
            // 
            this.XMLBox.Enabled = false;
            this.XMLBox.Location = new System.Drawing.Point(96, 57);
            this.XMLBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XMLBox.Name = "XMLBox";
            this.XMLBox.Size = new System.Drawing.Size(1036, 29);
            this.XMLBox.TabIndex = 4;
            this.XMLBox.Click += new System.EventHandler(this.BrowseXML_Click);
            this.XMLBox.TextChanged += new System.EventHandler(this.XMLBox_TextChanged);
            // 
            // HAMBox
            // 
            this.HAMBox.Enabled = false;
            this.HAMBox.Location = new System.Drawing.Point(96, 18);
            this.HAMBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HAMBox.Name = "HAMBox";
            this.HAMBox.Size = new System.Drawing.Size(1036, 29);
            this.HAMBox.TabIndex = 1;
            this.HAMBox.Click += new System.EventHandler(this.BrowseHAM_Click);
            this.HAMBox.TextChanged += new System.EventHandler(this.HAMBox_TextChanged);
            // 
            // HAMSelect
            // 
            this.HAMSelect.AutoSize = true;
            this.HAMSelect.Location = new System.Drawing.Point(16, 20);
            this.HAMSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HAMSelect.Name = "HAMSelect";
            this.HAMSelect.Size = new System.Drawing.Size(73, 27);
            this.HAMSelect.TabIndex = 0;
            this.HAMSelect.Text = "HAM";
            this.HAMSelect.UseVisualStyleBackColor = true;
            // 
            // tabControl_maps
            // 
            this.tabControl_maps.Controls.Add(this.tabPage1);
            this.tabControl_maps.Controls.Add(this.tabPage2);
            this.tabControl_maps.Location = new System.Drawing.Point(12, 129);
            this.tabControl_maps.Name = "tabControl_maps";
            this.tabControl_maps.SelectedIndex = 0;
            this.tabControl_maps.Size = new System.Drawing.Size(1153, 765);
            this.tabControl_maps.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mapBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1145, 729);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Maps";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1145, 767);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mapBrowser
            // 
            this.mapBrowser.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.mapBrowser.Location = new System.Drawing.Point(9, 8);
            this.mapBrowser.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.mapBrowser.Name = "mapBrowser";
            this.mapBrowser.Size = new System.Drawing.Size(1119, 698);
            this.mapBrowser.TabIndex = 8;
            this.mapBrowser.SelectionChanged += new HaCreator.CustomControls.MapBrowser.MapSelectChangedDelegate(this.MapBrowser_SelectionChanged);
            // 
            // searchBox
            // 
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(96, 93);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1036, 29);
            this.searchBox.TabIndex = 7;
            this.searchBox.Text = "Type here to search";
            this.searchBox.WatermarkActive = true;
            this.searchBox.WatermarkText = "Type here";
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1174, 955);
            this.Controls.Add(this.tabControl_maps);
            this.Controls.Add(this.HAMBox);
            this.Controls.Add(this.HAMSelect);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.XMLBox);
            this.Controls.Add(this.XMLSelect);
            this.Controls.Add(this.WZSelect);
            this.Controls.Add(this.loadButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load";
            this.Load += new System.EventHandler(this.Load_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Load_KeyDown);
            this.tabControl_maps.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.RadioButton WZSelect;
        private System.Windows.Forms.RadioButton XMLSelect;
        private System.Windows.Forms.TextBox XMLBox;
        private WatermarkTextBox searchBox;
        private CustomControls.MapBrowser mapBrowser;
        private System.Windows.Forms.TextBox HAMBox;
        private System.Windows.Forms.RadioButton HAMSelect;
        private System.Windows.Forms.TabControl tabControl_maps;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}