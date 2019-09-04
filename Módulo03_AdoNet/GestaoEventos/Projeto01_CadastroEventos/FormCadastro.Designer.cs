namespace Projeto01_CadastroEventos
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
			this.incluirEventoButton = new System.Windows.Forms.Button();
			this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.precoTextBox = new System.Windows.Forms.TextBox();
			this.responsavelTextBox = new System.Windows.Forms.TextBox();
			this.descricaoTextBox = new System.Windows.Forms.TextBox();
			this.precoLabel = new System.Windows.Forms.Label();
			this.dataLabel = new System.Windows.Forms.Label();
			this.responsavelLabel = new System.Windows.Forms.Label();
			this.descricaoLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.convidadosDataGridView = new System.Windows.Forms.DataGridView();
			this.buscarConvidadoButton = new System.Windows.Forms.Button();
			this.incluirConvidadoButton = new System.Windows.Forms.Button();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.telefoneLabel = new System.Windows.Forms.Label();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.nomeLabel = new System.Windows.Forms.Label();
			this.cpfTextBox = new System.Windows.Forms.TextBox();
			this.cpfLabel = new System.Windows.Forms.Label();
			this.eventoComboBox = new System.Windows.Forms.ComboBox();
			this.eventoLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluirEventoButton);
			this.groupBox1.Controls.Add(this.dataMaskedTextBox);
			this.groupBox1.Controls.Add(this.precoTextBox);
			this.groupBox1.Controls.Add(this.responsavelTextBox);
			this.groupBox1.Controls.Add(this.descricaoTextBox);
			this.groupBox1.Controls.Add(this.precoLabel);
			this.groupBox1.Controls.Add(this.dataLabel);
			this.groupBox1.Controls.Add(this.responsavelLabel);
			this.groupBox1.Controls.Add(this.descricaoLabel);
			this.groupBox1.Location = new System.Drawing.Point(19, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(354, 347);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Evento";
			// 
			// incluirEventoButton
			// 
			this.incluirEventoButton.Location = new System.Drawing.Point(17, 172);
			this.incluirEventoButton.Name = "incluirEventoButton";
			this.incluirEventoButton.Size = new System.Drawing.Size(106, 28);
			this.incluirEventoButton.TabIndex = 4;
			this.incluirEventoButton.Text = "Incluir Evento";
			this.incluirEventoButton.UseVisualStyleBackColor = true;
			this.incluirEventoButton.Click += new System.EventHandler(this.incluirEventoButton_Click);
			// 
			// dataMaskedTextBox
			// 
			this.dataMaskedTextBox.Location = new System.Drawing.Point(130, 95);
			this.dataMaskedTextBox.Mask = "00/00/0000";
			this.dataMaskedTextBox.Name = "dataMaskedTextBox";
			this.dataMaskedTextBox.Size = new System.Drawing.Size(87, 20);
			this.dataMaskedTextBox.TabIndex = 2;
			// 
			// precoTextBox
			// 
			this.precoTextBox.Location = new System.Drawing.Point(130, 130);
			this.precoTextBox.Name = "precoTextBox";
			this.precoTextBox.Size = new System.Drawing.Size(87, 20);
			this.precoTextBox.TabIndex = 3;
			// 
			// responsavelTextBox
			// 
			this.responsavelTextBox.Location = new System.Drawing.Point(130, 63);
			this.responsavelTextBox.Name = "responsavelTextBox";
			this.responsavelTextBox.Size = new System.Drawing.Size(195, 20);
			this.responsavelTextBox.TabIndex = 1;
			// 
			// descricaoTextBox
			// 
			this.descricaoTextBox.Location = new System.Drawing.Point(130, 33);
			this.descricaoTextBox.Name = "descricaoTextBox";
			this.descricaoTextBox.Size = new System.Drawing.Size(195, 20);
			this.descricaoTextBox.TabIndex = 0;
			// 
			// precoLabel
			// 
			this.precoLabel.AutoSize = true;
			this.precoLabel.Location = new System.Drawing.Point(14, 133);
			this.precoLabel.Name = "precoLabel";
			this.precoLabel.Size = new System.Drawing.Size(38, 13);
			this.precoLabel.TabIndex = 1;
			this.precoLabel.Text = "Preço:";
			// 
			// dataLabel
			// 
			this.dataLabel.AutoSize = true;
			this.dataLabel.Location = new System.Drawing.Point(14, 98);
			this.dataLabel.Name = "dataLabel";
			this.dataLabel.Size = new System.Drawing.Size(33, 13);
			this.dataLabel.TabIndex = 1;
			this.dataLabel.Text = "Data:";
			// 
			// responsavelLabel
			// 
			this.responsavelLabel.AutoSize = true;
			this.responsavelLabel.Location = new System.Drawing.Point(14, 66);
			this.responsavelLabel.Name = "responsavelLabel";
			this.responsavelLabel.Size = new System.Drawing.Size(72, 13);
			this.responsavelLabel.TabIndex = 1;
			this.responsavelLabel.Text = "Responsável:";
			// 
			// descricaoLabel
			// 
			this.descricaoLabel.AutoSize = true;
			this.descricaoLabel.Location = new System.Drawing.Point(14, 36);
			this.descricaoLabel.Name = "descricaoLabel";
			this.descricaoLabel.Size = new System.Drawing.Size(58, 13);
			this.descricaoLabel.TabIndex = 0;
			this.descricaoLabel.Text = "Descrição:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.convidadosDataGridView);
			this.groupBox2.Controls.Add(this.buscarConvidadoButton);
			this.groupBox2.Controls.Add(this.incluirConvidadoButton);
			this.groupBox2.Controls.Add(this.emailTextBox);
			this.groupBox2.Controls.Add(this.emailLabel);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.telefoneLabel);
			this.groupBox2.Controls.Add(this.nomeTextBox);
			this.groupBox2.Controls.Add(this.nomeLabel);
			this.groupBox2.Controls.Add(this.cpfTextBox);
			this.groupBox2.Controls.Add(this.cpfLabel);
			this.groupBox2.Controls.Add(this.eventoComboBox);
			this.groupBox2.Controls.Add(this.eventoLabel);
			this.groupBox2.Location = new System.Drawing.Point(396, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(383, 347);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Convidado";
			// 
			// convidadosDataGridView
			// 
			this.convidadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.convidadosDataGridView.Location = new System.Drawing.Point(26, 218);
			this.convidadosDataGridView.Name = "convidadosDataGridView";
			this.convidadosDataGridView.Size = new System.Drawing.Size(330, 111);
			this.convidadosDataGridView.TabIndex = 12;
			// 
			// buscarConvidadoButton
			// 
			this.buscarConvidadoButton.Location = new System.Drawing.Point(281, 31);
			this.buscarConvidadoButton.Name = "buscarConvidadoButton";
			this.buscarConvidadoButton.Size = new System.Drawing.Size(75, 23);
			this.buscarConvidadoButton.TabIndex = 11;
			this.buscarConvidadoButton.Text = "Buscar";
			this.buscarConvidadoButton.UseVisualStyleBackColor = true;
			this.buscarConvidadoButton.Click += new System.EventHandler(this.buscarConvidadoButton_Click);
			// 
			// incluirConvidadoButton
			// 
			this.incluirConvidadoButton.Location = new System.Drawing.Point(26, 172);
			this.incluirConvidadoButton.Name = "incluirConvidadoButton";
			this.incluirConvidadoButton.Size = new System.Drawing.Size(153, 28);
			this.incluirConvidadoButton.TabIndex = 10;
			this.incluirConvidadoButton.Text = "Incluir Convidado";
			this.incluirConvidadoButton.UseVisualStyleBackColor = true;
			this.incluirConvidadoButton.Click += new System.EventHandler(this.incluirConvidadoButton_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(114, 143);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(242, 20);
			this.emailTextBox.TabIndex = 9;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(23, 150);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(35, 13);
			this.emailLabel.TabIndex = 8;
			this.emailLabel.Text = "Email:";
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(114, 117);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(153, 20);
			this.telefoneTextBox.TabIndex = 7;
			// 
			// telefoneLabel
			// 
			this.telefoneLabel.AutoSize = true;
			this.telefoneLabel.Location = new System.Drawing.Point(23, 124);
			this.telefoneLabel.Name = "telefoneLabel";
			this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
			this.telefoneLabel.TabIndex = 6;
			this.telefoneLabel.Text = "Telefone:";
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.Location = new System.Drawing.Point(114, 91);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(242, 20);
			this.nomeTextBox.TabIndex = 5;
			// 
			// nomeLabel
			// 
			this.nomeLabel.AutoSize = true;
			this.nomeLabel.Location = new System.Drawing.Point(23, 98);
			this.nomeLabel.Name = "nomeLabel";
			this.nomeLabel.Size = new System.Drawing.Size(38, 13);
			this.nomeLabel.TabIndex = 4;
			this.nomeLabel.Text = "Nome:";
			// 
			// cpfTextBox
			// 
			this.cpfTextBox.Location = new System.Drawing.Point(114, 63);
			this.cpfTextBox.Name = "cpfTextBox";
			this.cpfTextBox.Size = new System.Drawing.Size(153, 20);
			this.cpfTextBox.TabIndex = 3;
			// 
			// cpfLabel
			// 
			this.cpfLabel.AutoSize = true;
			this.cpfLabel.Location = new System.Drawing.Point(23, 70);
			this.cpfLabel.Name = "cpfLabel";
			this.cpfLabel.Size = new System.Drawing.Size(26, 13);
			this.cpfLabel.TabIndex = 2;
			this.cpfLabel.Text = "Cpf:";
			// 
			// eventoComboBox
			// 
			this.eventoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.eventoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.eventoComboBox.FormattingEnabled = true;
			this.eventoComboBox.Location = new System.Drawing.Point(114, 33);
			this.eventoComboBox.Name = "eventoComboBox";
			this.eventoComboBox.Size = new System.Drawing.Size(153, 21);
			this.eventoComboBox.TabIndex = 1;
			// 
			// eventoLabel
			// 
			this.eventoLabel.AutoSize = true;
			this.eventoLabel.Location = new System.Drawing.Point(23, 36);
			this.eventoLabel.Name = "eventoLabel";
			this.eventoLabel.Size = new System.Drawing.Size(44, 13);
			this.eventoLabel.TabIndex = 0;
			this.eventoLabel.Text = "Evento:";
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
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button incluirEventoButton;
		private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
		private System.Windows.Forms.TextBox precoTextBox;
		private System.Windows.Forms.TextBox responsavelTextBox;
		private System.Windows.Forms.TextBox descricaoTextBox;
		private System.Windows.Forms.Label precoLabel;
		private System.Windows.Forms.Label dataLabel;
		private System.Windows.Forms.Label responsavelLabel;
		private System.Windows.Forms.Label descricaoLabel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox eventoComboBox;
		private System.Windows.Forms.Label eventoLabel;
		private System.Windows.Forms.Button incluirConvidadoButton;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.Label telefoneLabel;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.Label nomeLabel;
		private System.Windows.Forms.TextBox cpfTextBox;
		private System.Windows.Forms.Label cpfLabel;
		private System.Windows.Forms.DataGridView convidadosDataGridView;
		private System.Windows.Forms.Button buscarConvidadoButton;
	}
}

