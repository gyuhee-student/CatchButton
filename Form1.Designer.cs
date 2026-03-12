namespace CatchButton
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
            myTarget = new Button();
            SuspendLayout();
            // 
            // myTarget
            // 
            myTarget.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            myTarget.ForeColor = Color.Coral;
            myTarget.Location = new Point(116, 77);
            myTarget.Name = "myTarget";
            myTarget.Size = new Size(235, 100);
            myTarget.TabIndex = 0;
            myTarget.Text = "나를 잡아봐";
            myTarget.TextAlign = ContentAlignment.MiddleRight;
            myTarget.UseVisualStyleBackColor = true;
            myTarget.Click += button1_Click;
            myTarget.MouseEnter += button1_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 508);
            Controls.Add(myTarget);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button myTarget;
    }
}
