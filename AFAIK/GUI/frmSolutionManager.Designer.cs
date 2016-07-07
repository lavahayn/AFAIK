namespace AFAIK.GUI
{
    partial class frmSolutionManager
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
            this.solutionNameTb = new System.Windows.Forms.TextBox();
            this.solutionNameLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // solutionNameTb
            // 
            this.solutionNameTb.Location = new System.Drawing.Point(12, 86);
            this.solutionNameTb.Name = "solutionNameTb";
            this.solutionNameTb.Size = new System.Drawing.Size(350, 20);
            this.solutionNameTb.TabIndex = 0;
            // 
            // solutionNameLabel
            // 
            this.solutionNameLabel.AutoSize = true;
            this.solutionNameLabel.Location = new System.Drawing.Point(12, 70);
            this.solutionNameLabel.Name = "solutionNameLabel";
            this.solutionNameLabel.Size = new System.Drawing.Size(107, 13);
            this.solutionNameLabel.TabIndex = 1;
            this.solutionNameLabel.Text = "Projektmappenname:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(287, 380);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Abbrechen";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(206, 380);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Erstellen";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // frmSolutionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 415);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.solutionNameLabel);
            this.Controls.Add(this.solutionNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSolutionManager";
            this.Text = "Neue Projektmappe erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox solutionNameTb;
        private System.Windows.Forms.Label solutionNameLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
    }
}