
namespace PracticalNo1All
{
    partial class Pract1No4
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
            this.derClass = new System.Windows.Forms.Button();
            this.baseClass = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // derClass
            // 
            this.derClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derClass.Location = new System.Drawing.Point(65, 45);
            this.derClass.Name = "derClass";
            this.derClass.Size = new System.Drawing.Size(251, 59);
            this.derClass.TabIndex = 0;
            this.derClass.Text = "Dervied Class";
            this.derClass.UseVisualStyleBackColor = true;
            this.derClass.Click += new System.EventHandler(this.derClass_Click);
            // 
            // baseClass
            // 
            this.baseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseClass.Location = new System.Drawing.Point(65, 103);
            this.baseClass.Name = "baseClass";
            this.baseClass.Size = new System.Drawing.Size(251, 59);
            this.baseClass.TabIndex = 1;
            this.baseClass.Text = "Base Class";
            this.baseClass.UseVisualStyleBackColor = true;
            this.baseClass.Click += new System.EventHandler(this.baseClass_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(139, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Pract1No4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 270);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.baseClass);
            this.Controls.Add(this.derClass);
            this.Name = "Pract1No4";
            this.Text = "Pract1No4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button derClass;
        private System.Windows.Forms.Button baseClass;
        private System.Windows.Forms.Button btnClose;
    }
}