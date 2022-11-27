namespace Final_project
{
    partial class GameField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameField));
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.textOfQuestion = new System.Windows.Forms.TextBox();
            this.MoneyTree = new System.Windows.Forms.ListBox();
            this.Fifty = new System.Windows.Forms.Label();
            this.CallFriends = new System.Windows.Forms.Label();
            this.Audience = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.panelOfField = new System.Windows.Forms.Panel();
            this.panelOfQuestion = new System.Windows.Forms.Panel();
            this.panelOfButtonAndHelp = new System.Windows.Forms.Panel();
            this.panelOfHelp = new System.Windows.Forms.Panel();
            this.panelOfExit = new System.Windows.Forms.Panel();
            this.panelOfField.SuspendLayout();
            this.panelOfQuestion.SuspendLayout();
            this.panelOfButtonAndHelp.SuspendLayout();
            this.panelOfHelp.SuspendLayout();
            this.panelOfExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(28, 18);
            this.answer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(300, 90);
            this.answer1.TabIndex = 0;
            this.answer1.Tag = "1";
            this.answer1.Text = "answer1";
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(493, 18);
            this.answer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(300, 90);
            this.answer2.TabIndex = 1;
            this.answer2.Tag = "2";
            this.answer2.Text = "answer2";
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(28, 127);
            this.answer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(300, 90);
            this.answer3.TabIndex = 2;
            this.answer3.Tag = "3";
            this.answer3.Text = "answer3";
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(493, 127);
            this.answer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(300, 90);
            this.answer4.TabIndex = 3;
            this.answer4.Tag = "4";
            this.answer4.Text = "answer4";
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // textOfQuestion
            // 
            this.textOfQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.textOfQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textOfQuestion.Location = new System.Drawing.Point(0, 0);
            this.textOfQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textOfQuestion.Multiline = true;
            this.textOfQuestion.Name = "textOfQuestion";
            this.textOfQuestion.ReadOnly = true;
            this.textOfQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOfQuestion.Size = new System.Drawing.Size(844, 89);
            this.textOfQuestion.TabIndex = 4;
            // 
            // MoneyTree
            // 
            this.MoneyTree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoneyTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoneyTree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoneyTree.ForeColor = System.Drawing.Color.Gold;
            this.MoneyTree.FormattingEnabled = true;
            this.MoneyTree.ItemHeight = 27;
            this.MoneyTree.Items.AddRange(new object[] {
            "20: $2,000,000*",
            "19: $1,000,000",
            "18: $950,000",
            "17: $900,000",
            "16: $800,000",
            "15: $700,000",
            "14: $600,000*",
            "13: $500,000",
            "12: $300,000",
            "11: $150,000",
            "10: $100,000",
            "9: $75,000",
            "8: $50,000",
            "7: $25,000*",
            "6: $10,000",
            "5: $5,000",
            "4: $2,500",
            "3: $1,500",
            "2: $1,000",
            "1: $500"});
            this.MoneyTree.Location = new System.Drawing.Point(0, 0);
            this.MoneyTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoneyTree.Name = "MoneyTree";
            this.MoneyTree.Size = new System.Drawing.Size(300, 641);
            this.MoneyTree.TabIndex = 5;
            this.MoneyTree.SelectedIndexChanged += new System.EventHandler(this.MoneyTree_SelectedIndexChanged);
            // 
            // Fifty
            // 
            this.Fifty.Image = global::Final_project.Properties.Resources.fifty;
            this.Fifty.Location = new System.Drawing.Point(51, -23);
            this.Fifty.Name = "Fifty";
            this.Fifty.Size = new System.Drawing.Size(200, 200);
            this.Fifty.TabIndex = 6;
            this.Fifty.Click += new System.EventHandler(this.lifeline_fifthy);
            // 
            // CallFriends
            // 
            this.CallFriends.Image = global::Final_project.Properties.Resources.call;
            this.CallFriends.Location = new System.Drawing.Point(609, -12);
            this.CallFriends.Name = "CallFriends";
            this.CallFriends.Size = new System.Drawing.Size(200, 200);
            this.CallFriends.TabIndex = 7;
            this.CallFriends.Click += new System.EventHandler(this.lifeline_callfriend);
            // 
            // Audience
            // 
            this.Audience.Image = global::Final_project.Properties.Resources.audiance;
            this.Audience.Location = new System.Drawing.Point(312, -30);
            this.Audience.Name = "Audience";
            this.Audience.Size = new System.Drawing.Size(200, 200);
            this.Audience.TabIndex = 8;
            this.Audience.Click += new System.EventHandler(this.lifeline_audiance);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(331, 40);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(168, 73);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panelOfField
            // 
            this.panelOfField.Controls.Add(this.MoneyTree);
            this.panelOfField.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOfField.Location = new System.Drawing.Point(844, 0);
            this.panelOfField.Name = "panelOfField";
            this.panelOfField.Size = new System.Drawing.Size(300, 641);
            this.panelOfField.TabIndex = 10;
            // 
            // panelOfQuestion
            // 
            this.panelOfQuestion.Controls.Add(this.panelOfButtonAndHelp);
            this.panelOfQuestion.Controls.Add(this.panelOfExit);
            this.panelOfQuestion.Controls.Add(this.textOfQuestion);
            this.panelOfQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelOfQuestion.Name = "panelOfQuestion";
            this.panelOfQuestion.Size = new System.Drawing.Size(844, 641);
            this.panelOfQuestion.TabIndex = 11;
            // 
            // panelOfButtonAndHelp
            // 
            this.panelOfButtonAndHelp.Controls.Add(this.panelOfHelp);
            this.panelOfButtonAndHelp.Controls.Add(this.answer2);
            this.panelOfButtonAndHelp.Controls.Add(this.answer4);
            this.panelOfButtonAndHelp.Controls.Add(this.answer3);
            this.panelOfButtonAndHelp.Controls.Add(this.answer1);
            this.panelOfButtonAndHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfButtonAndHelp.Location = new System.Drawing.Point(0, 89);
            this.panelOfButtonAndHelp.Name = "panelOfButtonAndHelp";
            this.panelOfButtonAndHelp.Size = new System.Drawing.Size(844, 402);
            this.panelOfButtonAndHelp.TabIndex = 11;
            // 
            // panelOfHelp
            // 
            this.panelOfHelp.Controls.Add(this.Audience);
            this.panelOfHelp.Controls.Add(this.CallFriends);
            this.panelOfHelp.Controls.Add(this.Fifty);
            this.panelOfHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOfHelp.Location = new System.Drawing.Point(0, 232);
            this.panelOfHelp.Name = "panelOfHelp";
            this.panelOfHelp.Size = new System.Drawing.Size(844, 170);
            this.panelOfHelp.TabIndex = 9;
            // 
            // panelOfExit
            // 
            this.panelOfExit.Controls.Add(this.Exit);
            this.panelOfExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOfExit.Location = new System.Drawing.Point(0, 491);
            this.panelOfExit.Name = "panelOfExit";
            this.panelOfExit.Size = new System.Drawing.Size(844, 150);
            this.panelOfExit.TabIndex = 10;
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1144, 641);
            this.Controls.Add(this.panelOfQuestion);
            this.Controls.Add(this.panelOfField);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who Wants to Be a Millionaire?";
            this.Load += new System.EventHandler(this.GameField_Load);
            this.panelOfField.ResumeLayout(false);
            this.panelOfQuestion.ResumeLayout(false);
            this.panelOfQuestion.PerformLayout();
            this.panelOfButtonAndHelp.ResumeLayout(false);
            this.panelOfHelp.ResumeLayout(false);
            this.panelOfExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button answer1;
        private Button answer2;
        private Button answer3;
        private Button answer4;
        private TextBox textOfQuestion;
        private ListBox MoneyTree;
        private Label Fifty;
        private Label CallFriends;
        private Label Audience;
        private Button Exit;
        private Panel panelOfField;
        private Panel panelOfQuestion;
        private Panel panelOfButtonAndHelp;
        private Panel panelOfExit;
        private Panel panelOfHelp;
    }
}