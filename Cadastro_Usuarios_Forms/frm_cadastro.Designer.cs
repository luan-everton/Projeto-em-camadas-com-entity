namespace Cadastro_Usuarios_Forms
{
    partial class frm_cadastro_processo
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_titulo_cadastro = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.tabela_cliente = new System.Windows.Forms.DataGridView();
            this.msk_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.btm_novo = new System.Windows.Forms.Button();
            this.cbx_cidade = new System.Windows.Forms.ComboBox();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.msk_celular = new System.Windows.Forms.MaskedTextBox();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.cbx_pais = new System.Windows.Forms.ComboBox();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(957, 892);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 31);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "CANCELAR";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(86, 357);
            this.txt_endereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(116, 22);
            this.txt_endereco.TabIndex = 1;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(86, 445);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(116, 22);
            this.txt_bairro.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(86, 256);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(116, 22);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(394, 256);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(116, 22);
            this.txt_idade.TabIndex = 6;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(392, 357);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(116, 22);
            this.txt_email.TabIndex = 8;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(86, 131);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(34, 16);
            this.lbl_cpf.TabIndex = 11;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(86, 215);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(47, 16);
            this.lbl_nome.TabIndex = 12;
            this.lbl_nome.Text = "NOME";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(86, 297);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(81, 16);
            this.lbl_endereco.TabIndex = 13;
            this.lbl_endereco.Text = "ENDERECO";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(89, 397);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(57, 16);
            this.lbl_bairro.TabIndex = 14;
            this.lbl_bairro.Text = "BAIRRO";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(394, 131);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(35, 16);
            this.lbl_cep.TabIndex = 15;
            this.lbl_cep.Text = "CEP";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(389, 215);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(47, 16);
            this.lbl_idade.TabIndex = 16;
            this.lbl_idade.Text = "IDADE";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(751, 312);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(43, 16);
            this.lbl_sexo.TabIndex = 17;
            this.lbl_sexo.Text = "SEXO";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(391, 312);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(47, 16);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "EMAIL";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(750, 131);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(67, 16);
            this.lbl_celular.TabIndex = 19;
            this.lbl_celular.Text = "CELULAR";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(751, 215);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(132, 16);
            this.lbl_nascimento.TabIndex = 20;
            this.lbl_nascimento.Text = "DATA_NASCIMENTO";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 758);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(87, 28);
            this.btn_salvar.TabIndex = 21;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lbl_titulo_cadastro
            // 
            this.lbl_titulo_cadastro.AutoSize = true;
            this.lbl_titulo_cadastro.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_cadastro.Location = new System.Drawing.Point(429, 45);
            this.lbl_titulo_cadastro.Name = "lbl_titulo_cadastro";
            this.lbl_titulo_cadastro.Size = new System.Drawing.Size(219, 27);
            this.lbl_titulo_cadastro.TabIndex = 22;
            this.lbl_titulo_cadastro.Text = "Cadastro de Cliente";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(965, 415);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(56, 16);
            this.lbl_cidade.TabIndex = 24;
            this.lbl_cidade.Text = "CIDADE";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.Location = new System.Drawing.Point(959, 165);
            this.btn_atualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(106, 39);
            this.btn_atualizar.TabIndex = 28;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // tabela_cliente
            // 
            this.tabela_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_cliente.Location = new System.Drawing.Point(24, 506);
            this.tabela_cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabela_cliente.Name = "tabela_cliente";
            this.tabela_cliente.ReadOnly = true;
            this.tabela_cliente.Size = new System.Drawing.Size(1182, 216);
            this.tabela_cliente.TabIndex = 27;
            this.tabela_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_cliente_CellClick);
            // 
            // msk_nascimento
            // 
            this.msk_nascimento.Location = new System.Drawing.Point(754, 256);
            this.msk_nascimento.Mask = "00/00/0000";
            this.msk_nascimento.Name = "msk_nascimento";
            this.msk_nascimento.Size = new System.Drawing.Size(100, 22);
            this.msk_nascimento.TabIndex = 33;
            // 
            // btm_novo
            // 
            this.btm_novo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_novo.Location = new System.Drawing.Point(959, 255);
            this.btm_novo.Name = "btm_novo";
            this.btm_novo.Size = new System.Drawing.Size(106, 38);
            this.btm_novo.TabIndex = 34;
            this.btm_novo.Text = "novo";
            this.btm_novo.UseVisualStyleBackColor = true;
            this.btm_novo.Click += new System.EventHandler(this.btm_novo_Click);
            // 
            // cbx_cidade
            // 
            this.cbx_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cidade.FormattingEnabled = true;
            this.cbx_cidade.Location = new System.Drawing.Point(968, 445);
            this.cbx_cidade.Name = "cbx_cidade";
            this.cbx_cidade.Size = new System.Drawing.Size(121, 24);
            this.cbx_cidade.TabIndex = 36;
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(397, 165);
            this.msk_cep.Mask = "00,000-000";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(100, 22);
            this.msk_cep.TabIndex = 37;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.cbx_sexo.Location = new System.Drawing.Point(754, 344);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(121, 24);
            this.cbx_sexo.TabIndex = 38;
            // 
            // msk_celular
            // 
            this.msk_celular.Location = new System.Drawing.Point(754, 165);
            this.msk_celular.Mask = "55(00)00000-0000";
            this.msk_celular.Name = "msk_celular";
            this.msk_celular.Size = new System.Drawing.Size(128, 22);
            this.msk_celular.TabIndex = 39;
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(86, 165);
            this.msk_cpf.Mask = "000,000,000-90";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(100, 22);
            this.msk_cpf.TabIndex = 40;
            // 
            // cbx_pais
            // 
            this.cbx_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_pais.FormattingEnabled = true;
            this.cbx_pais.Location = new System.Drawing.Point(392, 445);
            this.cbx_pais.Name = "cbx_pais";
            this.cbx_pais.Size = new System.Drawing.Size(121, 24);
            this.cbx_pais.TabIndex = 41;
            this.cbx_pais.SelectedIndexChanged += new System.EventHandler(this.cbx_pais_SelectedIndexChanged);
            this.cbx_pais.Click += new System.EventHandler(this.cbx_pais_Click);
            // 
            // cbx_estado
            // 
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Location = new System.Drawing.Point(753, 445);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(121, 24);
            this.cbx_estado.TabIndex = 42;
            this.cbx_estado.SelectedIndexChanged += new System.EventHandler(this.cbx_estado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "PAIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "ESTADO";
            // 
            // frm_cadastro_processo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 847);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.cbx_pais);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.msk_celular);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.cbx_cidade);
            this.Controls.Add(this.btm_novo);
            this.Controls.Add(this.msk_nascimento);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.tabela_cliente);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_titulo_cadastro);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_celular);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.btn_cancel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_cadastro_processo";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.frm_cadastro_processo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lbl_titulo_cadastro;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.DataGridView tabela_cliente;
        private System.Windows.Forms.MaskedTextBox msk_nascimento;
        private System.Windows.Forms.Button btm_novo;
        private System.Windows.Forms.ComboBox cbx_cidade;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.MaskedTextBox msk_celular;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.ComboBox cbx_pais;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}