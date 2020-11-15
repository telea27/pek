namespace pek
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
            this.tab_adatok = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_stat = new System.Windows.Forms.TabPage();
            this.lbl_pekaruk = new System.Windows.Forms.Label();
            this.txtbox__nev = new System.Windows.Forms.TextBox();
            this.txtbox_ar = new System.Windows.Forms.TextBox();
            this.chckbox_laktozmentes = new System.Windows.Forms.CheckBox();
            this.btn_hozzaadas_1 = new System.Windows.Forms.Button();
            this.listbox_pekaruk = new System.Windows.Forms.ListBox();
            this.peksegek = new System.Windows.Forms.Label();
            this.txtbox_pekseg = new System.Windows.Forms.TextBox();
            this.btn_hozzaadas_2 = new System.Windows.Forms.Button();
            this.listbox_peksegek = new System.Windows.Forms.ListBox();
            this.listbox_pekaru_2 = new System.Windows.Forms.ListBox();
            this.btn_plusz = new System.Windows.Forms.Button();
            this.tab_adatok.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_adatok
            // 
            this.tab_adatok.Controls.Add(this.tabPage1);
            this.tab_adatok.Controls.Add(this.tab_stat);
            this.tab_adatok.Location = new System.Drawing.Point(4, 6);
            this.tab_adatok.Name = "tab_adatok";
            this.tab_adatok.SelectedIndex = 0;
            this.tab_adatok.Size = new System.Drawing.Size(784, 443);
            this.tab_adatok.TabIndex = 0;
            this.tab_adatok.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_plusz);
            this.tabPage1.Controls.Add(this.listbox_pekaru_2);
            this.tabPage1.Controls.Add(this.listbox_peksegek);
            this.tabPage1.Controls.Add(this.btn_hozzaadas_2);
            this.tabPage1.Controls.Add(this.txtbox_pekseg);
            this.tabPage1.Controls.Add(this.peksegek);
            this.tabPage1.Controls.Add(this.listbox_pekaruk);
            this.tabPage1.Controls.Add(this.btn_hozzaadas_1);
            this.tabPage1.Controls.Add(this.chckbox_laktozmentes);
            this.tabPage1.Controls.Add(this.txtbox_ar);
            this.tabPage1.Controls.Add(this.txtbox__nev);
            this.tabPage1.Controls.Add(this.lbl_pekaruk);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adatok";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tab_stat
            // 
            this.tab_stat.Location = new System.Drawing.Point(4, 25);
            this.tab_stat.Name = "tab_stat";
            this.tab_stat.Padding = new System.Windows.Forms.Padding(3);
            this.tab_stat.Size = new System.Drawing.Size(776, 414);
            this.tab_stat.TabIndex = 1;
            this.tab_stat.Text = "Statisztikák";
            this.tab_stat.UseVisualStyleBackColor = true;
            // 
            // lbl_pekaruk
            // 
            this.lbl_pekaruk.AutoSize = true;
            this.lbl_pekaruk.Location = new System.Drawing.Point(9, 10);
            this.lbl_pekaruk.Name = "lbl_pekaruk";
            this.lbl_pekaruk.Size = new System.Drawing.Size(60, 17);
            this.lbl_pekaruk.TabIndex = 0;
            this.lbl_pekaruk.Text = "Pékáruk";
            // 
            // txtbox__nev
            // 
            this.txtbox__nev.Location = new System.Drawing.Point(12, 39);
            this.txtbox__nev.Name = "txtbox__nev";
            this.txtbox__nev.Size = new System.Drawing.Size(100, 22);
            this.txtbox__nev.TabIndex = 1;
            this.txtbox__nev.Text = "Kérem a nevet";
            // 
            // txtbox_ar
            // 
            this.txtbox_ar.Location = new System.Drawing.Point(12, 67);
            this.txtbox_ar.Name = "txtbox_ar";
            this.txtbox_ar.Size = new System.Drawing.Size(100, 22);
            this.txtbox_ar.TabIndex = 2;
            this.txtbox_ar.Text = "Kérem az árát";
            // 
            // chckbox_laktozmentes
            // 
            this.chckbox_laktozmentes.AutoSize = true;
            this.chckbox_laktozmentes.Location = new System.Drawing.Point(12, 95);
            this.chckbox_laktozmentes.Name = "chckbox_laktozmentes";
            this.chckbox_laktozmentes.Size = new System.Drawing.Size(113, 21);
            this.chckbox_laktozmentes.TabIndex = 3;
            this.chckbox_laktozmentes.Text = "laktózmentes";
            this.chckbox_laktozmentes.UseVisualStyleBackColor = true;
            // 
            // btn_hozzaadas_1
            // 
            this.btn_hozzaadas_1.Location = new System.Drawing.Point(12, 122);
            this.btn_hozzaadas_1.Name = "btn_hozzaadas_1";
            this.btn_hozzaadas_1.Size = new System.Drawing.Size(100, 23);
            this.btn_hozzaadas_1.TabIndex = 4;
            this.btn_hozzaadas_1.Text = "Hozzáadás";
            this.btn_hozzaadas_1.UseVisualStyleBackColor = true;
            // 
            // listbox_pekaruk
            // 
            this.listbox_pekaruk.FormattingEnabled = true;
            this.listbox_pekaruk.ItemHeight = 16;
            this.listbox_pekaruk.Location = new System.Drawing.Point(225, 13);
            this.listbox_pekaruk.Name = "listbox_pekaruk";
            this.listbox_pekaruk.Size = new System.Drawing.Size(509, 132);
            this.listbox_pekaruk.TabIndex = 5;
            this.listbox_pekaruk.SelectedIndexChanged += new System.EventHandler(this.listbox_pekaruk_SelectedIndexChanged);
            // 
            // peksegek
            // 
            this.peksegek.AutoSize = true;
            this.peksegek.Location = new System.Drawing.Point(9, 166);
            this.peksegek.Name = "peksegek";
            this.peksegek.Size = new System.Drawing.Size(70, 17);
            this.peksegek.TabIndex = 6;
            this.peksegek.Text = "Pékségek";
            // 
            // txtbox_pekseg
            // 
            this.txtbox_pekseg.Location = new System.Drawing.Point(12, 196);
            this.txtbox_pekseg.Name = "txtbox_pekseg";
            this.txtbox_pekseg.Size = new System.Drawing.Size(100, 22);
            this.txtbox_pekseg.TabIndex = 7;
            // 
            // btn_hozzaadas_2
            // 
            this.btn_hozzaadas_2.Location = new System.Drawing.Point(12, 237);
            this.btn_hozzaadas_2.Name = "btn_hozzaadas_2";
            this.btn_hozzaadas_2.Size = new System.Drawing.Size(100, 23);
            this.btn_hozzaadas_2.TabIndex = 8;
            this.btn_hozzaadas_2.Text = "Hozzáadás";
            this.btn_hozzaadas_2.UseVisualStyleBackColor = true;
            // 
            // listbox_peksegek
            // 
            this.listbox_peksegek.FormattingEnabled = true;
            this.listbox_peksegek.ItemHeight = 16;
            this.listbox_peksegek.Location = new System.Drawing.Point(225, 196);
            this.listbox_peksegek.Name = "listbox_peksegek";
            this.listbox_peksegek.Size = new System.Drawing.Size(240, 148);
            this.listbox_peksegek.TabIndex = 9;
            // 
            // listbox_pekaru_2
            // 
            this.listbox_pekaru_2.FormattingEnabled = true;
            this.listbox_pekaru_2.ItemHeight = 16;
            this.listbox_pekaru_2.Location = new System.Drawing.Point(480, 196);
            this.listbox_pekaru_2.Name = "listbox_pekaru_2";
            this.listbox_pekaru_2.Size = new System.Drawing.Size(254, 84);
            this.listbox_pekaru_2.TabIndex = 10;
            // 
            // btn_plusz
            // 
            this.btn_plusz.Location = new System.Drawing.Point(591, 321);
            this.btn_plusz.Name = "btn_plusz";
            this.btn_plusz.Size = new System.Drawing.Size(31, 23);
            this.btn_plusz.TabIndex = 11;
            this.btn_plusz.Text = "+";
            this.btn_plusz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_adatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_adatok.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_adatok;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_stat;
        private System.Windows.Forms.TextBox txtbox__nev;
        private System.Windows.Forms.Label lbl_pekaruk;
        private System.Windows.Forms.Button btn_plusz;
        private System.Windows.Forms.ListBox listbox_pekaru_2;
        private System.Windows.Forms.ListBox listbox_peksegek;
        private System.Windows.Forms.Button btn_hozzaadas_2;
        private System.Windows.Forms.TextBox txtbox_pekseg;
        private System.Windows.Forms.Label peksegek;
        private System.Windows.Forms.ListBox listbox_pekaruk;
        private System.Windows.Forms.Button btn_hozzaadas_1;
        private System.Windows.Forms.CheckBox chckbox_laktozmentes;
        private System.Windows.Forms.TextBox txtbox_ar;
    }
}

