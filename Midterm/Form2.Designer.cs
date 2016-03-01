namespace Midterm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.submitData = new System.Windows.Forms.Button();
            this.cancelData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.input,
            this.rawData,
            this.convData});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // input
            // 
            this.input.HeaderText = "For Loop Input";
            this.input.Name = "input";
            // 
            // rawData
            // 
            this.rawData.HeaderText = "Raw Output";
            this.rawData.Name = "rawData";
            // 
            // convData
            // 
            this.convData.HeaderText = "Converted Output";
            this.convData.Name = "convData";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Is this data okay? If so press \"Ok\".";
            // 
            // submitData
            // 
            this.submitData.Location = new System.Drawing.Point(171, 305);
            this.submitData.Name = "submitData";
            this.submitData.Size = new System.Drawing.Size(75, 23);
            this.submitData.TabIndex = 2;
            this.submitData.Text = "Ok";
            this.submitData.UseVisualStyleBackColor = true;
            this.submitData.Click += new System.EventHandler(this.submitData_Click);
            // 
            // cancelData
            // 
            this.cancelData.Location = new System.Drawing.Point(264, 305);
            this.cancelData.Name = "cancelData";
            this.cancelData.Size = new System.Drawing.Size(75, 23);
            this.cancelData.TabIndex = 3;
            this.cancelData.Text = "Cancel";
            this.cancelData.UseVisualStyleBackColor = true;
            this.cancelData.Click += new System.EventHandler(this.cancelData_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 341);
            this.Controls.Add(this.cancelData);
            this.Controls.Add(this.submitData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Data Check";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn input;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawData;
        private System.Windows.Forms.DataGridViewTextBoxColumn convData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitData;
        private System.Windows.Forms.Button cancelData;
    }
}