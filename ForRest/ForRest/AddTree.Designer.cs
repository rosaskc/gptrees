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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTree));
            this.comboBoxAvailableTrees = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelTreeType = new System.Windows.Forms.Label();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.labelDataType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAvailableTrees
            // 
            this.comboBoxAvailableTrees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAvailableTrees.FormattingEnabled = true;
            this.comboBoxAvailableTrees.Location = new System.Drawing.Point(12, 36);
            this.comboBoxAvailableTrees.Name = "comboBoxAvailableTrees";
            this.comboBoxAvailableTrees.Size = new System.Drawing.Size(140, 21);
            this.comboBoxAvailableTrees.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 73);
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
            this.labelTreeType.Location = new System.Drawing.Point(26, 20);
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
            this.comboBoxDataType.Location = new System.Drawing.Point(192, 36);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(102, 21);
            this.comboBoxDataType.TabIndex = 5;
            this.comboBoxDataType.Visible = false;
            // 
            // labelDataType
            // 
            this.labelDataType.AutoSize = true;
            this.labelDataType.Location = new System.Drawing.Point(200, 20);
            this.labelDataType.Name = "labelDataType";
            this.labelDataType.Size = new System.Drawing.Size(87, 13);
            this.labelDataType.TabIndex = 6;
            this.labelDataType.Text = "Select data type:";
            this.labelDataType.Visible = false;
            // 
            // AddTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 133);
            this.Controls.Add(this.labelDataType);
            this.Controls.Add(this.comboBoxDataType);
            this.Controls.Add(this.labelTreeType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxAvailableTrees);
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
    }
}