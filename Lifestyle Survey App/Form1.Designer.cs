namespace Survey
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
            this.btn_Fill_out = new System.Windows.Forms.Button();
            this.btn_View_Results = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Fill_out
            // 
            this.btn_Fill_out.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Fill_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fill_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fill_out.Location = new System.Drawing.Point(301, 36);
            this.btn_Fill_out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Fill_out.Name = "btn_Fill_out";
            this.btn_Fill_out.Size = new System.Drawing.Size(317, 39);
            this.btn_Fill_out.TabIndex = 0;
            this.btn_Fill_out.Text = "Fill Out Survey";
            this.btn_Fill_out.UseVisualStyleBackColor = false;
            this.btn_Fill_out.Click += new System.EventHandler(this.btn_Fill_out_Click);
            // 
            // btn_View_Results
            // 
            this.btn_View_Results.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_View_Results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Results.Location = new System.Drawing.Point(301, 114);
            this.btn_View_Results.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_View_Results.Name = "btn_View_Results";
            this.btn_View_Results.Size = new System.Drawing.Size(317, 44);
            this.btn_View_Results.TabIndex = 1;
            this.btn_View_Results.Text = "View Survey Results";
            this.btn_View_Results.UseVisualStyleBackColor = false;
            this.btn_View_Results.Click += new System.EventHandler(this.btn_View_Results_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(882, 192);
            this.Controls.Add(this.btn_View_Results);
            this.Controls.Add(this.btn_Fill_out);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Choose Option";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fill_out;
        private System.Windows.Forms.Button btn_View_Results;
    }
}

