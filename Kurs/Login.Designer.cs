
namespace Kurs
{
    partial class Login
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
            this.close1 = new System.Windows.Forms.Label();
            this.loginus = new System.Windows.Forms.TextBox();
            this.passus = new System.Windows.Forms.TextBox();
            this.registerform = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // close1
            // 
            this.close1.AutoSize = true;
            this.close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close1.Location = new System.Drawing.Point(320, 0);
            this.close1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(18, 18);
            this.close1.TabIndex = 1;
            this.close1.Text = "X";
            this.close1.Click += new System.EventHandler(this.close1_Click);
            this.close1.MouseEnter += new System.EventHandler(this.close1_MouseEnter);
            this.close1.MouseLeave += new System.EventHandler(this.close1_MouseLeave);
            // 
            // loginus
            // 
            this.loginus.Location = new System.Drawing.Point(98, 152);
            this.loginus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginus.Name = "loginus";
            this.loginus.Size = new System.Drawing.Size(157, 20);
            this.loginus.TabIndex = 2;
            this.loginus.TextChanged += new System.EventHandler(this.loginus_TextChanged);
            this.loginus.Enter += new System.EventHandler(this.loginus_Enter);
            this.loginus.Leave += new System.EventHandler(this.loginus_Leave);
            // 
            // passus
            // 
            this.passus.Location = new System.Drawing.Point(98, 211);
            this.passus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passus.Name = "passus";
            this.passus.Size = new System.Drawing.Size(157, 20);
            this.passus.TabIndex = 3;
            this.passus.UseSystemPasswordChar = true;
            this.passus.Enter += new System.EventHandler(this.passus_Enter);
            this.passus.Leave += new System.EventHandler(this.passus_Leave);
            // 
            // registerform
            // 
            this.registerform.AutoSize = true;
            this.registerform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerform.Location = new System.Drawing.Point(154, 385);
            this.registerform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerform.Name = "registerform";
            this.registerform.Size = new System.Drawing.Size(52, 13);
            this.registerform.TabIndex = 4;
            this.registerform.Text = "Register  ";
            this.registerform.Click += new System.EventHandler(this.label3_Click);
            this.registerform.MouseEnter += new System.EventHandler(this.registerform_MouseEnter);
            this.registerform.MouseLeave += new System.EventHandler(this.registerform_MouseLeave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Location = new System.Drawing.Point(149, 288);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(56, 19);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Enter";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.close1);
            this.panel1.Controls.Add(this.registerform);
            this.panel1.Controls.Add(this.passus);
            this.panel1.Controls.Add(this.loginus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 407);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 406);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close1;
        private System.Windows.Forms.TextBox loginus;
        private System.Windows.Forms.TextBox passus;
        private System.Windows.Forms.Label registerform;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
    }
}