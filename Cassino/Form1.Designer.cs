namespace Cassino
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btGirar = new System.Windows.Forms.Button();
            this.tmrGiro = new System.Windows.Forms.Timer(this.components);
            this.lxUltimos = new System.Windows.Forms.ListBox();
            this.chbVitorias = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbl1.Location = new System.Drawing.Point(47, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 63);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbl2.Location = new System.Drawing.Point(118, 30);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 63);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbl3.Location = new System.Drawing.Point(187, 30);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 63);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "0";
            // 
            // btGirar
            // 
            this.btGirar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGirar.BackColor = System.Drawing.Color.Red;
            this.btGirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btGirar.Location = new System.Drawing.Point(28, 120);
            this.btGirar.Name = "btGirar";
            this.btGirar.Size = new System.Drawing.Size(236, 81);
            this.btGirar.TabIndex = 3;
            this.btGirar.Text = "Girar";
            this.btGirar.UseVisualStyleBackColor = false;
            this.btGirar.Click += new System.EventHandler(this.btGirar_Click);
            // 
            // tmrGiro
            // 
            this.tmrGiro.Tick += new System.EventHandler(this.tmrGiro_Tick);
            // 
            // lxUltimos
            // 
            this.lxUltimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lxUltimos.FormattingEnabled = true;
            this.lxUltimos.ItemHeight = 46;
            this.lxUltimos.Location = new System.Drawing.Point(28, 216);
            this.lxUltimos.Name = "lxUltimos";
            this.lxUltimos.Size = new System.Drawing.Size(236, 96);
            this.lxUltimos.TabIndex = 4;
            // 
            // chbVitorias
            // 
            this.chbVitorias.AutoSize = true;
            this.chbVitorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.chbVitorias.Location = new System.Drawing.Point(28, 323);
            this.chbVitorias.Name = "chbVitorias";
            this.chbVitorias.Size = new System.Drawing.Size(201, 43);
            this.chbVitorias.TabIndex = 5;
            this.chbVitorias.Text = "Só Vitórias";
            this.chbVitorias.UseVisualStyleBackColor = true;
            this.chbVitorias.CheckedChanged += new System.EventHandler(this.chbVitorias_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 375);
            this.Controls.Add(this.chbVitorias);
            this.Controls.Add(this.lxUltimos);
            this.Controls.Add(this.btGirar);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btGirar;
        private System.Windows.Forms.Timer tmrGiro;
        private System.Windows.Forms.ListBox lxUltimos;
        private System.Windows.Forms.CheckBox chbVitorias;
    }
}

