namespace CalculadoraBinaria
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
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.DecimalBox = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.Button7.Location = new System.Drawing.Point(229, 92);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(61, 104);
            this.Button7.TabIndex = 23;
            this.Button7.Text = "=";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Result);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.Button6.Location = new System.Drawing.Point(172, 145);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(51, 51);
            this.Button6.TabIndex = 22;
            this.Button6.Text = "x";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Multiply);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.Button5.Location = new System.Drawing.Point(118, 145);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(51, 51);
            this.Button5.TabIndex = 21;
            this.Button5.Text = "/";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Divide);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.Button4.Location = new System.Drawing.Point(172, 92);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(51, 51);
            this.Button4.TabIndex = 20;
            this.Button4.Text = "-";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Subtract);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.Button3.Location = new System.Drawing.Point(118, 92);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(51, 51);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "+";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Sum);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.Button2.Location = new System.Drawing.Point(28, 172);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 77);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "1";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.TypeIn);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.Button1.Location = new System.Drawing.Point(28, 92);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 77);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "0";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.TypeIn);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(25, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 17);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Decimal";
            // 
            // DecimalBox
            // 
            this.DecimalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DecimalBox.Location = new System.Drawing.Point(118, 56);
            this.DecimalBox.Name = "DecimalBox";
            this.DecimalBox.ReadOnly = true;
            this.DecimalBox.Size = new System.Drawing.Size(172, 26);
            this.DecimalBox.TabIndex = 13;
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBox.Location = new System.Drawing.Point(28, 22);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(262, 29);
            this.TextBox.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(118, 202);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 47);
            this.button8.TabIndex = 24;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Clear);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(322, 286);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DecimalBox);
            this.Controls.Add(this.TextBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Binary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox DecimalBox;
        internal System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button button8;
    }
}

