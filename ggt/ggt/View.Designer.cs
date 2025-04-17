namespace ggt
{
    partial class View
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
            labelZahl1 = new Label();
            labelZahl2 = new Label();
            labelGGT = new Label();
            textBoxZahl1 = new TextBox();
            textBoxZahl2 = new TextBox();
            textBoxGGT = new TextBox();
            buttonGGTBerechnen = new Button();
            SuspendLayout();
            // 
            // labelZahl1
            // 
            labelZahl1.AutoSize = true;
            labelZahl1.Location = new Point(46, 25);
            labelZahl1.Name = "labelZahl1";
            labelZahl1.Size = new Size(36, 15);
            labelZahl1.TabIndex = 0;
            labelZahl1.Text = "Zahl1";
            // 
            // labelZahl2
            // 
            labelZahl2.AutoSize = true;
            labelZahl2.Location = new Point(151, 25);
            labelZahl2.Name = "labelZahl2";
            labelZahl2.Size = new Size(36, 15);
            labelZahl2.TabIndex = 1;
            labelZahl2.Text = "Zahl2";
            // 
            // labelGGT
            // 
            labelGGT.AutoSize = true;
            labelGGT.Location = new Point(257, 25);
            labelGGT.Name = "labelGGT";
            labelGGT.Size = new Size(29, 15);
            labelGGT.TabIndex = 2;
            labelGGT.Text = "GGT";
            // 
            // textBoxZahl1
            // 
            textBoxZahl1.Location = new Point(12, 43);
            textBoxZahl1.Name = "textBoxZahl1";
            textBoxZahl1.Size = new Size(100, 23);
            textBoxZahl1.TabIndex = 3;
            // 
            // textBoxZahl2
            // 
            textBoxZahl2.Location = new Point(118, 43);
            textBoxZahl2.Name = "textBoxZahl2";
            textBoxZahl2.Size = new Size(100, 23);
            textBoxZahl2.TabIndex = 4;
            // 
            // textBoxGGT
            // 
            textBoxGGT.Location = new Point(224, 43);
            textBoxGGT.Name = "textBoxGGT";
            textBoxGGT.Size = new Size(100, 23);
            textBoxGGT.TabIndex = 5;
            // 
            // buttonGGTBerechnen
            // 
            buttonGGTBerechnen.Location = new Point(131, 72);
            buttonGGTBerechnen.Name = "buttonGGTBerechnen";
            buttonGGTBerechnen.Size = new Size(75, 23);
            buttonGGTBerechnen.TabIndex = 6;
            buttonGGTBerechnen.Text = "GGT";
            buttonGGTBerechnen.UseVisualStyleBackColor = true;
            buttonGGTBerechnen.Click += buttonGGTBerechnen_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 127);
            Controls.Add(buttonGGTBerechnen);
            Controls.Add(textBoxGGT);
            Controls.Add(textBoxZahl2);
            Controls.Add(textBoxZahl1);
            Controls.Add(labelGGT);
            Controls.Add(labelZahl2);
            Controls.Add(labelZahl1);
            Name = "View";
            Text = "OMG_DoyunKim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelZahl1;
        private Label labelZahl2;
        private Label labelGGT;
        private TextBox textBoxZahl1;
        private TextBox textBoxZahl2;
        private TextBox textBoxGGT;
        private Button buttonGGTBerechnen;
    }
}
