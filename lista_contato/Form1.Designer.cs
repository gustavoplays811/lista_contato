namespace lista_contato
{
    partial class Form1
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
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.dtpEdi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.txbTelEdi = new System.Windows.Forms.TextBox();
            this.lblNomeCompletoEdi = new System.Windows.Forms.Label();
            this.lblTelEdi = new System.Windows.Forms.Label();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.txbEmailEdi = new System.Windows.Forms.TextBox();
            this.DgvContatos = new System.Windows.Forms.DataGridView();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.dtpCad = new System.Windows.Forms.DateTimePicker();
            this.lblDataAniver = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbTelCad = new System.Windows.Forms.TextBox();
            this.lblTelCad = new System.Windows.Forms.Label();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContatos)).BeginInit();
            this.grbApagar.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.dtpEdi);
            this.grbEditar.Controls.Add(this.label1);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.txbTelEdi);
            this.grbEditar.Controls.Add(this.lblNomeCompletoEdi);
            this.grbEditar.Controls.Add(this.lblTelEdi);
            this.grbEditar.Controls.Add(this.lblEmailEdi);
            this.grbEditar.Controls.Add(this.txbEmailEdi);
            this.grbEditar.Location = new System.Drawing.Point(12, 243);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(338, 199);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar usuário";
            // 
            // dtpEdi
            // 
            this.dtpEdi.Location = new System.Drawing.Point(104, 127);
            this.dtpEdi.Name = "dtpEdi";
            this.dtpEdi.Size = new System.Drawing.Size(200, 20);
            this.dtpEdi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data De Aniver.:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(105, 154);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(142, 39);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(105, 19);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(192, 20);
            this.txbNomeEdi.TabIndex = 8;
            this.txbNomeEdi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txbTelEdi
            // 
            this.txbTelEdi.Location = new System.Drawing.Point(105, 92);
            this.txbTelEdi.Name = "txbTelEdi";
            this.txbTelEdi.Size = new System.Drawing.Size(142, 20);
            this.txbTelEdi.TabIndex = 12;
            this.txbTelEdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNomeCompletoEdi
            // 
            this.lblNomeCompletoEdi.AutoSize = true;
            this.lblNomeCompletoEdi.Location = new System.Drawing.Point(6, 22);
            this.lblNomeCompletoEdi.Name = "lblNomeCompletoEdi";
            this.lblNomeCompletoEdi.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompletoEdi.TabIndex = 7;
            this.lblNomeCompletoEdi.Text = "Nome Completo:";
            this.lblNomeCompletoEdi.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTelEdi
            // 
            this.lblTelEdi.AutoSize = true;
            this.lblTelEdi.Location = new System.Drawing.Point(41, 92);
            this.lblTelEdi.Name = "lblTelEdi";
            this.lblTelEdi.Size = new System.Drawing.Size(28, 13);
            this.lblTelEdi.TabIndex = 11;
            this.lblTelEdi.Text = "Tel.:";
            this.lblTelEdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmailEdi
            // 
            this.lblEmailEdi.AutoSize = true;
            this.lblEmailEdi.Location = new System.Drawing.Point(41, 59);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEdi.TabIndex = 9;
            this.lblEmailEdi.Text = "Email:";
            this.lblEmailEdi.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbEmailEdi
            // 
            this.txbEmailEdi.Location = new System.Drawing.Point(105, 59);
            this.txbEmailEdi.Name = "txbEmailEdi";
            this.txbEmailEdi.Size = new System.Drawing.Size(142, 20);
            this.txbEmailEdi.TabIndex = 10;
            this.txbEmailEdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DgvContatos
            // 
            this.DgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContatos.Location = new System.Drawing.Point(356, 12);
            this.DgvContatos.Name = "DgvContatos";
            this.DgvContatos.Size = new System.Drawing.Size(432, 309);
            this.DgvContatos.TabIndex = 4;
            this.DgvContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContatos_CellClick_1);
            this.DgvContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContatos_CellContentClick_1);
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(356, 341);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(432, 101);
            this.grbApagar.TabIndex = 9;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(312, 37);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 35);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(16, 46);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(217, 16);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione um contato para apagar.";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.dtpCad);
            this.grbCadastro.Controls.Add(this.lblDataAniver);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbTelCad);
            this.grbCadastro.Controls.Add(this.lblTelCad);
            this.grbCadastro.Controls.Add(this.txbEmailCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Controls.Add(this.lblNome);
            this.grbCadastro.Location = new System.Drawing.Point(12, 12);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(338, 211);
            this.grbCadastro.TabIndex = 4;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // dtpCad
            // 
            this.dtpCad.Location = new System.Drawing.Point(104, 132);
            this.dtpCad.Name = "dtpCad";
            this.dtpCad.Size = new System.Drawing.Size(200, 20);
            this.dtpCad.TabIndex = 8;
            // 
            // lblDataAniver
            // 
            this.lblDataAniver.AutoSize = true;
            this.lblDataAniver.Location = new System.Drawing.Point(7, 135);
            this.lblDataAniver.Name = "lblDataAniver";
            this.lblDataAniver.Size = new System.Drawing.Size(84, 13);
            this.lblDataAniver.TabIndex = 7;
            this.lblDataAniver.Text = "Data de Aniver.:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(105, 166);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(142, 39);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbTelCad
            // 
            this.txbTelCad.Location = new System.Drawing.Point(105, 102);
            this.txbTelCad.Name = "txbTelCad";
            this.txbTelCad.Size = new System.Drawing.Size(142, 20);
            this.txbTelCad.TabIndex = 5;
            // 
            // lblTelCad
            // 
            this.lblTelCad.AutoSize = true;
            this.lblTelCad.Location = new System.Drawing.Point(41, 102);
            this.lblTelCad.Name = "lblTelCad";
            this.lblTelCad.Size = new System.Drawing.Size(28, 13);
            this.lblTelCad.TabIndex = 4;
            this.lblTelCad.Text = "Tel.:";
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(105, 69);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(142, 20);
            this.txbEmailCad.TabIndex = 3;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(41, 69);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Email:";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(105, 29);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(192, 20);
            this.txbNomeCad.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.DgvContatos);
            this.Controls.Add(this.grbEditar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContatos)).EndInit();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.DataGridView DgvContatos;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.TextBox txbTelEdi;
        private System.Windows.Forms.Label lblNomeCompletoEdi;
        private System.Windows.Forms.Label lblTelEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.TextBox txbEmailEdi;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbTelCad;
        private System.Windows.Forms.Label lblTelCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpCad;
        private System.Windows.Forms.Label lblDataAniver;
        private System.Windows.Forms.DateTimePicker dtpEdi;
        private System.Windows.Forms.Label label1;
    }
}

