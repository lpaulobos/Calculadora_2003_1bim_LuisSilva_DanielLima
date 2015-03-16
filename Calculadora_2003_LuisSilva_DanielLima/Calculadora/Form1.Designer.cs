namespace WindowsFormsApplication1
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.virg = new System.Windows.Forms.Button();
            this.fsom = new System.Windows.Forms.Button();
            this.fsub = new System.Windows.Forms.Button();
            this.fmult = new System.Windows.Forms.Button();
            this.fdiv = new System.Windows.Forms.Button();
            this.fclearall = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.visor = new System.Windows.Forms.TextBox();
            this.fclear = new System.Windows.Forms.Button();
            this.fclearlast = new System.Windows.Forms.Button();
            this.fsin = new System.Windows.Forms.Button();
            this.fpot = new System.Windows.Forms.Button();
            this.fraiz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.visor2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n8.Location = new System.Drawing.Point(80, 119);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(49, 45);
            this.n8.TabIndex = 0;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.digitou);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n9.Location = new System.Drawing.Point(135, 119);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(49, 45);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.digitou);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n7.Location = new System.Drawing.Point(25, 119);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(49, 45);
            this.n7.TabIndex = 2;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.digitou);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n6.Location = new System.Drawing.Point(135, 170);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(49, 45);
            this.n6.TabIndex = 3;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.digitou);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n5.Location = new System.Drawing.Point(80, 170);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(49, 45);
            this.n5.TabIndex = 4;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.digitou);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n4.Location = new System.Drawing.Point(25, 170);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(49, 45);
            this.n4.TabIndex = 5;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.digitou);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n1.Location = new System.Drawing.Point(25, 221);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(49, 45);
            this.n1.TabIndex = 6;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.digitou);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n2.Location = new System.Drawing.Point(80, 221);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(49, 45);
            this.n2.TabIndex = 7;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.digitou);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n3.Location = new System.Drawing.Point(135, 221);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(49, 45);
            this.n3.TabIndex = 8;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.digitou);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n0.Location = new System.Drawing.Point(25, 272);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(104, 45);
            this.n0.TabIndex = 9;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.digitou);
            // 
            // virg
            // 
            this.virg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.virg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.virg.Location = new System.Drawing.Point(135, 272);
            this.virg.Name = "virg";
            this.virg.Size = new System.Drawing.Size(49, 45);
            this.virg.TabIndex = 10;
            this.virg.Text = ",";
            this.virg.UseVisualStyleBackColor = false;
            this.virg.Click += new System.EventHandler(this.digitou);
            // 
            // fsom
            // 
            this.fsom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fsom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fsom.Location = new System.Drawing.Point(190, 221);
            this.fsom.Name = "fsom";
            this.fsom.Size = new System.Drawing.Size(49, 45);
            this.fsom.TabIndex = 14;
            this.fsom.Text = "+";
            this.fsom.UseVisualStyleBackColor = false;
            this.fsom.Click += new System.EventHandler(this.fsom_Click);
            // 
            // fsub
            // 
            this.fsub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fsub.Location = new System.Drawing.Point(190, 272);
            this.fsub.Name = "fsub";
            this.fsub.Size = new System.Drawing.Size(49, 45);
            this.fsub.TabIndex = 13;
            this.fsub.Text = "-";
            this.fsub.UseVisualStyleBackColor = false;
            this.fsub.Click += new System.EventHandler(this.fsub_Click);
            // 
            // fmult
            // 
            this.fmult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fmult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fmult.Location = new System.Drawing.Point(190, 170);
            this.fmult.Name = "fmult";
            this.fmult.Size = new System.Drawing.Size(49, 45);
            this.fmult.TabIndex = 12;
            this.fmult.Text = "*";
            this.fmult.UseVisualStyleBackColor = false;
            this.fmult.Click += new System.EventHandler(this.fmult_Click);
            // 
            // fdiv
            // 
            this.fdiv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fdiv.Location = new System.Drawing.Point(190, 119);
            this.fdiv.Name = "fdiv";
            this.fdiv.Size = new System.Drawing.Size(49, 45);
            this.fdiv.TabIndex = 11;
            this.fdiv.Text = "/";
            this.fdiv.UseVisualStyleBackColor = false;
            this.fdiv.Click += new System.EventHandler(this.fdiv_Click);
            // 
            // fclearall
            // 
            this.fclearall.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fclearall.Location = new System.Drawing.Point(135, 74);
            this.fclearall.Name = "fclearall";
            this.fclearall.Size = new System.Drawing.Size(49, 37);
            this.fclearall.TabIndex = 17;
            this.fclearall.Text = "c";
            this.fclearall.UseVisualStyleBackColor = false;
            this.fclearall.Click += new System.EventHandler(this.fclearall_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal.Location = new System.Drawing.Point(245, 170);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(49, 147);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // visor
            // 
            this.visor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visor.Location = new System.Drawing.Point(25, 42);
            this.visor.Multiline = true;
            this.visor.Name = "visor";
            this.visor.ReadOnly = true;
            this.visor.Size = new System.Drawing.Size(324, 27);
            this.visor.TabIndex = 18;
            // 
            // fclear
            // 
            this.fclear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fclear.Location = new System.Drawing.Point(25, 74);
            this.fclear.Name = "fclear";
            this.fclear.Size = new System.Drawing.Size(49, 37);
            this.fclear.TabIndex = 15;
            this.fclear.Text = "←";
            this.fclear.UseVisualStyleBackColor = false;
            this.fclear.Click += new System.EventHandler(this.fclear_Click);
            // 
            // fclearlast
            // 
            this.fclearlast.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fclearlast.Location = new System.Drawing.Point(80, 74);
            this.fclearlast.Name = "fclearlast";
            this.fclearlast.Size = new System.Drawing.Size(49, 37);
            this.fclearlast.TabIndex = 16;
            this.fclearlast.Text = "CE";
            this.fclearlast.UseVisualStyleBackColor = false;
            this.fclearlast.Click += new System.EventHandler(this.fclearlast_Click);
            // 
            // fsin
            // 
            this.fsin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fsin.Location = new System.Drawing.Point(190, 74);
            this.fsin.Name = "fsin";
            this.fsin.Size = new System.Drawing.Size(49, 37);
            this.fsin.TabIndex = 20;
            this.fsin.Text = "±";
            this.fsin.UseVisualStyleBackColor = false;
            this.fsin.Click += new System.EventHandler(this.fsin_Click);
            // 
            // fpot
            // 
            this.fpot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fpot.Location = new System.Drawing.Point(245, 119);
            this.fpot.Name = "fpot";
            this.fpot.Size = new System.Drawing.Size(49, 45);
            this.fpot.TabIndex = 21;
            this.fpot.Text = "x¹";
            this.fpot.UseVisualStyleBackColor = false;
            this.fpot.Click += new System.EventHandler(this.fpot_Click);
            // 
            // fraiz
            // 
            this.fraiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fraiz.Location = new System.Drawing.Point(245, 74);
            this.fraiz.Name = "fraiz";
            this.fraiz.Size = new System.Drawing.Size(49, 37);
            this.fraiz.TabIndex = 22;
            this.fraiz.Text = "√";
            this.fraiz.UseVisualStyleBackColor = false;
            this.fraiz.Click += new System.EventHandler(this.fraiz_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(300, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.fsen);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(300, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 45);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.fcos);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(300, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 45);
            this.button3.TabIndex = 26;
            this.button3.Text = "Tg";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ftg);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(300, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 45);
            this.button4.TabIndex = 27;
            this.button4.Text = "\\";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.fresto);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(300, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 45);
            this.button5.TabIndex = 28;
            this.button5.Text = "%";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.fporc);
            // 
            // visor2
            // 
            this.visor2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visor2.Location = new System.Drawing.Point(25, 12);
            this.visor2.Name = "visor2";
            this.visor2.ReadOnly = true;
            this.visor2.Size = new System.Drawing.Size(324, 20);
            this.visor2.TabIndex = 23;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button6.Location = new System.Drawing.Point(275, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 43);
            this.button6.TabIndex = 32;
            this.button6.Text = "Fibonacci Iterativo";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button7.Location = new System.Drawing.Point(191, 323);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 43);
            this.button7.TabIndex = 31;
            this.button7.Text = "Fibonacci Recursivo";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button8.Location = new System.Drawing.Point(109, 323);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 43);
            this.button8.TabIndex = 30;
            this.button8.Text = "Fatorial Iterativo";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button9.Location = new System.Drawing.Point(25, 323);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 43);
            this.button9.TabIndex = 29;
            this.button9.Text = "Fatorial Recursivo";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(371, 378);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.visor2);
            this.Controls.Add(this.fraiz);
            this.Controls.Add(this.fpot);
            this.Controls.Add(this.fsin);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.visor);
            this.Controls.Add(this.fclearall);
            this.Controls.Add(this.fclearlast);
            this.Controls.Add(this.fclear);
            this.Controls.Add(this.fsom);
            this.Controls.Add(this.fsub);
            this.Controls.Add(this.fmult);
            this.Controls.Add(this.fdiv);
            this.Controls.Add(this.virg);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button virg;
        private System.Windows.Forms.Button fsom;
        private System.Windows.Forms.Button fsub;
        private System.Windows.Forms.Button fmult;
        private System.Windows.Forms.Button fdiv;
        private System.Windows.Forms.Button fclearall;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.Button fclear;
        private System.Windows.Forms.Button fclearlast;
        private System.Windows.Forms.Button fsin;
        private System.Windows.Forms.Button fpot;
        private System.Windows.Forms.Button fraiz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox visor2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

