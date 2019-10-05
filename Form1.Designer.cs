namespace PROJECT_1
{
    partial class frmGameEngine
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
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGameRound = new System.Windows.Forms.Label();
            this.lblGameMap = new System.Windows.Forms.Label();
            this.txtUnitUpdate = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(584, 461);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(716, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblGameRound
            // 
            this.lblGameRound.AutoSize = true;
            this.lblGameRound.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRound.Location = new System.Drawing.Point(580, 43);
            this.lblGameRound.Name = "lblGameRound";
            this.lblGameRound.Size = new System.Drawing.Size(136, 23);
            this.lblGameRound.TabIndex = 2;
            this.lblGameRound.Text = "Current Round";
            // 
            // lblGameMap
            // 
            this.lblGameMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGameMap.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMap.ForeColor = System.Drawing.Color.Azure;
            this.lblGameMap.Location = new System.Drawing.Point(12, 43);
            this.lblGameMap.Name = "lblGameMap";
            this.lblGameMap.Size = new System.Drawing.Size(534, 462);
            this.lblGameMap.TabIndex = 3;
            this.lblGameMap.Text = "Map";
            // 
            // txtUnitUpdate
            // 
            this.txtUnitUpdate.Location = new System.Drawing.Point(584, 138);
            this.txtUnitUpdate.Name = "txtUnitUpdate";
            this.txtUnitUpdate.Size = new System.Drawing.Size(256, 215);
            this.txtUnitUpdate.TabIndex = 4;
            this.txtUnitUpdate.Text = "";
            // 
            // frmGameEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 574);
            this.Controls.Add(this.txtUnitUpdate);
            this.Controls.Add(this.lblGameMap);
            this.Controls.Add(this.lblGameRound);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Name = "frmGameEngine";
            this.Text = "Game Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGameRound;
        private System.Windows.Forms.Label lblGameMap;
        private System.Windows.Forms.RichTextBox txtUnitUpdate;
    }
}

