
namespace Kurs
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.close1 = new System.Windows.Forms.Label();
            this.sinin = new System.Windows.Forms.Label();
            this.passusreg = new System.Windows.Forms.TextBox();
            this.loginusreg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.close1);
            this.panel1.Controls.Add(this.sinin);
            this.panel1.Controls.Add(this.passusreg);
            this.panel1.Controls.Add(this.loginusreg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 501);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(248, 205);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(175, 22);
            this.surname.TabIndex = 7;
            this.surname.Enter += new System.EventHandler(this.surname_Enter);
            this.surname.Leave += new System.EventHandler(this.surname_Leave);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(44, 205);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 22);
            this.name.TabIndex = 6;
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegister.Location = new System.Drawing.Point(190, 275);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 27);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // close1
            // 
            this.close1.AutoSize = true;
            this.close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close1.Location = new System.Drawing.Point(427, 0);
            this.close1.Name = "close1";
            this.close1.Size = new System.Drawing.Size(24, 24);
            this.close1.TabIndex = 1;
            this.close1.Text = "X";
            this.close1.Click += new System.EventHandler(this.close1_Click);
            this.close1.MouseEnter += new System.EventHandler(this.close1_MouseEnter);
            this.close1.MouseLeave += new System.EventHandler(this.close1_MouseLeave);
            // 
            // sinin
            // 
            this.sinin.AutoSize = true;
            this.sinin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sinin.Location = new System.Drawing.Point(206, 418);
            this.sinin.Name = "sinin";
            this.sinin.Size = new System.Drawing.Size(41, 17);
            this.sinin.TabIndex = 4;
            this.sinin.Text = "sin in";
            this.sinin.Click += new System.EventHandler(this.sinin_Click);
            this.sinin.MouseEnter += new System.EventHandler(this.sinin_MouseEnter);
            this.sinin.MouseLeave += new System.EventHandler(this.sinin_MouseLeave);
            // 
            // passusreg
            // 
            this.passusreg.Location = new System.Drawing.Point(248, 151);
            this.passusreg.Name = "passusreg";
            this.passusreg.Size = new System.Drawing.Size(175, 22);
            this.passusreg.TabIndex = 3;
            this.passusreg.UseSystemPasswordChar = true;
            this.passusreg.Enter += new System.EventHandler(this.passusreg_Enter);
            this.passusreg.Leave += new System.EventHandler(this.passusreg_Leave);
            // 
            // loginusreg
            // 
            this.loginusreg.Location = new System.Drawing.Point(44, 151);
            this.loginusreg.Name = "loginusreg";
            this.loginusreg.Size = new System.Drawing.Size(175, 22);
            this.loginusreg.TabIndex = 2;
            this.loginusreg.Enter += new System.EventHandler(this.loginusreg_Enter);
            this.loginusreg.Leave += new System.EventHandler(this.loginusreg_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label close1;
        private System.Windows.Forms.Label sinin;
        private System.Windows.Forms.TextBox passusreg;
        private System.Windows.Forms.TextBox loginusreg;
        private System.Windows.Forms.Label label1;
    }
}