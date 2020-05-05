namespace MyBrowser
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddFavorite = new System.Windows.Forms.Button();
            this.cmbFavorites = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(110, 32);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(257, 31);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Zatrzymaj";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(339, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddFavorite
            // 
            this.btnAddFavorite.Location = new System.Drawing.Point(494, 30);
            this.btnAddFavorite.Name = "btnAddFavorite";
            this.btnAddFavorite.Size = new System.Drawing.Size(128, 23);
            this.btnAddFavorite.TabIndex = 4;
            this.btnAddFavorite.Text = "Dodaj do ulubionych";
            this.btnAddFavorite.UseVisualStyleBackColor = true;
            this.btnAddFavorite.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // cmbFavorites
            // 
            this.cmbFavorites.FormattingEnabled = true;
            this.cmbFavorites.Location = new System.Drawing.Point(628, 31);
            this.cmbFavorites.Name = "cmbFavorites";
            this.cmbFavorites.Size = new System.Drawing.Size(306, 21);
            this.cmbFavorites.TabIndex = 5;
            this.cmbFavorites.SelectedIndexChanged += new System.EventHandler(this.favList_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(1076, 30);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Idź";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(29, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1122, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(29, 89);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1122, 727);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 828);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbFavorites);
            this.Controls.Add(this.btnAddFavorite);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "Form1";
            this.Text = "My Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddFavorite;
        private System.Windows.Forms.ComboBox cmbFavorites;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

