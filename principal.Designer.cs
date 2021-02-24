namespace WindowsFormsApp2
{
    partial class calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.result = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.bDivisão = new System.Windows.Forms.Button();
            this.bmulti = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bmenus = new System.Windows.Forms.Button();
            this.bMais = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bigual = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.bvirgula = new System.Windows.Forms.Button();
            this.lastResult = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.result.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(9, 50);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(184, 16);
            this.result.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b1.BackgroundImage")));
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Location = new System.Drawing.Point(9, 109);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(41, 39);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b2.BackgroundImage")));
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Location = new System.Drawing.Point(56, 109);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(42, 39);
            this.b2.TabIndex = 2;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bDivisão
            // 
            this.bDivisão.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDivisão.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bDivisão.BackgroundImage")));
            this.bDivisão.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bDivisão.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDivisão.Location = new System.Drawing.Point(154, 196);
            this.bDivisão.Name = "bDivisão";
            this.bDivisão.Size = new System.Drawing.Size(41, 39);
            this.bDivisão.TabIndex = 3;
            this.bDivisão.UseVisualStyleBackColor = false;
            this.bDivisão.Click += new System.EventHandler(this.button3_Click);
            // 
            // bmulti
            // 
            this.bmulti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bmulti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bmulti.BackgroundImage")));
            this.bmulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bmulti.FlatAppearance.BorderSize = 0;
            this.bmulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmulti.Location = new System.Drawing.Point(154, 239);
            this.bmulti.Name = "bmulti";
            this.bmulti.Size = new System.Drawing.Size(41, 39);
            this.bmulti.TabIndex = 4;
            this.bmulti.UseVisualStyleBackColor = false;
            this.bmulti.Click += new System.EventHandler(this.button4_Click);
            // 
            // b6
            // 
            this.b6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b6.BackgroundImage")));
            this.b6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b6.FlatAppearance.BorderSize = 0;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Location = new System.Drawing.Point(104, 154);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(42, 42);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.button5_Click);
            // 
            // bmenus
            // 
            this.bmenus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bmenus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bmenus.BackgroundImage")));
            this.bmenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bmenus.FlatAppearance.BorderSize = 0;
            this.bmenus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmenus.Location = new System.Drawing.Point(154, 155);
            this.bmenus.Name = "bmenus";
            this.bmenus.Size = new System.Drawing.Size(41, 39);
            this.bmenus.TabIndex = 6;
            this.bmenus.UseVisualStyleBackColor = false;
            this.bmenus.Click += new System.EventHandler(this.button6_Click);
            // 
            // bMais
            // 
            this.bMais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bMais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bMais.BackgroundImage")));
            this.bMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMais.FlatAppearance.BorderSize = 0;
            this.bMais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMais.Location = new System.Drawing.Point(154, 112);
            this.bMais.Name = "bMais";
            this.bMais.Size = new System.Drawing.Size(41, 39);
            this.bMais.TabIndex = 7;
            this.bMais.UseVisualStyleBackColor = false;
            this.bMais.Click += new System.EventHandler(this.button7_Click);
            // 
            // b3
            // 
            this.b3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b3.BackgroundImage")));
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Location = new System.Drawing.Point(104, 109);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(44, 39);
            this.b3.TabIndex = 8;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button8_Click);
            // 
            // b5
            // 
            this.b5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b5.BackgroundImage")));
            this.b5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b5.FlatAppearance.BorderSize = 0;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Location = new System.Drawing.Point(56, 152);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(42, 42);
            this.b5.TabIndex = 9;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.button9_Click);
            // 
            // b4
            // 
            this.b4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b4.BackgroundImage")));
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Location = new System.Drawing.Point(9, 151);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(41, 42);
            this.b4.TabIndex = 10;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button10_Click);
            // 
            // b7
            // 
            this.b7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b7.BackgroundImage")));
            this.b7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b7.FlatAppearance.BorderSize = 0;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Location = new System.Drawing.Point(9, 199);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(41, 39);
            this.b7.TabIndex = 11;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.button11_Click);
            // 
            // b8
            // 
            this.b8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b8.BackgroundImage")));
            this.b8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b8.FlatAppearance.BorderSize = 0;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Location = new System.Drawing.Point(56, 200);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(42, 39);
            this.b8.TabIndex = 12;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.button12_Click);
            // 
            // b9
            // 
            this.b9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b9.BackgroundImage")));
            this.b9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b9.FlatAppearance.BorderSize = 0;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Location = new System.Drawing.Point(104, 200);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(42, 39);
            this.b9.TabIndex = 13;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.button13_Click);
            // 
            // bigual
            // 
            this.bigual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bigual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bigual.BackgroundImage")));
            this.bigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bigual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bigual.Location = new System.Drawing.Point(104, 245);
            this.bigual.Name = "bigual";
            this.bigual.Size = new System.Drawing.Size(42, 34);
            this.bigual.TabIndex = 14;
            this.bigual.UseVisualStyleBackColor = false;
            this.bigual.Click += new System.EventHandler(this.button14_Click);
            // 
            // b0
            // 
            this.b0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b0.BackgroundImage")));
            this.b0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b0.FlatAppearance.BorderSize = 0;
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b0.Location = new System.Drawing.Point(56, 245);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(42, 34);
            this.b0.TabIndex = 15;
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(152, 82);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(41, 21);
            this.button16.TabIndex = 16;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Location = new System.Drawing.Point(104, 82);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(34, 21);
            this.button17.TabIndex = 17;
            this.button17.Text = "c";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // bvirgula
            // 
            this.bvirgula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bvirgula.BackgroundImage")));
            this.bvirgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bvirgula.Cursor = System.Windows.Forms.Cursors.Default;
            this.bvirgula.FlatAppearance.BorderSize = 0;
            this.bvirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bvirgula.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvirgula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bvirgula.Location = new System.Drawing.Point(12, 245);
            this.bvirgula.Name = "bvirgula";
            this.bvirgula.Size = new System.Drawing.Size(38, 33);
            this.bvirgula.TabIndex = 18;
            this.bvirgula.Text = ",";
            this.bvirgula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bvirgula.UseVisualStyleBackColor = true;
            this.bvirgula.Click += new System.EventHandler(this.button18_Click);
            // 
            // lastResult
            // 
            this.lastResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lastResult.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastResult.Location = new System.Drawing.Point(9, 32);
            this.lastResult.Multiline = true;
            this.lastResult.Name = "lastResult";
            this.lastResult.ReadOnly = true;
            this.lastResult.Size = new System.Drawing.Size(184, 18);
            this.lastResult.TabIndex = 19;
            this.lastResult.TextChanged += new System.EventHandler(this.lastResult_TextChanged);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Location = new System.Drawing.Point(165, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 23);
            this.close.TabIndex = 20;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(204, 297);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lastResult);
            this.Controls.Add(this.bvirgula);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bigual);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.bMais);
            this.Controls.Add(this.bmenus);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.bmulti);
            this.Controls.Add(this.bDivisão);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button bDivisão;
        private System.Windows.Forms.Button bmulti;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bmenus;
        private System.Windows.Forms.Button bMais;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bigual;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button bvirgula;
        private System.Windows.Forms.TextBox lastResult;
        private System.Windows.Forms.Button close;
    }
}

