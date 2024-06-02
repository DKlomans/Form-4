namespace WinFormsApp4
{
    partial class Form1
    {
        private Button btnEquation;
        private Button btnCircle;
        private Button btnTriangle;
        private Button btnRing;

        private void InitializeComponent()
        {
            this.btnEquation = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEquation
            // 
            this.btnEquation.Location = new System.Drawing.Point(50, 50);
            this.btnEquation.Name = "btnEquation";
            this.btnEquation.Size = new System.Drawing.Size(100, 50);
            this.btnEquation.Text = "Equation";
            this.btnEquation.UseVisualStyleBackColor = true;
            this.btnEquation.Click += new System.EventHandler(this.btnEquation_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(200, 50);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(100, 50);
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(350, 50);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(100, 50);
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRing
            // 
            this.btnRing.Location = new System.Drawing.Point(500, 50);
            this.btnRing.Name = "btnRing";
            this.btnRing.Size = new System.Drawing.Size(100, 50);
            this.btnRing.Text = "Ring";
            this.btnRing.UseVisualStyleBackColor = true;
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEquation);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnRing);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.ResumeLayout(false);
        }
    }

}
