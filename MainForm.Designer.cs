namespace BeschrijvingMaken
{
    partial class MainForm
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
            ListViewSteps = new ListView();
            ButtonStart = new Button();
            ButtonStop = new Button();
            SuspendLayout();
            // 
            // ListViewSteps
            // 
            ListViewSteps.Location = new Point(12, 72);
            ListViewSteps.Name = "ListViewSteps";
            ListViewSteps.Size = new Size(776, 366);
            ListViewSteps.TabIndex = 0;
            ListViewSteps.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(12, 12);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(86, 54);
            ButtonStart.TabIndex = 1;
            ButtonStart.Text = "Start";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonStop
            // 
            ButtonStop.Location = new Point(104, 12);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.Size = new Size(86, 54);
            ButtonStop.TabIndex = 2;
            ButtonStop.Text = "Stop";
            ButtonStop.UseVisualStyleBackColor = true;
            ButtonStop.Click += ButtonStop_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonStop);
            Controls.Add(ButtonStart);
            Controls.Add(ListViewSteps);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView ListViewSteps;
        private Button ButtonStart;
        private Button ButtonStop;
    }
}
