namespace Cafe
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
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.chickenCheckBox = new System.Windows.Forms.CheckBox();
            this.friesCheckBox = new System.Windows.Forms.CheckBox();
            this.soucesCheckBox = new System.Windows.Forms.CheckBox();
            this.colaCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "The price of order:";
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(137, 18);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(135, 26);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.priceLabel_Paint);
            // 
            // chickenCheckBox
            // 
            this.chickenCheckBox.AutoSize = true;
            this.chickenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chickenCheckBox.Location = new System.Drawing.Point(17, 58);
            this.chickenCheckBox.Name = "chickenCheckBox";
            this.chickenCheckBox.Size = new System.Drawing.Size(75, 20);
            this.chickenCheckBox.TabIndex = 2;
            this.chickenCheckBox.Text = "Chicken";
            this.chickenCheckBox.UseVisualStyleBackColor = true;
            this.chickenCheckBox.CheckedChanged += new System.EventHandler(this.chickenCheckBox_CheckedChanged);
            // 
            // friesCheckBox
            // 
            this.friesCheckBox.AutoSize = true;
            this.friesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.friesCheckBox.Location = new System.Drawing.Point(17, 83);
            this.friesCheckBox.Name = "friesCheckBox";
            this.friesCheckBox.Size = new System.Drawing.Size(57, 20);
            this.friesCheckBox.TabIndex = 3;
            this.friesCheckBox.Text = "Fries";
            this.friesCheckBox.UseVisualStyleBackColor = true;
            this.friesCheckBox.CheckedChanged += new System.EventHandler(this.friesCheckBox_CheckedChanged);
            // 
            // soucesCheckBox
            // 
            this.soucesCheckBox.AutoSize = true;
            this.soucesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soucesCheckBox.Location = new System.Drawing.Point(17, 108);
            this.soucesCheckBox.Name = "soucesCheckBox";
            this.soucesCheckBox.Size = new System.Drawing.Size(73, 20);
            this.soucesCheckBox.TabIndex = 4;
            this.soucesCheckBox.Text = "Souces";
            this.soucesCheckBox.UseVisualStyleBackColor = true;
            this.soucesCheckBox.CheckedChanged += new System.EventHandler(this.soucesCheckBox_CheckedChanged);
            // 
            // colaCheckBox
            // 
            this.colaCheckBox.AutoSize = true;
            this.colaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colaCheckBox.Location = new System.Drawing.Point(17, 132);
            this.colaCheckBox.Name = "colaCheckBox";
            this.colaCheckBox.Size = new System.Drawing.Size(55, 20);
            this.colaCheckBox.TabIndex = 5;
            this.colaCheckBox.Text = "Cola";
            this.colaCheckBox.UseVisualStyleBackColor = true;
            this.colaCheckBox.CheckedChanged += new System.EventHandler(this.colaCheckBox_CheckedChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(17, 167);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.colaCheckBox);
            this.Controls.Add(this.soucesCheckBox);
            this.Controls.Add(this.friesCheckBox);
            this.Controls.Add(this.chickenCheckBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cafe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.CheckBox chickenCheckBox;
        private System.Windows.Forms.CheckBox friesCheckBox;
        private System.Windows.Forms.CheckBox soucesCheckBox;
        private System.Windows.Forms.CheckBox colaCheckBox;
        private System.Windows.Forms.Button okButton;
    }
}

