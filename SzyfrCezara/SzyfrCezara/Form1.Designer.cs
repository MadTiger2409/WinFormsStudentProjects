namespace SzyfrCezara
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTextToSecure = new System.Windows.Forms.TextBox();
            this.btnSecure = new System.Windows.Forms.Button();
            this.numMovePosition = new System.Windows.Forms.NumericUpDown();
            this.txtTextSecured = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMovePosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekst do zaszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(399, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Przesunięcie:";
            // 
            // txtTextToSecure
            // 
            this.txtTextToSecure.Location = new System.Drawing.Point(12, 32);
            this.txtTextToSecure.Multiline = true;
            this.txtTextToSecure.Name = "txtTextToSecure";
            this.txtTextToSecure.Size = new System.Drawing.Size(341, 632);
            this.txtTextToSecure.TabIndex = 3;
            // 
            // btnSecure
            // 
            this.btnSecure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSecure.Location = new System.Drawing.Point(400, 280);
            this.btnSecure.Name = "btnSecure";
            this.btnSecure.Size = new System.Drawing.Size(99, 31);
            this.btnSecure.TabIndex = 4;
            this.btnSecure.Text = "Zaszyfruj";
            this.btnSecure.UseVisualStyleBackColor = true;
            this.btnSecure.Click += new System.EventHandler(this.btnSecure_Click);
            // 
            // numMovePosition
            // 
            this.numMovePosition.Location = new System.Drawing.Point(391, 354);
            this.numMovePosition.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMovePosition.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numMovePosition.Name = "numMovePosition";
            this.numMovePosition.Size = new System.Drawing.Size(120, 20);
            this.numMovePosition.TabIndex = 5;
            // 
            // txtTextSecured
            // 
            this.txtTextSecured.Location = new System.Drawing.Point(553, 32);
            this.txtTextSecured.Multiline = true;
            this.txtTextSecured.Name = "txtTextSecured";
            this.txtTextSecured.Size = new System.Drawing.Size(341, 632);
            this.txtTextSecured.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(662, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tekst zaszyfrowany";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 670);
            this.Controls.Add(this.txtTextSecured);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMovePosition);
            this.Controls.Add(this.btnSecure);
            this.Controls.Add(this.txtTextToSecure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Szyfr Cezara";
            ((System.ComponentModel.ISupportInitialize)(this.numMovePosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTextToSecure;
        private System.Windows.Forms.Button btnSecure;
        private System.Windows.Forms.NumericUpDown numMovePosition;
        private System.Windows.Forms.TextBox txtTextSecured;
        private System.Windows.Forms.Label label3;
    }
}

