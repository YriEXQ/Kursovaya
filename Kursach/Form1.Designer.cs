namespace Kursach
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
            this.l_Files = new System.Windows.Forms.Label();
            this.l_Limit = new System.Windows.Forms.Label();
            this.l_Found = new System.Windows.Forms.Label();
            this.lb_Files = new System.Windows.Forms.ListBox();
            this.tb_Limit = new System.Windows.Forms.TextBox();
            this.b_Start = new System.Windows.Forms.Button();
            this.l_FoundCount = new System.Windows.Forms.Label();
            this.b_AddFiles = new System.Windows.Forms.Button();
            this.cb_ChunkSize = new System.Windows.Forms.ComboBox();
            this.l_ChunkSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_Files
            // 
            this.l_Files.AutoSize = true;
            this.l_Files.Location = new System.Drawing.Point(12, 9);
            this.l_Files.Name = "l_Files";
            this.l_Files.Size = new System.Drawing.Size(84, 13);
            this.l_Files.TabIndex = 0;
            this.l_Files.Text = "Выбор файлов:";
            // 
            // l_Limit
            // 
            this.l_Limit.AutoSize = true;
            this.l_Limit.Location = new System.Drawing.Point(151, 9);
            this.l_Limit.Name = "l_Limit";
            this.l_Limit.Size = new System.Drawing.Size(112, 13);
            this.l_Limit.TabIndex = 1;
            this.l_Limit.Text = "Граница совпадения";
            // 
            // l_Found
            // 
            this.l_Found.AutoSize = true;
            this.l_Found.Location = new System.Drawing.Point(151, 67);
            this.l_Found.Name = "l_Found";
            this.l_Found.Size = new System.Drawing.Size(95, 13);
            this.l_Found.TabIndex = 1;
            this.l_Found.Text = "Найдено файлов:";
            // 
            // lb_Files
            // 
            this.lb_Files.FormattingEnabled = true;
            this.lb_Files.Location = new System.Drawing.Point(15, 26);
            this.lb_Files.Name = "lb_Files";
            this.lb_Files.Size = new System.Drawing.Size(120, 186);
            this.lb_Files.TabIndex = 2;
            // 
            // tb_Limit
            // 
            this.tb_Limit.Location = new System.Drawing.Point(154, 26);
            this.tb_Limit.Name = "tb_Limit";
            this.tb_Limit.Size = new System.Drawing.Size(109, 20);
            this.tb_Limit.TabIndex = 3;
            this.tb_Limit.Text = "0";
            // 
            // b_Start
            // 
            this.b_Start.Location = new System.Drawing.Point(154, 218);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(109, 23);
            this.b_Start.TabIndex = 4;
            this.b_Start.Text = "Запуск";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // l_FoundCount
            // 
            this.l_FoundCount.AutoSize = true;
            this.l_FoundCount.Location = new System.Drawing.Point(151, 80);
            this.l_FoundCount.Name = "l_FoundCount";
            this.l_FoundCount.Size = new System.Drawing.Size(13, 13);
            this.l_FoundCount.TabIndex = 1;
            this.l_FoundCount.Text = "0";
            // 
            // b_AddFiles
            // 
            this.b_AddFiles.Location = new System.Drawing.Point(15, 218);
            this.b_AddFiles.Name = "b_AddFiles";
            this.b_AddFiles.Size = new System.Drawing.Size(120, 23);
            this.b_AddFiles.TabIndex = 4;
            this.b_AddFiles.Text = "Добавить файлы";
            this.b_AddFiles.UseVisualStyleBackColor = true;
            this.b_AddFiles.Click += new System.EventHandler(this.b_AddFiles_Click);
            // 
            // cb_ChunkSize
            // 
            this.cb_ChunkSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChunkSize.FormattingEnabled = true;
            this.cb_ChunkSize.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.cb_ChunkSize.Location = new System.Drawing.Point(154, 119);
            this.cb_ChunkSize.Name = "cb_ChunkSize";
            this.cb_ChunkSize.Size = new System.Drawing.Size(109, 21);
            this.cb_ChunkSize.TabIndex = 6;
            this.cb_ChunkSize.SelectedIndexChanged += new System.EventHandler(this.cb_ChunkSize_SelectedIndexChanged);
            // 
            // l_ChunkSize
            // 
            this.l_ChunkSize.AutoSize = true;
            this.l_ChunkSize.Location = new System.Drawing.Point(151, 103);
            this.l_ChunkSize.Name = "l_ChunkSize";
            this.l_ChunkSize.Size = new System.Drawing.Size(89, 13);
            this.l_ChunkSize.TabIndex = 1;
            this.l_ChunkSize.Text = "Размер шингла:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_ChunkSize);
            this.Controls.Add(this.b_AddFiles);
            this.Controls.Add(this.b_Start);
            this.Controls.Add(this.tb_Limit);
            this.Controls.Add(this.lb_Files);
            this.Controls.Add(this.l_FoundCount);
            this.Controls.Add(this.l_ChunkSize);
            this.Controls.Add(this.l_Found);
            this.Controls.Add(this.l_Limit);
            this.Controls.Add(this.l_Files);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Files;
        private System.Windows.Forms.Label l_Limit;
        private System.Windows.Forms.Label l_Found;
        private System.Windows.Forms.ListBox lb_Files;
        private System.Windows.Forms.TextBox tb_Limit;
        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.Label l_FoundCount;
        private System.Windows.Forms.Button b_AddFiles;
        private System.Windows.Forms.ComboBox cb_ChunkSize;
        private System.Windows.Forms.Label l_ChunkSize;
    }
}

