namespace PROYECTO.Forms
{
    partial class formLoginHistory
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
            this.DGlogHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGlogHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // DGlogHistory
            // 
            this.DGlogHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGlogHistory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGlogHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlogHistory.Location = new System.Drawing.Point(150, 61);
            this.DGlogHistory.Name = "DGlogHistory";
            this.DGlogHistory.RowHeadersWidth = 51;
            this.DGlogHistory.RowTemplate.Height = 24;
            this.DGlogHistory.Size = new System.Drawing.Size(428, 308);
            this.DGlogHistory.TabIndex = 0;
            // 
            // formLoginHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGlogHistory);
            this.Name = "formLoginHistory";
            this.Text = "formLoginHistory";
            this.Load += new System.EventHandler(this.formLoginHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGlogHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGlogHistory;
    }
}