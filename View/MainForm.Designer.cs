namespace skillTestVillon.View
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxSortStrategy;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelInput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxSortStrategy = new System.Windows.Forms.ComboBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 33);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(260, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // comboBoxSortStrategy
            // 
            this.comboBoxSortStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortStrategy.FormattingEnabled = true;
            this.comboBoxSortStrategy.Location = new System.Drawing.Point(12, 61);
            this.comboBoxSortStrategy.Name = "comboBoxSortStrategy";
            this.comboBoxSortStrategy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSortStrategy.TabIndex = 1;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(139, 59);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 85);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Output";
            // 
            // Input
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(13, 14);
            this.labelInput.Name = "Input";
            this.labelInput.Size = new System.Drawing.Size(35, 13);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Input";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 137);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.comboBoxSortStrategy);
            this.Controls.Add(this.textBoxInput);
            this.Name = "MainForm";
            this.Text = "Sort Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

      
    }
}