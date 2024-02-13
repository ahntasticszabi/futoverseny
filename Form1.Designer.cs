namespace futoverseny
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMegnyit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKilep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEredmenyLista = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoeredmeny = new System.Windows.Forms.TextBox();
            this.txtEletkor = new System.Windows.Forms.TextBox();
            this.btnAdatbe = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(240, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maratoni futóverseny";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.mnuEredmenyLista});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMegnyit,
            this.mnuKilep});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // mnuMegnyit
            // 
            this.mnuMegnyit.Name = "mnuMegnyit";
            this.mnuMegnyit.Size = new System.Drawing.Size(196, 34);
            this.mnuMegnyit.Text = "Megnyitás";
            this.mnuMegnyit.Click += new System.EventHandler(this.mnuMegnyit_Click);
            // 
            // mnuKilep
            // 
            this.mnuKilep.Name = "mnuKilep";
            this.mnuKilep.Size = new System.Drawing.Size(196, 34);
            this.mnuKilep.Text = "Kilépés";
            this.mnuKilep.Click += new System.EventHandler(this.mnuKilep_Click);
            // 
            // mnuEredmenyLista
            // 
            this.mnuEredmenyLista.Enabled = false;
            this.mnuEredmenyLista.Name = "mnuEredmenyLista";
            this.mnuEredmenyLista.Size = new System.Drawing.Size(138, 29);
            this.mnuEredmenyLista.Text = "Eredménylista";
            this.mnuEredmenyLista.Click += new System.EventHandler(this.mnuEredmenyLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Résztvevők";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(92, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 463);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rajtszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ország";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Időeredmény";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Életkor";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Enabled = false;
            this.txtRajtszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRajtszam.Location = new System.Drawing.Point(605, 180);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(293, 35);
            this.txtRajtszam.TabIndex = 8;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Enabled = false;
            this.txtOrszag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrszag.Location = new System.Drawing.Point(605, 274);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(293, 35);
            this.txtOrszag.TabIndex = 9;
            // 
            // txtIdoeredmeny
            // 
            this.txtIdoeredmeny.Enabled = false;
            this.txtIdoeredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdoeredmeny.Location = new System.Drawing.Point(605, 366);
            this.txtIdoeredmeny.Name = "txtIdoeredmeny";
            this.txtIdoeredmeny.Size = new System.Drawing.Size(293, 35);
            this.txtIdoeredmeny.TabIndex = 10;
            // 
            // txtEletkor
            // 
            this.txtEletkor.Enabled = false;
            this.txtEletkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEletkor.Location = new System.Drawing.Point(605, 462);
            this.txtEletkor.Name = "txtEletkor";
            this.txtEletkor.Size = new System.Drawing.Size(293, 35);
            this.txtEletkor.TabIndex = 11;
            // 
            // btnAdatbe
            // 
            this.btnAdatbe.Enabled = false;
            this.btnAdatbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdatbe.Location = new System.Drawing.Point(92, 675);
            this.btnAdatbe.Name = "btnAdatbe";
            this.btnAdatbe.Size = new System.Drawing.Size(223, 40);
            this.btnAdatbe.TabIndex = 12;
            this.btnAdatbe.Text = "Adat beolvasás";
            this.btnAdatbe.UseVisualStyleBackColor = true;
            this.btnAdatbe.Click += new System.EventHandler(this.btnAdatbe_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKilep.Location = new System.Drawing.Point(605, 675);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(192, 40);
            this.btnKilep.TabIndex = 13;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            this.btnKilep.Click += new System.EventHandler(this.mnuKilep_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 867);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnAdatbe);
            this.Controls.Add(this.txtEletkor);
            this.Controls.Add(this.txtIdoeredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Magneto", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Futóverseny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMegnyit;
        private System.Windows.Forms.ToolStripMenuItem mnuKilep;
        private System.Windows.Forms.ToolStripMenuItem mnuEredmenyLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoeredmeny;
        private System.Windows.Forms.TextBox txtEletkor;
        private System.Windows.Forms.Button btnAdatbe;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

