namespace WinFormsApp4
{
    partial class FormTriangle
    {
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // txtBase
            this.txtBase.Location = new System.Drawing.Point(12, 12);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 0;
            // txtHeight
            this.txtHeight.Location = new System.Drawing.Point(12, 40);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 1;
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
            // FormTriangle
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBase);
            this.Name = "FormTriangle";
            this.Text = "Triangle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}