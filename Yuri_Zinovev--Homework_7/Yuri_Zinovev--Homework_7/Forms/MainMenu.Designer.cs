namespace Forms
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listGames = new System.Windows.Forms.ListBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете игру";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listGames
            // 
            this.listGames.FormattingEnabled = true;
            this.listGames.Location = new System.Drawing.Point(17, 56);
            this.listGames.Name = "listGames";
            this.listGames.Size = new System.Drawing.Size(141, 199);
            this.listGames.TabIndex = 3;
            this.listGames.SelectedIndexChanged += new System.EventHandler(this.listGames_SelectedIndexChanged);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(165, 56);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            this.txbDescription.Size = new System.Drawing.Size(182, 199);
            this.txbDescription.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(165, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.listGames);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listGames;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Button button1;
    }
}