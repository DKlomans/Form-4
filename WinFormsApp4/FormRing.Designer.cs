namespace WinFormsApp4
{
    partial class FormRing
    {
        private System.Windows.Forms.TextBox txtOuterRadius;
        private System.Windows.Forms.TextBox txtInnerRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            this.txtOuterRadius = new System.Windows.Forms.TextBox();
            this.txtInnerRadius = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // txtOuterRadius
            this.txtOuterRadius.Location = new System.Drawing.Point(12, 12);
            this.txtOuterRadius.Name = "txtOuterRadius";
            this.txtOuterRadius.Size = new System.Drawing.Size(100, 20);
            this.txtOuterRadius.TabIndex = 0;
            // txtInnerRadius
            this.txtInnerRadius.Location = new System.Drawing.Point(12, 40);
            this.txtInnerRadius.Name = "txtInnerRadius";
            this.txtInnerRadius.Size = new System.Drawing.Size(100, 20);
            this.txtInnerRadius.TabIndex = 1;
            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(118, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new EventHandler(this.btnCalculate_Click);
            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // FormRing
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInnerRadius);
            this.Controls.Add(this.txtOuterRadius);
            this.Name = "FormRing";
            this.Text = "Ring Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}