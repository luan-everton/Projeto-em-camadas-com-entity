namespace Cadastro_Usuarios_Forms
{
    partial class frm_principal
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
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_bemvindo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.tabela_precesso = new System.Windows.Forms.DataGridView();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.txt_deletar = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_id_deletar = new System.Windows.Forms.Button();
            this.menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_precesso)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(1279, 24);
            this.menu_principal.TabIndex = 0;
            this.menu_principal.Text = "menu_principal";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.cadastrarToolStripMenuItem.Text = "novo";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.usuarioToolStripMenuItem.Text = "Cliente";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // lbl_bemvindo
            // 
            this.lbl_bemvindo.AutoSize = true;
            this.lbl_bemvindo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bemvindo.Location = new System.Drawing.Point(491, 54);
            this.lbl_bemvindo.Name = "lbl_bemvindo";
            this.lbl_bemvindo.Size = new System.Drawing.Size(231, 33);
            this.lbl_bemvindo.TabIndex = 1;
            this.lbl_bemvindo.Text = "Bem vindo, User";
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(1014, 443);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(134, 33);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tabela_precesso
            // 
            this.tabela_precesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_precesso.Location = new System.Drawing.Point(11, 162);
            this.tabela_precesso.Name = "tabela_precesso";
            this.tabela_precesso.Size = new System.Drawing.Size(1229, 198);
            this.tabela_precesso.TabIndex = 3;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AutoSize = true;
            this.lbl_clientes.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes.Location = new System.Drawing.Point(12, 119);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(225, 27);
            this.lbl_clientes.TabIndex = 4;
            this.lbl_clientes.Text = "Clientes / Processos";
            // 
            // txt_deletar
            // 
            this.txt_deletar.Location = new System.Drawing.Point(46, 380);
            this.txt_deletar.Name = "txt_deletar";
            this.txt_deletar.Size = new System.Drawing.Size(47, 20);
            this.txt_deletar.TabIndex = 5;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(12, 377);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(28, 23);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "ID";
            // 
            // btn_id_deletar
            // 
            this.btn_id_deletar.Location = new System.Drawing.Point(126, 377);
            this.btn_id_deletar.Name = "btn_id_deletar";
            this.btn_id_deletar.Size = new System.Drawing.Size(75, 23);
            this.btn_id_deletar.TabIndex = 7;
            this.btn_id_deletar.Text = "DELETAR";
            this.btn_id_deletar.UseVisualStyleBackColor = true;
            this.btn_id_deletar.Click += new System.EventHandler(this.btn_id_deletar_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 488);
            this.Controls.Add(this.btn_id_deletar);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_deletar);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.tabela_precesso);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_bemvindo);
            this.Controls.Add(this.menu_principal);
            this.MainMenuStrip = this.menu_principal;
            this.Name = "frm_principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_precesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.Label lbl_bemvindo;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridView tabela_precesso;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.TextBox txt_deletar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_id_deletar;
    }
}