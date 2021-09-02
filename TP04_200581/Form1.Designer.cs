namespace TP04_200581
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.GrpBoxPlayers = new System.Windows.Forms.GroupBox();
            this.TxtNomePlayer2 = new System.Windows.Forms.TextBox();
            this.LblPlayer2 = new System.Windows.Forms.Label();
            this.TxtNomePlayer1 = new System.Windows.Forms.TextBox();
            this.LblPlayer1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblVezDoJogador = new System.Windows.Forms.Label();
            this.PnlJogoDaVelha = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpBoxPlacar = new System.Windows.Forms.GroupBox();
            this.LblMostrarNomePlayer2 = new System.Windows.Forms.Label();
            this.LblMostrarNomePlayer1 = new System.Windows.Forms.Label();
            this.LblContagemPlayer2 = new System.Windows.Forms.Label();
            this.LblPlacarPlayer2 = new System.Windows.Forms.Label();
            this.LblContagemPlayer1 = new System.Windows.Forms.Label();
            this.LblPlacarPlayer1 = new System.Windows.Forms.Label();
            this.BtnReiniciarJogo = new System.Windows.Forms.Button();
            this.BtnEmpate = new System.Windows.Forms.Button();
            this.GrpBoxPlayers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PnlJogoDaVelha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrpBoxPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxPlayers
            // 
            this.GrpBoxPlayers.BackColor = System.Drawing.Color.Transparent;
            this.GrpBoxPlayers.Controls.Add(this.TxtNomePlayer2);
            this.GrpBoxPlayers.Controls.Add(this.LblPlayer2);
            this.GrpBoxPlayers.Controls.Add(this.TxtNomePlayer1);
            this.GrpBoxPlayers.Controls.Add(this.LblPlayer1);
            this.GrpBoxPlayers.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxPlayers.Location = new System.Drawing.Point(4, 6);
            this.GrpBoxPlayers.Name = "GrpBoxPlayers";
            this.GrpBoxPlayers.Size = new System.Drawing.Size(337, 80);
            this.GrpBoxPlayers.TabIndex = 0;
            this.GrpBoxPlayers.TabStop = false;
            this.GrpBoxPlayers.Text = "Players";
            // 
            // TxtNomePlayer2
            // 
            this.TxtNomePlayer2.Location = new System.Drawing.Point(199, 46);
            this.TxtNomePlayer2.Name = "TxtNomePlayer2";
            this.TxtNomePlayer2.Size = new System.Drawing.Size(85, 21);
            this.TxtNomePlayer2.TabIndex = 3;
            this.TxtNomePlayer2.TextChanged += new System.EventHandler(this.TxtNomePlayer2_TextChanged);
            // 
            // LblPlayer2
            // 
            this.LblPlayer2.AutoSize = true;
            this.LblPlayer2.Location = new System.Drawing.Point(177, 30);
            this.LblPlayer2.Name = "LblPlayer2";
            this.LblPlayer2.Size = new System.Drawing.Size(81, 15);
            this.LblPlayer2.TabIndex = 2;
            this.LblPlayer2.Text = "Player 2 ( O ):";
            this.LblPlayer2.Click += new System.EventHandler(this.LblPlayer2_Click);
            // 
            // TxtNomePlayer1
            // 
            this.TxtNomePlayer1.Location = new System.Drawing.Point(42, 46);
            this.TxtNomePlayer1.Name = "TxtNomePlayer1";
            this.TxtNomePlayer1.Size = new System.Drawing.Size(85, 21);
            this.TxtNomePlayer1.TabIndex = 1;
            this.TxtNomePlayer1.TextChanged += new System.EventHandler(this.TxtNomePlayer1_TextChanged);
            // 
            // LblPlayer1
            // 
            this.LblPlayer1.AutoSize = true;
            this.LblPlayer1.Location = new System.Drawing.Point(19, 30);
            this.LblPlayer1.Name = "LblPlayer1";
            this.LblPlayer1.Size = new System.Drawing.Size(82, 15);
            this.LblPlayer1.TabIndex = 0;
            this.LblPlayer1.Text = "Player 1 ( X ) :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblVezDoJogador);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quem Joga ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vez do(a) Player : ";
            // 
            // LblVezDoJogador
            // 
            this.LblVezDoJogador.AutoSize = true;
            this.LblVezDoJogador.Location = new System.Drawing.Point(177, 25);
            this.LblVezDoJogador.Name = "LblVezDoJogador";
            this.LblVezDoJogador.Size = new System.Drawing.Size(0, 15);
            this.LblVezDoJogador.TabIndex = 2;
            this.LblVezDoJogador.Click += new System.EventHandler(this.LblVezDoJogador_Click);
            // 
            // PnlJogoDaVelha
            // 
            this.PnlJogoDaVelha.BackColor = System.Drawing.Color.Transparent;
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox9);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox8);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox7);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox6);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox5);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox4);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox3);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox2);
            this.PnlJogoDaVelha.Controls.Add(this.pictureBox1);
            this.PnlJogoDaVelha.Location = new System.Drawing.Point(64, 150);
            this.PnlJogoDaVelha.Name = "PnlJogoDaVelha";
            this.PnlJogoDaVelha.Size = new System.Drawing.Size(212, 182);
            this.PnlJogoDaVelha.TabIndex = 3;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Location = new System.Drawing.Point(162, 130);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(35, 40);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(92, 130);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 40);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(21, 130);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 40);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(162, 75);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 40);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(92, 75);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 40);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(21, 75);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 40);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(162, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 40);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(92, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 40);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GrpBoxPlacar
            // 
            this.GrpBoxPlacar.BackColor = System.Drawing.Color.Transparent;
            this.GrpBoxPlacar.Controls.Add(this.LblMostrarNomePlayer2);
            this.GrpBoxPlacar.Controls.Add(this.LblMostrarNomePlayer1);
            this.GrpBoxPlacar.Controls.Add(this.LblContagemPlayer2);
            this.GrpBoxPlacar.Controls.Add(this.LblPlacarPlayer2);
            this.GrpBoxPlacar.Controls.Add(this.LblContagemPlayer1);
            this.GrpBoxPlacar.Controls.Add(this.LblPlacarPlayer1);
            this.GrpBoxPlacar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxPlacar.Location = new System.Drawing.Point(8, 338);
            this.GrpBoxPlacar.Name = "GrpBoxPlacar";
            this.GrpBoxPlacar.Size = new System.Drawing.Size(333, 72);
            this.GrpBoxPlacar.TabIndex = 4;
            this.GrpBoxPlacar.TabStop = false;
            this.GrpBoxPlacar.Text = "Placar";
            // 
            // LblMostrarNomePlayer2
            // 
            this.LblMostrarNomePlayer2.AutoSize = true;
            this.LblMostrarNomePlayer2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarNomePlayer2.Location = new System.Drawing.Point(253, 26);
            this.LblMostrarNomePlayer2.Name = "LblMostrarNomePlayer2";
            this.LblMostrarNomePlayer2.Size = new System.Drawing.Size(0, 17);
            this.LblMostrarNomePlayer2.TabIndex = 5;
            // 
            // LblMostrarNomePlayer1
            // 
            this.LblMostrarNomePlayer1.AutoSize = true;
            this.LblMostrarNomePlayer1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrarNomePlayer1.Location = new System.Drawing.Point(84, 26);
            this.LblMostrarNomePlayer1.Name = "LblMostrarNomePlayer1";
            this.LblMostrarNomePlayer1.Size = new System.Drawing.Size(0, 17);
            this.LblMostrarNomePlayer1.TabIndex = 4;
            // 
            // LblContagemPlayer2
            // 
            this.LblContagemPlayer2.AutoSize = true;
            this.LblContagemPlayer2.Location = new System.Drawing.Point(296, 40);
            this.LblContagemPlayer2.Name = "LblContagemPlayer2";
            this.LblContagemPlayer2.Size = new System.Drawing.Size(13, 15);
            this.LblContagemPlayer2.TabIndex = 3;
            this.LblContagemPlayer2.Text = "0";
            // 
            // LblPlacarPlayer2
            // 
            this.LblPlacarPlayer2.AutoSize = true;
            this.LblPlacarPlayer2.Location = new System.Drawing.Point(173, 26);
            this.LblPlacarPlayer2.Name = "LblPlacarPlayer2";
            this.LblPlacarPlayer2.Size = new System.Drawing.Size(84, 15);
            this.LblPlacarPlayer2.TabIndex = 2;
            this.LblPlacarPlayer2.Text = "Player 2 ( O ) :";
            this.LblPlacarPlayer2.Click += new System.EventHandler(this.LblPlacarPlayer2_Click);
            // 
            // LblContagemPlayer1
            // 
            this.LblContagemPlayer1.AutoSize = true;
            this.LblContagemPlayer1.Location = new System.Drawing.Point(129, 40);
            this.LblContagemPlayer1.Name = "LblContagemPlayer1";
            this.LblContagemPlayer1.Size = new System.Drawing.Size(13, 15);
            this.LblContagemPlayer1.TabIndex = 1;
            this.LblContagemPlayer1.Text = "0";
            // 
            // LblPlacarPlayer1
            // 
            this.LblPlacarPlayer1.AutoSize = true;
            this.LblPlacarPlayer1.Location = new System.Drawing.Point(6, 26);
            this.LblPlacarPlayer1.Name = "LblPlacarPlayer1";
            this.LblPlacarPlayer1.Size = new System.Drawing.Size(82, 15);
            this.LblPlacarPlayer1.TabIndex = 0;
            this.LblPlacarPlayer1.Text = "Player 1 ( X ) :";
            this.LblPlacarPlayer1.Click += new System.EventHandler(this.LblPlacarPlayer1_Click);
            // 
            // BtnReiniciarJogo
            // 
            this.BtnReiniciarJogo.BackColor = System.Drawing.Color.Transparent;
            this.BtnReiniciarJogo.BackgroundImage = global::TP04_200581.Properties.Resources.depositphotos_8480123_stock_photo_blank_green_chalkboard4;
            this.BtnReiniciarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReiniciarJogo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReiniciarJogo.Location = new System.Drawing.Point(6, 428);
            this.BtnReiniciarJogo.Name = "BtnReiniciarJogo";
            this.BtnReiniciarJogo.Size = new System.Drawing.Size(334, 27);
            this.BtnReiniciarJogo.TabIndex = 5;
            this.BtnReiniciarJogo.Text = "Reiniciar o Jogo ";
            this.BtnReiniciarJogo.UseVisualStyleBackColor = false;
            this.BtnReiniciarJogo.Click += new System.EventHandler(this.BtnReiniciarJogo_Click);
            // 
            // BtnEmpate
            // 
            this.BtnEmpate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnEmpate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpate.Location = new System.Drawing.Point(282, 312);
            this.BtnEmpate.Name = "BtnEmpate";
            this.BtnEmpate.Size = new System.Drawing.Size(53, 29);
            this.BtnEmpate.TabIndex = 6;
            this.BtnEmpate.Text = "Empate";
            this.BtnEmpate.UseVisualStyleBackColor = false;
            this.BtnEmpate.Click += new System.EventHandler(this.BtnEmpate_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP04_200581.Properties.Resources.depositphotos_8480123_stock_photo_blank_green_chalkboard;
            this.ClientSize = new System.Drawing.Size(345, 457);
            this.Controls.Add(this.BtnEmpate);
            this.Controls.Add(this.BtnReiniciarJogo);
            this.Controls.Add(this.GrpBoxPlacar);
            this.Controls.Add(this.PnlJogoDaVelha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpBoxPlayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Jogo da Velha";
            this.GrpBoxPlayers.ResumeLayout(false);
            this.GrpBoxPlayers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PnlJogoDaVelha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrpBoxPlacar.ResumeLayout(false);
            this.GrpBoxPlacar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxPlayers;
        private System.Windows.Forms.TextBox TxtNomePlayer2;
        private System.Windows.Forms.Label LblPlayer2;
        private System.Windows.Forms.TextBox TxtNomePlayer1;
        private System.Windows.Forms.Label LblPlayer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PnlJogoDaVelha;
        private System.Windows.Forms.GroupBox GrpBoxPlacar;
        private System.Windows.Forms.Label LblContagemPlayer2;
        private System.Windows.Forms.Label LblPlacarPlayer2;
        private System.Windows.Forms.Label LblContagemPlayer1;
        private System.Windows.Forms.Label LblPlacarPlayer1;
        private System.Windows.Forms.Button BtnReiniciarJogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblMostrarNomePlayer1;
        private System.Windows.Forms.Label LblMostrarNomePlayer2;
        private System.Windows.Forms.Label LblVezDoJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnEmpate;
    }
}

