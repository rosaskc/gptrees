﻿namespace ForRest
{
    partial class AddTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTree));
            this.comboBoxAvailableTrees = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelTreeType = new System.Windows.Forms.Label();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.labelDataType = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTreeDegree = new System.Windows.Forms.Label();
            this.maskedTextBoxDegree = new System.Windows.Forms.MaskedTextBox();
            this.toolTipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorkerAddTree = new System.ComponentModel.BackgroundWorker();
            this.progressBarAddTree = new System.Windows.Forms.ProgressBar();
            this.labelMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAvailableTrees
            // 
            this.comboBoxAvailableTrees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAvailableTrees.FormattingEnabled = true;
            this.comboBoxAvailableTrees.Location = new System.Drawing.Point(12, 56);
            this.comboBoxAvailableTrees.Name = "comboBoxAvailableTrees";
            this.comboBoxAvailableTrees.Size = new System.Drawing.Size(138, 21);
            this.comboBoxAvailableTrees.TabIndex = 0;
            this.comboBoxAvailableTrees.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAvailableTreesSelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(12, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // labelTreeType
            // 
            this.labelTreeType.AutoSize = true;
            this.labelTreeType.Location = new System.Drawing.Point(26, 36);
            this.labelTreeType.Name = "labelTreeType";
            this.labelTreeType.Size = new System.Drawing.Size(114, 13);
            this.labelTreeType.TabIndex = 4;
            this.labelTreeType.Text = "Select type of the tree:";
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Items.AddRange(new object[] {
            "Text",
            "Numeric"});
            this.comboBoxDataType.Location = new System.Drawing.Point(192, 56);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(102, 21);
            this.comboBoxDataType.TabIndex = 5;
            this.comboBoxDataType.Visible = false;
            this.comboBoxDataType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDataTypeSelectedIndexChanged);
            // 
            // labelDataType
            // 
            this.labelDataType.AutoSize = true;
            this.labelDataType.Location = new System.Drawing.Point(200, 36);
            this.labelDataType.Name = "labelDataType";
            this.labelDataType.Size = new System.Drawing.Size(87, 13);
            this.labelDataType.TabIndex = 6;
            this.labelDataType.Text = "Select data type:";
            this.labelDataType.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxNameTextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(43, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Enter tree name:";
            // 
            // labelTreeDegree
            // 
            this.labelTreeDegree.AutoSize = true;
            this.labelTreeDegree.Location = new System.Drawing.Point(195, 89);
            this.labelTreeDegree.Name = "labelTreeDegree";
            this.labelTreeDegree.Size = new System.Drawing.Size(92, 13);
            this.labelTreeDegree.TabIndex = 10;
            this.labelTreeDegree.Text = "Enter tree degree:";
            this.labelTreeDegree.Visible = false;
            // 
            // maskedTextBoxDegree
            // 
            this.maskedTextBoxDegree.Location = new System.Drawing.Point(192, 110);
            this.maskedTextBoxDegree.Mask = "000";
            this.maskedTextBoxDegree.Name = "maskedTextBoxDegree";
            this.maskedTextBoxDegree.Size = new System.Drawing.Size(102, 20);
            this.maskedTextBoxDegree.TabIndex = 11;
            this.maskedTextBoxDegree.ValidatingType = typeof(int);
            this.maskedTextBoxDegree.Visible = false;
            this.maskedTextBoxDegree.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBoxDegreeMaskInputRejected);
            this.maskedTextBoxDegree.TextChanged += new System.EventHandler(this.MaskedTextBoxDegreeTextChanged);
            // 
            // backgroundWorkerAddTree
            // 
            this.backgroundWorkerAddTree.WorkerReportsProgress = true;
            this.backgroundWorkerAddTree.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerAddTreeDoWork);
            this.backgroundWorkerAddTree.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerAddTreeProgressChanged);
            this.backgroundWorkerAddTree.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerAddTreeRunWorkerCompleted);
            // 
            // progressBarAddTree
            // 
            this.progressBarAddTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarAddTree.Location = new System.Drawing.Point(0, 188);
            this.progressBarAddTree.Name = "progressBarAddTree";
            this.progressBarAddTree.Size = new System.Drawing.Size(165, 15);
            this.progressBarAddTree.TabIndex = 12;
            // 
            // labelMode
            // 
            this.labelMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMode.Location = new System.Drawing.Point(0, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(165, 36);
            this.labelMode.TabIndex = 13;
            this.labelMode.Text = "label1";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 203);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.progressBarAddTree);
            this.Controls.Add(this.maskedTextBoxDegree);
            this.Controls.Add(this.labelTreeDegree);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDataType);
            this.Controls.Add(this.comboBoxDataType);
            this.Controls.Add(this.labelTreeType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxAvailableTrees);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTree";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAvailableTrees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelTreeType;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.Label labelDataType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTreeDegree;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDegree;
        private System.Windows.Forms.ToolTip toolTipHelper;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAddTree;
        private System.Windows.Forms.ProgressBar progressBarAddTree;
        private System.Windows.Forms.Label labelMode;
    }
}