namespace WindowsFormsApp1
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
            this.tb_original = new System.Windows.Forms.TextBox();
            this.tb_compare = new System.Windows.Forms.TextBox();
            this.l_original = new System.Windows.Forms.Label();
            this.l_compare = new System.Windows.Forms.Label();
            this.b_do = new System.Windows.Forms.Button();
            this.l_TextOfPercent = new System.Windows.Forms.Label();
            this.l_PercentOfCoince = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_original
            // 
            this.tb_original.Location = new System.Drawing.Point(12, 25);
            this.tb_original.MaxLength = 1073741824;
            this.tb_original.Multiline = true;
            this.tb_original.Name = "tb_original";
            this.tb_original.Size = new System.Drawing.Size(260, 97);
            this.tb_original.TabIndex = 0;
            // 
            // tb_compare
            // 
            this.tb_compare.Location = new System.Drawing.Point(12, 152);
            this.tb_compare.MaxLength = 1073741824;
            this.tb_compare.Multiline = true;
            this.tb_compare.Name = "tb_compare";
            this.tb_compare.Size = new System.Drawing.Size(260, 97);
            this.tb_compare.TabIndex = 0;
            // 
            // l_original
            // 
            this.l_original.AutoSize = true;
            this.l_original.Location = new System.Drawing.Point(12, 9);
            this.l_original.Name = "l_original";
            this.l_original.Size = new System.Drawing.Size(89, 13);
            this.l_original.TabIndex = 1;
            this.l_original.Text = "Исходный текст";
            // 
            // l_compare
            // 
            this.l_compare.AutoSize = true;
            this.l_compare.Location = new System.Drawing.Point(12, 136);
            this.l_compare.Name = "l_compare";
            this.l_compare.Size = new System.Drawing.Size(115, 13);
            this.l_compare.TabIndex = 2;
            this.l_compare.Text = "Сравниваемый текст";
            // 
            // b_do
            // 
            this.b_do.Location = new System.Drawing.Point(197, 255);
            this.b_do.Name = "b_do";
            this.b_do.Size = new System.Drawing.Size(75, 23);
            this.b_do.TabIndex = 3;
            this.b_do.Text = "Выполнить";
            this.b_do.UseVisualStyleBackColor = true;
            this.b_do.Click += new System.EventHandler(this.b_do_Click);
            // 
            // l_TextOfPercent
            // 
            this.l_TextOfPercent.AutoSize = true;
            this.l_TextOfPercent.Location = new System.Drawing.Point(9, 260);
            this.l_TextOfPercent.Name = "l_TextOfPercent";
            this.l_TextOfPercent.Size = new System.Drawing.Size(113, 13);
            this.l_TextOfPercent.TabIndex = 4;
            this.l_TextOfPercent.Text = "Процент совпадений";
            // 
            // l_PercentOfCoince
            // 
            this.l_PercentOfCoince.AutoSize = true;
            this.l_PercentOfCoince.Location = new System.Drawing.Point(128, 260);
            this.l_PercentOfCoince.Name = "l_PercentOfCoince";
            this.l_PercentOfCoince.Size = new System.Drawing.Size(10, 13);
            this.l_PercentOfCoince.TabIndex = 4;
            this.l_PercentOfCoince.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.l_PercentOfCoince);
            this.Controls.Add(this.l_TextOfPercent);
            this.Controls.Add(this.b_do);
            this.Controls.Add(this.l_compare);
            this.Controls.Add(this.l_original);
            this.Controls.Add(this.tb_compare);
            this.Controls.Add(this.tb_original);
            this.Name = "Form1";
            this.Text = "W-Shingles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_original;
        private System.Windows.Forms.TextBox tb_compare;
        private System.Windows.Forms.Label l_original;
        private System.Windows.Forms.Label l_compare;
        private System.Windows.Forms.Button b_do;
        private System.Windows.Forms.Label l_TextOfPercent;
        private System.Windows.Forms.Label l_PercentOfCoince;
    }
}

