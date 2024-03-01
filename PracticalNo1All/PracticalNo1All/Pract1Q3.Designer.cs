
namespace PracticalNo1All
{
    partial class Pract1Q3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKPH = new System.Windows.Forms.Button();
            this.btnMPH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Wind Speed in Knots";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(409, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 34);
            this.textBox1.TabIndex = 6;
            // 
            // btnKPH
            // 
            this.btnKPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKPH.Location = new System.Drawing.Point(409, 231);
            this.btnKPH.Name = "btnKPH";
            this.btnKPH.Size = new System.Drawing.Size(159, 46);
            this.btnKPH.TabIndex = 5;
            this.btnKPH.Text = "Kph";
            this.btnKPH.UseVisualStyleBackColor = true;
            this.btnKPH.Click += new System.EventHandler(this.btnKPH_Click);
            // 
            // btnMPH
            // 
            this.btnMPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPH.Location = new System.Drawing.Point(146, 231);
            this.btnMPH.Name = "btnMPH";
            this.btnMPH.Size = new System.Drawing.Size(151, 46);
            this.btnMPH.TabIndex = 4;
            this.btnMPH.Text = "Mph";
            this.btnMPH.UseVisualStyleBackColor = true;
            this.btnMPH.Click += new System.EventHandler(this.btnMPH_Click);
            // 
            // Pract1Q3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKPH);
            this.Controls.Add(this.btnMPH);
            this.Name = "Pract1Q3";
            this.Text = "Pract1Q3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKPH;
        private System.Windows.Forms.Button btnMPH;
    }
}