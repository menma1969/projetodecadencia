namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.titulotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.generotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sinopsetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diretortxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.anotxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.duracaotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.faixaetariatxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.abrefoto = new System.Windows.Forms.OpenFileDialog();
            this.txtcaminho = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(9, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(362, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // titulotxt
            // 
            this.titulotxt.Location = new System.Drawing.Point(90, 110);
            this.titulotxt.Name = "titulotxt";
            this.titulotxt.Size = new System.Drawing.Size(267, 20);
            this.titulotxt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gênero:";
            // 
            // generotxt
            // 
            this.generotxt.Location = new System.Drawing.Point(123, 287);
            this.generotxt.Name = "generotxt";
            this.generotxt.Size = new System.Drawing.Size(88, 20);
            this.generotxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sinopse:";
            // 
            // sinopsetxt
            // 
            this.sinopsetxt.Location = new System.Drawing.Point(90, 151);
            this.sinopsetxt.Name = "sinopsetxt";
            this.sinopsetxt.Size = new System.Drawing.Size(267, 20);
            this.sinopsetxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Diretor:";
            // 
            // diretortxt
            // 
            this.diretortxt.Location = new System.Drawing.Point(90, 196);
            this.diretortxt.Name = "diretortxt";
            this.diretortxt.Size = new System.Drawing.Size(267, 20);
            this.diretortxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano do Lançamento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // anotxt
            // 
            this.anotxt.Location = new System.Drawing.Point(181, 379);
            this.anotxt.Name = "anotxt";
            this.anotxt.Size = new System.Drawing.Size(203, 20);
            this.anotxt.TabIndex = 11;
            this.anotxt.TextChanged += new System.EventHandler(this.anotxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(15, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Duração:";
            // 
            // duracaotxt
            // 
            this.duracaotxt.Location = new System.Drawing.Point(123, 333);
            this.duracaotxt.Name = "duracaotxt";
            this.duracaotxt.Size = new System.Drawing.Size(88, 20);
            this.duracaotxt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Faixa etária:";
            // 
            // faixaetariatxt
            // 
            this.faixaetariatxt.Location = new System.Drawing.Point(123, 246);
            this.faixaetariatxt.Name = "faixaetariatxt";
            this.faixaetariatxt.Size = new System.Drawing.Size(88, 20);
            this.faixaetariatxt.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(141, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 41);
            this.button3.TabIndex = 19;
            this.button3.Text = "Enviar imagem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // foto
            // 
            this.foto.Image = ((System.Drawing.Image)(resources.GetObject("foto.Image")));
            this.foto.Location = new System.Drawing.Point(429, 79);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(211, 260);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 12;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(358, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Clica duas vezes e selecione a imagem";
            // 
            // abrefoto
            // 
            this.abrefoto.FileName = "abrefoto";
            this.abrefoto.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtcaminho
            // 
            this.txtcaminho.AutoSize = true;
            this.txtcaminho.Location = new System.Drawing.Point(484, 360);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(0, 13);
            this.txtcaminho.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(523, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 41);
            this.button4.TabIndex = 22;
            this.button4.Text = "Ver filmes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 497);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtcaminho);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.duracaotxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.generotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.diretortxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.anotxt);
            this.Controls.Add(this.faixaetariatxt);
            this.Controls.Add(this.sinopsetxt);
            this.Controls.Add(this.titulotxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox titulotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox generotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sinopsetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diretortxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox anotxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox duracaotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox faixaetariatxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog abrefoto;
        private System.Windows.Forms.Label txtcaminho;
        private System.Windows.Forms.Button button4;
    }
}

