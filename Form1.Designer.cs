namespace London_Baku
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Baku = new System.Windows.Forms.Button();
            this.btn_London = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Baku
            // 
            this.btn_Baku.AutoSize = true;
            this.btn_Baku.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Baku.Location = new System.Drawing.Point(142, 81);
            this.btn_Baku.Name = "btn_Baku";
            this.btn_Baku.Size = new System.Drawing.Size(75, 30);
            this.btn_Baku.TabIndex = 0;
            this.btn_Baku.Text = "Baku";
            this.btn_Baku.UseVisualStyleBackColor = true;
            this.btn_Baku.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Baku_MouseClick);
            // 
            // btn_London
            // 
            this.btn_London.AutoSize = true;
            this.btn_London.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_London.Location = new System.Drawing.Point(531, 81);
            this.btn_London.Name = "btn_London";
            this.btn_London.Size = new System.Drawing.Size(85, 30);
            this.btn_London.TabIndex = 1;
            this.btn_London.Text = "London";
            this.btn_London.UseVisualStyleBackColor = true;
            this.btn_London.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_London_MouseClick);
            // 
            // btn_Run
            // 
            this.btn_Run.AutoSize = true;
            this.btn_Run.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Run.Location = new System.Drawing.Point(377, 197);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 30);
            this.btn_Run.TabIndex = 2;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.MouseHover += new System.EventHandler(this.btn_Run_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::London_Baku.Properties.Resources._240_F_231148604_0hQFi09fYKlV0J7jnBVCIFR8sTCOI3J9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_London);
            this.Controls.Add(this.btn_Baku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Baku;
        private Button btn_London;
        private Button btn_Run;
    }
}