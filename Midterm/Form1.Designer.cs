namespace Midterm
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
            this.components = new System.ComponentModel.Container();
            this.LongTestButton = new System.Windows.Forms.Button();
            this.shortTestButton = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.personBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LongTestButton
            // 
            this.LongTestButton.Location = new System.Drawing.Point(15, 80);
            this.LongTestButton.Name = "LongTestButton";
            this.LongTestButton.Size = new System.Drawing.Size(206, 23);
            this.LongTestButton.TabIndex = 0;
            this.LongTestButton.Text = "Int Test";
            this.LongTestButton.UseVisualStyleBackColor = true;
            this.LongTestButton.Click += new System.EventHandler(this.longTestButton_Click);
            // 
            // shortTestButton
            // 
            this.shortTestButton.Location = new System.Drawing.Point(15, 51);
            this.shortTestButton.Name = "shortTestButton";
            this.shortTestButton.Size = new System.Drawing.Size(206, 23);
            this.shortTestButton.TabIndex = 13;
            this.shortTestButton.Text = "Short Int Test";
            this.shortTestButton.UseVisualStyleBackColor = true;
            this.shortTestButton.Click += new System.EventHandler(this.shortTestButton_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM4";
            // 
            // personBox
            // 
            this.personBox.Location = new System.Drawing.Point(15, 25);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(206, 20);
            this.personBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Three Letter Initials (Column \"Person\"):";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 109);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(206, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 141);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shortTestButton);
            this.Controls.Add(this.LongTestButton);
            this.Name = "Form1";
            this.Text = "Midterm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LongTestButton;
        private System.Windows.Forms.Button shortTestButton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox personBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

