namespace Forms
{
    partial class DoublerForm
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
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnResetToOne = new System.Windows.Forms.Button();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblGoalStatic = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblCurrentStatic = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lblMovesStatic = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlusOne.Location = new System.Drawing.Point(9, 124);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(50, 33);
            this.btnPlusOne.TabIndex = 0;
            this.btnPlusOne.Text = "+1";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDouble.Location = new System.Drawing.Point(62, 124);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(50, 33);
            this.btnDouble.TabIndex = 0;
            this.btnDouble.Text = "x2";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnResetToOne
            // 
            this.btnResetToOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResetToOne.Location = new System.Drawing.Point(115, 124);
            this.btnResetToOne.Name = "btnResetToOne";
            this.btnResetToOne.Size = new System.Drawing.Size(50, 33);
            this.btnResetToOne.TabIndex = 0;
            this.btnResetToOne.Text = "=1";
            this.btnResetToOne.UseVisualStyleBackColor = true;
            this.btnResetToOne.Click += new System.EventHandler(this.btnResetToOne_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGoal.ForeColor = System.Drawing.Color.Green;
            this.lblGoal.Location = new System.Drawing.Point(141, 59);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(108, 46);
            this.lblGoal.TabIndex = 1;
            this.lblGoal.Text = "1000";
            // 
            // lblGoalStatic
            // 
            this.lblGoalStatic.AutoSize = true;
            this.lblGoalStatic.ForeColor = System.Drawing.Color.Green;
            this.lblGoalStatic.Location = new System.Drawing.Point(146, 36);
            this.lblGoalStatic.Name = "lblGoalStatic";
            this.lblGoalStatic.Size = new System.Drawing.Size(36, 13);
            this.lblGoalStatic.TabIndex = 2;
            this.lblGoalStatic.Text = "GOAL";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrent.ForeColor = System.Drawing.Color.Green;
            this.lblCurrent.Location = new System.Drawing.Point(12, 59);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(108, 46);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "1000";
            // 
            // lblCurrentStatic
            // 
            this.lblCurrentStatic.AutoSize = true;
            this.lblCurrentStatic.ForeColor = System.Drawing.Color.Green;
            this.lblCurrentStatic.Location = new System.Drawing.Point(17, 36);
            this.lblCurrentStatic.Name = "lblCurrentStatic";
            this.lblCurrentStatic.Size = new System.Drawing.Size(60, 13);
            this.lblCurrentStatic.TabIndex = 2;
            this.lblCurrentStatic.Text = "CURRENT";
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(168, 163);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(75, 33);
            this.btnResetGame.TabIndex = 3;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // lblMovesStatic
            // 
            this.lblMovesStatic.AutoSize = true;
            this.lblMovesStatic.ForeColor = System.Drawing.Color.Green;
            this.lblMovesStatic.Location = new System.Drawing.Point(17, 9);
            this.lblMovesStatic.Name = "lblMovesStatic";
            this.lblMovesStatic.Size = new System.Drawing.Size(39, 13);
            this.lblMovesStatic.TabIndex = 2;
            this.lblMovesStatic.Text = "Moves";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.ForeColor = System.Drawing.Color.Green;
            this.lblMoves.Location = new System.Drawing.Point(54, 9);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(19, 13);
            this.lblMoves.TabIndex = 2;
            this.lblMoves.Text = "10";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(168, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DoublerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 205);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.lblMovesStatic);
            this.Controls.Add(this.lblCurrentStatic);
            this.Controls.Add(this.lblGoalStatic);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.btnResetToOne);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlusOne);
            this.Name = "DoublerForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnResetToOne;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblGoalStatic;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblCurrentStatic;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Label lblMovesStatic;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Button btnCancel;
    }
}