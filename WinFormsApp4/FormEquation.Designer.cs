namespace WinFormsApp4
{
    partial class FormEquation
    {
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // txtX
            this.txtX.Location = new System.Drawing.Point(12, 12);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(118, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);
            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 45);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // FormEquation
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtX);
            this.Name = "FormEquation";
            this.Text = "Equation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}