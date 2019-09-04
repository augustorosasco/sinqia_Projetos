namespace GestaoEscola
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.incluirEscolaButton = new System.Windows.Forms.Button();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.enderecoTextBox = new System.Windows.Forms.TextBox();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.incluirCursoButton = new System.Windows.Forms.Button();
			this.PrecoTextBox = new System.Windows.Forms.TextBox();
			this.CargaHorariaTextBox = new System.Windows.Forms.TextBox();
			this.codigoEscolaComboBox = new System.Windows.Forms.ComboBox();
			this.CursoTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buscarCursoButton = new System.Windows.Forms.Button();
			this.CursoGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CursoGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluirEscolaButton);
			this.groupBox1.Controls.Add(this.telefoneTextBox);
			this.groupBox1.Controls.Add(this.enderecoTextBox);
			this.groupBox1.Controls.Add(this.nomeTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 426);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Escolas";
			// 
			// incluirEscolaButton
			// 
			this.incluirEscolaButton.Location = new System.Drawing.Point(21, 132);
			this.incluirEscolaButton.Name = "incluirEscolaButton";
			this.incluirEscolaButton.Size = new System.Drawing.Size(334, 23);
			this.incluirEscolaButton.TabIndex = 6;
			this.incluirEscolaButton.Text = "Incluir Escola";
			this.incluirEscolaButton.UseVisualStyleBackColor = true;
			this.incluirEscolaButton.Click += new System.EventHandler(this.incluirEscolaButton_Click);
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(102, 95);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(253, 20);
			this.telefoneTextBox.TabIndex = 5;
			// 
			// enderecoTextBox
			// 
			this.enderecoTextBox.Location = new System.Drawing.Point(102, 69);
			this.enderecoTextBox.Name = "enderecoTextBox";
			this.enderecoTextBox.Size = new System.Drawing.Size(253, 20);
			this.enderecoTextBox.TabIndex = 4;
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.Location = new System.Drawing.Point(102, 36);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(253, 20);
			this.nomeTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefone";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Endereço";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.CursoGridView);
			this.groupBox2.Controls.Add(this.buscarCursoButton);
			this.groupBox2.Controls.Add(this.incluirCursoButton);
			this.groupBox2.Controls.Add(this.PrecoTextBox);
			this.groupBox2.Controls.Add(this.CargaHorariaTextBox);
			this.groupBox2.Controls.Add(this.codigoEscolaComboBox);
			this.groupBox2.Controls.Add(this.CursoTextBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(405, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(383, 426);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cursos";
			// 
			// incluirCursoButton
			// 
			this.incluirCursoButton.Location = new System.Drawing.Point(25, 158);
			this.incluirCursoButton.Name = "incluirCursoButton";
			this.incluirCursoButton.Size = new System.Drawing.Size(326, 23);
			this.incluirCursoButton.TabIndex = 9;
			this.incluirCursoButton.Text = "Incluir Curso";
			this.incluirCursoButton.UseVisualStyleBackColor = true;
			this.incluirCursoButton.Click += new System.EventHandler(this.incluirCursoButton_Click);
			// 
			// PrecoTextBox
			// 
			this.PrecoTextBox.Location = new System.Drawing.Point(118, 125);
			this.PrecoTextBox.Name = "PrecoTextBox";
			this.PrecoTextBox.Size = new System.Drawing.Size(233, 20);
			this.PrecoTextBox.TabIndex = 8;
			// 
			// CargaHorariaTextBox
			// 
			this.CargaHorariaTextBox.Location = new System.Drawing.Point(118, 92);
			this.CargaHorariaTextBox.Name = "CargaHorariaTextBox";
			this.CargaHorariaTextBox.Size = new System.Drawing.Size(233, 20);
			this.CargaHorariaTextBox.TabIndex = 7;
			// 
			// codigoEscolaComboBox
			// 
			this.codigoEscolaComboBox.FormattingEnabled = true;
			this.codigoEscolaComboBox.Location = new System.Drawing.Point(118, 32);
			this.codigoEscolaComboBox.Name = "codigoEscolaComboBox";
			this.codigoEscolaComboBox.Size = new System.Drawing.Size(146, 21);
			this.codigoEscolaComboBox.TabIndex = 6;
			// 
			// CursoTextBox
			// 
			this.CursoTextBox.Location = new System.Drawing.Point(118, 61);
			this.CursoTextBox.Name = "CursoTextBox";
			this.CursoTextBox.Size = new System.Drawing.Size(233, 20);
			this.CursoTextBox.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 125);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Preço";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Carga Horária";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Código da Escola";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Curso";
			// 
			// buscarCursoButton
			// 
			this.buscarCursoButton.Location = new System.Drawing.Point(270, 31);
			this.buscarCursoButton.Name = "buscarCursoButton";
			this.buscarCursoButton.Size = new System.Drawing.Size(75, 22);
			this.buscarCursoButton.TabIndex = 10;
			this.buscarCursoButton.Text = "Buscar";
			this.buscarCursoButton.UseVisualStyleBackColor = true;
			this.buscarCursoButton.Click += new System.EventHandler(this.buscarCursoButton_Click);
			// 
			// CursoGridView
			// 
			this.CursoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CursoGridView.Location = new System.Drawing.Point(25, 208);
			this.CursoGridView.Name = "CursoGridView";
			this.CursoGridView.Size = new System.Drawing.Size(326, 179);
			this.CursoGridView.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 454);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Cadastro de Escolas e Cursos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CursoGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button incluirEscolaButton;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox enderecoTextBox;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox CursoTextBox;
		private System.Windows.Forms.ComboBox codigoEscolaComboBox;
		private System.Windows.Forms.TextBox PrecoTextBox;
		private System.Windows.Forms.TextBox CargaHorariaTextBox;
		private System.Windows.Forms.Button incluirCursoButton;
		private System.Windows.Forms.DataGridView CursoGridView;
		private System.Windows.Forms.Button buscarCursoButton;
	}
}

