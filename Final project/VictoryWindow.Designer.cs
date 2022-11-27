namespace Final_project
{
    partial class VictoryWindow
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
            System.Windows.Forms.PictureBox Winner;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictoryWindow));
            Winner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(Winner)).BeginInit();
            this.SuspendLayout();
            // 
            // Winner
            // 
            Winner.Dock = System.Windows.Forms.DockStyle.Fill;
            Winner.Image = global::Final_project.Properties.Resources.win;
            Winner.InitialImage = null;
            Winner.Location = new System.Drawing.Point(0, 0);
            Winner.Name = "Winner";
            Winner.Size = new System.Drawing.Size(1144, 641);
            Winner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            Winner.TabIndex = 0;
            Winner.TabStop = false;
            // 
            // VictoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1144, 641);
            this.Controls.Add(Winner);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VictoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who Wants to Be a Millionaire?";
            ((System.ComponentModel.ISupportInitialize)(Winner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}