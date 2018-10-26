namespace DiceWare
{
    partial class Form1
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.ddlDictionary = new System.Windows.Forms.ComboBox();
            this.ictrlNumberOfWords = new System.Windows.Forms.NumericUpDown();
            this.chkSplit = new System.Windows.Forms.CheckBox();
            this.txtSplitChar = new System.Windows.Forms.TextBox();
            this.btnRndChar = new System.Windows.Forms.Button();
            this.btnRndNum = new System.Windows.Forms.Button();
            this.btnRndSymbol = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ictrlNumberOfWords)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 229);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(408, 45);
            this.txtPassword.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(426, 229);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(80, 45);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // ddlDictionary
            // 
            this.ddlDictionary.FormattingEnabled = true;
            this.ddlDictionary.Location = new System.Drawing.Point(265, 12);
            this.ddlDictionary.Name = "ddlDictionary";
            this.ddlDictionary.Size = new System.Drawing.Size(241, 21);
            this.ddlDictionary.TabIndex = 2;
            // 
            // ictrlNumberOfWords
            // 
            this.ictrlNumberOfWords.Location = new System.Drawing.Point(265, 53);
            this.ictrlNumberOfWords.Name = "ictrlNumberOfWords";
            this.ictrlNumberOfWords.Size = new System.Drawing.Size(241, 20);
            this.ictrlNumberOfWords.TabIndex = 4;
            // 
            // chkSplit
            // 
            this.chkSplit.AutoSize = true;
            this.chkSplit.Checked = true;
            this.chkSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSplit.Location = new System.Drawing.Point(265, 99);
            this.chkSplit.Name = "chkSplit";
            this.chkSplit.Size = new System.Drawing.Size(52, 17);
            this.chkSplit.TabIndex = 5;
            this.chkSplit.Text = "Split?";
            this.chkSplit.UseVisualStyleBackColor = true;
            this.chkSplit.CheckedChanged += new System.EventHandler(this.chkSplit_CheckedChanged);
            // 
            // txtSplitChar
            // 
            this.txtSplitChar.Location = new System.Drawing.Point(426, 96);
            this.txtSplitChar.MaxLength = 1;
            this.txtSplitChar.Name = "txtSplitChar";
            this.txtSplitChar.Size = new System.Drawing.Size(80, 20);
            this.txtSplitChar.TabIndex = 6;
            this.txtSplitChar.Text = "_";
            // 
            // btnRndChar
            // 
            this.btnRndChar.Location = new System.Drawing.Point(12, 145);
            this.btnRndChar.Name = "btnRndChar";
            this.btnRndChar.Size = new System.Drawing.Size(69, 49);
            this.btnRndChar.TabIndex = 7;
            this.btnRndChar.Text = "Add Random Char";
            this.btnRndChar.UseVisualStyleBackColor = true;
            this.btnRndChar.Click += new System.EventHandler(this.btnRndChar_Click);
            // 
            // btnRndNum
            // 
            this.btnRndNum.Location = new System.Drawing.Point(87, 145);
            this.btnRndNum.Name = "btnRndNum";
            this.btnRndNum.Size = new System.Drawing.Size(69, 49);
            this.btnRndNum.TabIndex = 8;
            this.btnRndNum.Text = "Add Random Number";
            this.btnRndNum.UseVisualStyleBackColor = true;
            this.btnRndNum.Click += new System.EventHandler(this.btnRndNum_Click);
            // 
            // btnRndSymbol
            // 
            this.btnRndSymbol.Location = new System.Drawing.Point(162, 145);
            this.btnRndSymbol.Name = "btnRndSymbol";
            this.btnRndSymbol.Size = new System.Drawing.Size(69, 49);
            this.btnRndSymbol.TabIndex = 9;
            this.btnRndSymbol.Text = "Add Random Symbol";
            this.btnRndSymbol.UseVisualStyleBackColor = true;
            this.btnRndSymbol.Click += new System.EventHandler(this.btnRndSymbol_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(265, 145);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(241, 69);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dictionary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number Of Words:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "On What Char?";
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Location = new System.Drawing.Point(265, 122);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(141, 17);
            this.chkUppercase.TabIndex = 14;
            this.chkUppercase.Text = "Uppercase First Letters?";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 286);
            this.Controls.Add(this.chkUppercase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnRndSymbol);
            this.Controls.Add(this.btnRndNum);
            this.Controls.Add(this.btnRndChar);
            this.Controls.Add(this.txtSplitChar);
            this.Controls.Add(this.chkSplit);
            this.Controls.Add(this.ictrlNumberOfWords);
            this.Controls.Add(this.ddlDictionary);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtPassword);
            this.Name = "Form1";
            this.Text = "DiceWare";
            ((System.ComponentModel.ISupportInitialize)(this.ictrlNumberOfWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox ddlDictionary;
        private System.Windows.Forms.NumericUpDown ictrlNumberOfWords;
        private System.Windows.Forms.CheckBox chkSplit;
        private System.Windows.Forms.TextBox txtSplitChar;
        private System.Windows.Forms.Button btnRndChar;
        private System.Windows.Forms.Button btnRndNum;
        private System.Windows.Forms.Button btnRndSymbol;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUppercase;
    }
}

