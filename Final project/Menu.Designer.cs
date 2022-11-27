namespace Final_project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.GifOfGame = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GifOfGame
            // 
            this.GifOfGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.GifOfGame.Image = global::Final_project.Properties.Resources.title;
            this.GifOfGame.Location = new System.Drawing.Point(0, 0);
            this.GifOfGame.Name = "GifOfGame";
            this.GifOfGame.Size = new System.Drawing.Size(902, 332);
            this.GifOfGame.TabIndex = 0;
            this.GifOfGame.Text = "giffOfStart";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(352, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 50);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.start_Click);
            // 
            // Rules
            // 
            this.Rules.Location = new System.Drawing.Point(352, 67);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(200, 50);
            this.Rules.TabIndex = 2;
            this.Rules.Text = "Правила игры";
            this.Rules.UseVisualStyleBackColor = true;
            this.Rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(352, 129);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.Rules);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 179);
            this.panel1.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(902, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GifOfGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who Wants to Be a Millionaire?";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label GifOfGame;
        private Button Start;
        private Button Rules;
        private Button Exit;
        private Panel panel1;
    }
}