namespace VisualSorfWF
{
    partial class ChoiceForm
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
            this.groupBoxRadiobuttons = new System.Windows.Forms.GroupBox();
            this.forward = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxRadiobuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRadiobuttons
            // 
            this.groupBoxRadiobuttons.Controls.Add(this.forward);
            this.groupBoxRadiobuttons.Controls.Add(this.radioButton2);
            this.groupBoxRadiobuttons.Controls.Add(this.radioButton1);
            this.groupBoxRadiobuttons.Location = new System.Drawing.Point(2, 6);
            this.groupBoxRadiobuttons.Name = "groupBoxRadiobuttons";
            this.groupBoxRadiobuttons.Size = new System.Drawing.Size(479, 184);
            this.groupBoxRadiobuttons.TabIndex = 0;
            this.groupBoxRadiobuttons.TabStop = false;
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(242, 68);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(120, 49);
            this.forward.TabIndex = 2;
            this.forward.Text = ">>>";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(74, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Визуализация";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(74, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Расчет";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 198);
            this.Controls.Add(this.groupBoxRadiobuttons);
            this.Name = "ChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sortings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChoiceForm_FormClosing);
            this.groupBoxRadiobuttons.ResumeLayout(false);
            this.groupBoxRadiobuttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRadiobuttons;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button forward;
    }
}