namespace Project_1_H
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
            this.lblMap = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.Location = new System.Drawing.Point(12, 9);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(421, 432);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "label1";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.Location = new System.Drawing.Point(439, 9);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(216, 102);
            this.lblCurrentRound.TabIndex = 1;
            this.lblCurrentRound.Text = "label2";
            this.lblCurrentRound.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(439, 140);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(216, 172);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "";
            // 
            // btnStartPause
            // 
            this.btnStartPause.Location = new System.Drawing.Point(439, 332);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(216, 51);
            this.btnStartPause.TabIndex = 3;
            this.btnStartPause.Text = "START";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblCurrentRound);
            this.Controls.Add(this.lblMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Button btnStartPause;
    }
}

