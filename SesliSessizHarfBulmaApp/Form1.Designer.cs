
namespace SesliSessizHarfBulmaApp
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
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.rbSesli = new System.Windows.Forms.RadioButton();
            this.rbSessiz = new System.Windows.Forms.RadioButton();
            this.lKelime = new System.Windows.Forms.Label();
            this.lSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime";
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(69, 13);
            this.tbKelime.Multiline = true;
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(280, 20);
            this.tbKelime.TabIndex = 1;
            this.tbKelime.TextChanged += new System.EventHandler(this.tbKelime_TextChanged);
            // 
            // rbSesli
            // 
            this.rbSesli.AutoSize = true;
            this.rbSesli.Checked = true;
            this.rbSesli.Location = new System.Drawing.Point(16, 61);
            this.rbSesli.Name = "rbSesli";
            this.rbSesli.Size = new System.Drawing.Size(59, 21);
            this.rbSesli.TabIndex = 2;
            this.rbSesli.TabStop = true;
            this.rbSesli.Text = "Sesli";
            this.rbSesli.UseVisualStyleBackColor = true;
            // 
            // rbSessiz
            // 
            this.rbSessiz.AutoSize = true;
            this.rbSessiz.Location = new System.Drawing.Point(94, 61);
            this.rbSessiz.Name = "rbSessiz";
            this.rbSessiz.Size = new System.Drawing.Size(70, 21);
            this.rbSessiz.TabIndex = 3;
            this.rbSessiz.Text = "Sessiz";
            this.rbSessiz.UseVisualStyleBackColor = true;
            // 
            // lKelime
            // 
            this.lKelime.AutoSize = true;
            this.lKelime.Location = new System.Drawing.Point(370, 16);
            this.lKelime.Name = "lKelime";
            this.lKelime.Size = new System.Drawing.Size(53, 17);
            this.lKelime.TabIndex = 5;
            this.lKelime.Text = "lKelime";
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.Location = new System.Drawing.Point(16, 155);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(51, 17);
            this.lSonuc.TabIndex = 6;
            this.lSonuc.Text = "lSonuc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.lKelime);
            this.Controls.Add(this.rbSessiz);
            this.Controls.Add(this.rbSesli);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKelime;
        private System.Windows.Forms.RadioButton rbSesli;
        private System.Windows.Forms.RadioButton rbSessiz;
        private System.Windows.Forms.Label lKelime;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Button button1;
    }
}

