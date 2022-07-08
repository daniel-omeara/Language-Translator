namespace Language_Translator
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
            this.labelInstruction = new System.Windows.Forms.Label();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.buttonItalian = new System.Windows.Forms.Button();
            this.buttonSpanish = new System.Windows.Forms.Button();
            this.buttonGerman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(24, 9);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(253, 15);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Select a language and I will say Good Morning.";
            // 
            // labelTranslation
            // 
            this.labelTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTranslation.Location = new System.Drawing.Point(12, 48);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(274, 23);
            this.labelTranslation.TabIndex = 1;
            this.labelTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonItalian
            // 
            this.buttonItalian.Location = new System.Drawing.Point(12, 104);
            this.buttonItalian.Name = "buttonItalian";
            this.buttonItalian.Size = new System.Drawing.Size(75, 23);
            this.buttonItalian.TabIndex = 2;
            this.buttonItalian.Text = "Italian";
            this.buttonItalian.UseVisualStyleBackColor = true;
            this.buttonItalian.Click += new System.EventHandler(this.buttonItalian_Click);
            // 
            // buttonSpanish
            // 
            this.buttonSpanish.Location = new System.Drawing.Point(113, 104);
            this.buttonSpanish.Name = "buttonSpanish";
            this.buttonSpanish.Size = new System.Drawing.Size(75, 23);
            this.buttonSpanish.TabIndex = 3;
            this.buttonSpanish.Text = "Spanish";
            this.buttonSpanish.UseVisualStyleBackColor = true;
            this.buttonSpanish.Click += new System.EventHandler(this.buttonSpanish_Click);
            // 
            // buttonGerman
            // 
            this.buttonGerman.Location = new System.Drawing.Point(211, 104);
            this.buttonGerman.Name = "buttonGerman";
            this.buttonGerman.Size = new System.Drawing.Size(75, 23);
            this.buttonGerman.TabIndex = 4;
            this.buttonGerman.Text = "German";
            this.buttonGerman.UseVisualStyleBackColor = true;
            this.buttonGerman.Click += new System.EventHandler(this.buttonGerman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 139);
            this.Controls.Add(this.buttonGerman);
            this.Controls.Add(this.buttonSpanish);
            this.Controls.Add(this.buttonItalian);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.labelInstruction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelInstruction;
        private Label labelTranslation;
        private Button buttonItalian;
        private Button buttonSpanish;
        private Button buttonGerman;
    }
}