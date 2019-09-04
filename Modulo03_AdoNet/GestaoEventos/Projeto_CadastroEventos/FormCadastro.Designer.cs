namespace Projeto_CadastroEventos
{
	partial class FormCadastro
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.IncluirEventoButton = new System.Windows.Forms.Button();
			this.PrecoTextBox = new System.Windows.Forms.TextBox();
			this.ResposnavelTextBox = new System.Windows.Forms.TextBox();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.DataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.convidadosdataGridView = new System.Windows.Forms.DataGridView();
			this.buscarConvidadosButton = new System.Windows.Forms.Button();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.IncluirConvidadoButton = new System.Windows.Forms.Button();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.CpfTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cPF = new System.Windows.Forms.Label();
			this.EventoComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.IncluirEventoButton);
			this.groupBox1.Controls.Add(this.PrecoTextBox);
			this.groupBox1.Controls.Add(this.ResposnavelTextBox);
			this.groupBox1.Controls.Add(this.descricaoTextBox);
			this.groupBox1.Controls.Add(this.DataMaskedTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 426);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Evento";
			// 
			// IncluirEventoButton
			// 
			this.IncluirEventoButton.Location = new System.Drawing.Point(21, 179);
			this.IncluirEventoButton.Name = "IncluirEventoButton";
			this.IncluirEventoButton.Size = new System.Drawing.Size(122, 38);
			this.IncluirEventoButton.TabIndex = 5;
			this.IncluirEventoButton.Text = "Incluir Evento";
			this.IncluirEventoButton.UseVisualStyleBackColor = true;
			this.IncluirEventoButton.Click += new System.EventHandler(this.IncluirEventoButton_Click);
			// 
			// PrecoTextBox
			// 
			this.PrecoTextBox.Location = new System.Drawing.Point(148, 114);
			this.PrecoTextBox.Name = "PrecoTextBox";
			this.PrecoTextBox.Size = new System.Drawing.Size(86, 20);
			this.PrecoTextBox.TabIndex = 4;
			// 
			// ResposnavelTextBox
			// 
			this.ResposnavelTextBox.Location = new System.Drawing.Point(148, 60);
			this.ResposnavelTextBox.Name = "ResposnavelTextBox";
			this.ResposnavelTextBox.Size = new System.Drawing.Size(186, 20);
			this.ResposnavelTextBox.TabIndex = 2;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(148, 34);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(186, 20);
			this.descricaoTextBox.TabIndex = 1;
			// 
			// DataMaskedTextBox
			// 
			this.DataMaskedTextBox.Location = new System.Drawing.Point(148, 86);
			this.DataMaskedTextBox.Mask = "00/00/0000";
			this.DataMaskedTextBox.Name = "DataMaskedTextBox";
			this.DataMaskedTextBox.Size = new System.Drawing.Size(86, 20);
			this.DataMaskedTextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Preço:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Responsável:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descricao:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.convidadosdataGridView);
			this.groupBox2.Controls.Add(this.buscarConvidadosButton);
			this.groupBox2.Controls.Add(this.EmailTextBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.IncluirConvidadoButton);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.nomeTextBox);
			this.groupBox2.Controls.Add(this.CpfTextBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cPF);
			this.groupBox2.Controls.Add(this.EventoComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(401, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(387, 426);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Convidado";
			// 
			// convidadosdataGridView
			// 
			this.convidadosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.convidadosdataGridView.Location = new System.Drawing.Point(36, 235);
			this.convidadosdataGridView.Name = "convidadosdataGridView";
			this.convidadosdataGridView.Size = new System.Drawing.Size(308, 174);
			this.convidadosdataGridView.TabIndex = 12;
			// 
			// buscarConvidadosButton
			// 
			this.buscarConvidadosButton.Location = new System.Drawing.Point(268, 32);
			this.buscarConvidadosButton.Name = "buscarConvidadosButton";
			this.buscarConvidadosButton.Size = new System.Drawing.Size(62, 23);
			this.buscarConvidadosButton.TabIndex = 11;
			this.buscarConvidadosButton.Text = "Buscar";
			this.buscarConvidadosButton.UseVisualStyleBackColor = true;
			this.buscarConvidadosButton.Click += new System.EventHandler(this.buscarConvidadosButton_Click);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(120, 145);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(224, 20);
			this.EmailTextBox.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 148);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Email";
			// 
			// IncluirConvidadoButton
			// 
			this.IncluirConvidadoButton.Location = new System.Drawing.Point(36, 180);
			this.IncluirConvidadoButton.Name = "IncluirConvidadoButton";
			this.IncluirConvidadoButton.Size = new System.Drawing.Size(112, 38);
			this.IncluirConvidadoButton.TabIndex = 8;
			this.IncluirConvidadoButton.Text = "Incluir Convidado";
			this.IncluirConvidadoButton.UseVisualStyleBackColor = true;
			this.IncluirConvidadoButton.Click += new System.EventHandler(this.IncluirConvidadoButton_Click);
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(120, 118);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(224, 20);
			this.telefoneTextBox.TabIndex = 7;
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.Location = new System.Drawing.Point(120, 88);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(224, 20);
			this.nomeTextBox.TabIndex = 6;
			// 
			// CpfTextBox
			// 
			this.CpfTextBox.Location = new System.Drawing.Point(120, 61);
			this.CpfTextBox.Name = "CpfTextBox";
			this.CpfTextBox.Size = new System.Drawing.Size(224, 20);
			this.CpfTextBox.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(33, 118);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Telefone";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(36, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Nome";
			// 
			// cPF
			// 
			this.cPF.AutoSize = true;
			this.cPF.Location = new System.Drawing.Point(36, 64);
			this.cPF.Name = "cPF";
			this.cPF.Size = new System.Drawing.Size(23, 13);
			this.cPF.TabIndex = 2;
			this.cPF.Text = "Cpf";
			// 
			// EventoComboBox
			// 
			this.EventoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.EventoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.EventoComboBox.FormattingEnabled = true;
			this.EventoComboBox.Location = new System.Drawing.Point(120, 35);
			this.EventoComboBox.Name = "EventoComboBox";
			this.EventoComboBox.Size = new System.Drawing.Size(142, 21);
			this.EventoComboBox.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Evento";
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCadastro";
			this.Text = "Cadastro de Eventos e Convidados";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosdataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button IncluirEventoButton;
		private System.Windows.Forms.TextBox PrecoTextBox;
		private System.Windows.Forms.TextBox ResposnavelTextBox;
		private System.Windows.Forms.TextBox descricaoTextBox;
		private System.Windows.Forms.MaskedTextBox DataMaskedTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox EventoComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label cPF;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button IncluirConvidadoButton;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.TextBox CpfTextBox;
		private System.Windows.Forms.DataGridView convidadosdataGridView;
		private System.Windows.Forms.Button buscarConvidadosButton;
	}
}

