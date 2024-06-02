namespace WinFormsApp4
{

    partial class FormCircle
    {
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            txtRadius = new TextBox();
            btnCalculate = new Button();
            lblCircumference = new Label();
            lblArea = new Label();
            lblResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(14, 14);
            txtRadius.Margin = new Padding(4, 3, 4, 3);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(116, 23);
            txtRadius.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(14, 44);
            btnCalculate.Margin = new Padding(4, 3, 4, 3);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(117, 27);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblCircumference
            // 
            lblCircumference.AutoSize = true;
            lblCircumference.Location = new Point(14, 74);
            lblCircumference.Margin = new Padding(4, 0, 4, 0);
            lblCircumference.Name = "lblCircumference";
            lblCircumference.Size = new Size(88, 15);
            lblCircumference.TabIndex = 2;
            lblCircumference.Text = "Circumference:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(14, 100);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(34, 15);
            lblArea.TabIndex = 3;
            lblArea.Text = "Area:";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(0, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(100, 23);
            lblResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 164);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 4;
            label1.Text = "This Form Not Working";
            label1.Click += label1_Click;
            // 
            // FormCircle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 301);
            Controls.Add(label1);
            Controls.Add(lblArea);
            Controls.Add(lblCircumference);
            Controls.Add(btnCalculate);
            Controls.Add(txtRadius);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCircle";
            Text = "Circle Calculator";
            Load += FormCircle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }

}