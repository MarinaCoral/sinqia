namespace Projeto02_AcessoDados
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
			this.dadosEscolaGroupBox = new System.Windows.Forms.GroupBox();
			this.incluirEscolaButton = new System.Windows.Forms.Button();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.enderecoTextBox = new System.Windows.Forms.TextBox();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.telefoneLabel = new System.Windows.Forms.Label();
			this.enderecoLabel = new System.Windows.Forms.Label();
			this.descricaoLabel = new System.Windows.Forms.Label();
			this.dadosCursoGroupBox = new System.Windows.Forms.GroupBox();
			this.escolaLabel = new System.Windows.Forms.Label();
			this.cursoComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.incluirCursoButton = new System.Windows.Forms.Button();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.cargaHorariaTextBox = new System.Windows.Forms.TextBox();
			this.descricaoCursoTextBox = new System.Windows.Forms.TextBox();
			this.precoLabel = new System.Windows.Forms.Label();
			this.cargaHorariaLabel = new System.Windows.Forms.Label();
			this.descricaoCursoLabel = new System.Windows.Forms.Label();
			this.dadosEscolaGroupBox.SuspendLayout();
			this.dadosCursoGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// dadosEscolaGroupBox
			// 
			this.dadosEscolaGroupBox.Controls.Add(this.incluirEscolaButton);
			this.dadosEscolaGroupBox.Controls.Add(this.telefoneTextBox);
			this.dadosEscolaGroupBox.Controls.Add(this.enderecoTextBox);
			this.dadosEscolaGroupBox.Controls.Add(this.descricaoTextBox);
			this.dadosEscolaGroupBox.Controls.Add(this.telefoneLabel);
			this.dadosEscolaGroupBox.Controls.Add(this.enderecoLabel);
			this.dadosEscolaGroupBox.Controls.Add(this.descricaoLabel);
			this.dadosEscolaGroupBox.Location = new System.Drawing.Point(41, 52);
			this.dadosEscolaGroupBox.Name = "dadosEscolaGroupBox";
			this.dadosEscolaGroupBox.Size = new System.Drawing.Size(304, 299);
			this.dadosEscolaGroupBox.TabIndex = 0;
			this.dadosEscolaGroupBox.TabStop = false;
			this.dadosEscolaGroupBox.Text = "Dados da Escola";
			// 
			// incluirEscolaButton
			// 
			this.incluirEscolaButton.Location = new System.Drawing.Point(111, 183);
			this.incluirEscolaButton.Name = "incluirEscolaButton";
			this.incluirEscolaButton.Size = new System.Drawing.Size(100, 23);
			this.incluirEscolaButton.TabIndex = 7;
			this.incluirEscolaButton.Text = "Incluir escola";
			this.incluirEscolaButton.UseVisualStyleBackColor = true;
			this.incluirEscolaButton.Click += new System.EventHandler(this.incluirEscolaButton_Click);
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(111, 101);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(160, 20);
			this.telefoneTextBox.TabIndex = 6;
			// 
			// enderecoTextBox
			// 
			this.enderecoTextBox.Location = new System.Drawing.Point(111, 71);
			this.enderecoTextBox.Name = "enderecoTextBox";
			this.enderecoTextBox.Size = new System.Drawing.Size(160, 20);
			this.enderecoTextBox.TabIndex = 5;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(111, 39);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(160, 20);
			this.descricaoTextBox.TabIndex = 4;
			// 
			// telefoneLabel
			// 
			this.telefoneLabel.AutoSize = true;
			this.telefoneLabel.Location = new System.Drawing.Point(20, 104);
			this.telefoneLabel.Name = "telefoneLabel";
			this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
			this.telefoneLabel.TabIndex = 2;
			this.telefoneLabel.Text = "Telefone:";
			// 
			// enderecoLabel
			// 
			this.enderecoLabel.AutoSize = true;
			this.enderecoLabel.Location = new System.Drawing.Point(20, 74);
			this.enderecoLabel.Name = "enderecoLabel";
			this.enderecoLabel.Size = new System.Drawing.Size(56, 13);
			this.enderecoLabel.TabIndex = 1;
			this.enderecoLabel.Text = "Endereço:";
			// 
			// descricaoLabel
			// 
			this.descricaoLabel.AutoSize = true;
			this.descricaoLabel.Location = new System.Drawing.Point(20, 42);
			this.descricaoLabel.Name = "descricaoLabel";
			this.descricaoLabel.Size = new System.Drawing.Size(58, 13);
			this.descricaoLabel.TabIndex = 0;
			this.descricaoLabel.Text = "Descrição:";
			// 
			// dadosCursoGroupBox
			// 
			this.dadosCursoGroupBox.Controls.Add(this.escolaLabel);
			this.dadosCursoGroupBox.Controls.Add(this.cursoComboBox);
			this.dadosCursoGroupBox.Controls.Add(this.label1);
			this.dadosCursoGroupBox.Controls.Add(this.incluirCursoButton);
			this.dadosCursoGroupBox.Controls.Add(this.precoTextBox);
			this.dadosCursoGroupBox.Controls.Add(this.cargaHorariaTextBox);
			this.dadosCursoGroupBox.Controls.Add(this.descricaoCursoTextBox);
			this.dadosCursoGroupBox.Controls.Add(this.precoLabel);
			this.dadosCursoGroupBox.Controls.Add(this.cargaHorariaLabel);
			this.dadosCursoGroupBox.Controls.Add(this.descricaoCursoLabel);
			this.dadosCursoGroupBox.Location = new System.Drawing.Point(400, 51);
			this.dadosCursoGroupBox.Name = "dadosCursoGroupBox";
			this.dadosCursoGroupBox.Size = new System.Drawing.Size(305, 299);
			this.dadosCursoGroupBox.TabIndex = 1;
			this.dadosCursoGroupBox.TabStop = false;
			this.dadosCursoGroupBox.Text = "Dados do Curso";
			// 
			// escolaLabel
			// 
			this.escolaLabel.AutoSize = true;
			this.escolaLabel.Location = new System.Drawing.Point(36, 43);
			this.escolaLabel.Name = "escolaLabel";
			this.escolaLabel.Size = new System.Drawing.Size(39, 13);
			this.escolaLabel.TabIndex = 9;
			this.escolaLabel.Text = "Escola";
			// 
			// cursoComboBox
			// 
			this.cursoComboBox.FormattingEnabled = true;
			this.cursoComboBox.Location = new System.Drawing.Point(122, 40);
			this.cursoComboBox.Name = "cursoComboBox";
			this.cursoComboBox.Size = new System.Drawing.Size(150, 21);
			this.cursoComboBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Curso:";
			// 
			// incluirCursoButton
			// 
			this.incluirCursoButton.Location = new System.Drawing.Point(135, 184);
			this.incluirCursoButton.Name = "incluirCursoButton";
			this.incluirCursoButton.Size = new System.Drawing.Size(100, 23);
			this.incluirCursoButton.TabIndex = 6;
			this.incluirCursoButton.Text = "Incluir Curso";
			this.incluirCursoButton.UseVisualStyleBackColor = true;
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(135, 156);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(100, 20);
			this.precoTextBox.TabIndex = 5;
			// 
			// cargaHorariaTextBox
			// 
			this.cargaHorariaTextBox.Location = new System.Drawing.Point(135, 129);
			this.cargaHorariaTextBox.Name = "cargaHorariaTextBox";
			this.cargaHorariaTextBox.Size = new System.Drawing.Size(100, 20);
			this.cargaHorariaTextBox.TabIndex = 4;
			// 
			// descricaoCursoTextBox
			// 
			this.descricaoCursoTextBox.Location = new System.Drawing.Point(135, 102);
			this.descricaoCursoTextBox.Name = "descricaoCursoTextBox";
			this.descricaoCursoTextBox.Size = new System.Drawing.Size(100, 20);
			this.descricaoCursoTextBox.TabIndex = 3;
			// 
			// precoLabel
			// 
			this.precoLabel.AutoSize = true;
			this.precoLabel.Location = new System.Drawing.Point(39, 159);
			this.precoLabel.Name = "precoLabel";
			this.precoLabel.Size = new System.Drawing.Size(38, 13);
			this.precoLabel.TabIndex = 2;
			this.precoLabel.Text = "Preço:";
			// 
			// cargaHorariaLabel
			// 
			this.cargaHorariaLabel.AutoSize = true;
			this.cargaHorariaLabel.Location = new System.Drawing.Point(36, 132);
			this.cargaHorariaLabel.Name = "cargaHorariaLabel";
			this.cargaHorariaLabel.Size = new System.Drawing.Size(75, 13);
			this.cargaHorariaLabel.TabIndex = 1;
			this.cargaHorariaLabel.Text = "Carga Horaria:";
			// 
			// descricaoCursoLabel
			// 
			this.descricaoCursoLabel.AutoSize = true;
			this.descricaoCursoLabel.Location = new System.Drawing.Point(36, 105);
			this.descricaoCursoLabel.Name = "descricaoCursoLabel";
			this.descricaoCursoLabel.Size = new System.Drawing.Size(58, 13);
			this.descricaoCursoLabel.TabIndex = 0;
			this.descricaoCursoLabel.Text = "Descrição:";
			this.descricaoCursoLabel.Click += new System.EventHandler(this.descricaoCursoLabel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 400);
			this.Controls.Add(this.dadosCursoGroupBox);
			this.Controls.Add(this.dadosEscolaGroupBox);
			this.Name = "Form1";
			this.Text = "Cadastro de Escolas e Cursos";
			this.dadosEscolaGroupBox.ResumeLayout(false);
			this.dadosEscolaGroupBox.PerformLayout();
			this.dadosCursoGroupBox.ResumeLayout(false);
			this.dadosCursoGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dadosEscolaGroupBox;
		private System.Windows.Forms.GroupBox dadosCursoGroupBox;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox enderecoTextBox;
		private System.Windows.Forms.TextBox descricaoTextBox;
		private System.Windows.Forms.Label telefoneLabel;
		private System.Windows.Forms.Label enderecoLabel;
		private System.Windows.Forms.Label descricaoLabel;
		private System.Windows.Forms.Button incluirEscolaButton;
		private System.Windows.Forms.Label precoLabel;
		private System.Windows.Forms.Label cargaHorariaLabel;
		private System.Windows.Forms.Label descricaoCursoLabel;
		private System.Windows.Forms.ComboBox cursoComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button incluirCursoButton;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.TextBox cargaHorariaTextBox;
		private System.Windows.Forms.TextBox descricaoCursoTextBox;
		private System.Windows.Forms.Label escolaLabel;
	}
}

