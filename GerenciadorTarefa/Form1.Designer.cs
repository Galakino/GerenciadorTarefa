namespace GerenciadorTarefa
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.lblErro1 = new System.Windows.Forms.Label();
            this.cbxTarefaEspecifica = new System.Windows.Forms.ComboBox();
            this.cbxEscolha = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.cbxPrioridade1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxPrioridadeEditar = new System.Windows.Forms.ComboBox();
            this.lblErro2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxTarefaEditar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblErro3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGravarTarefa = new System.Windows.Forms.Button();
            this.cbxPrioridade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTarefa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnConcluida = new System.Windows.Forms.Button();
            this.lstListaConcluida = new System.Windows.Forms.ListBox();
            this.cbxTarefaConcluida = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.lblEncontrado);
            this.tabPage1.Controls.Add(this.lblErro1);
            this.tabPage1.Controls.Add(this.cbxTarefaEspecifica);
            this.tabPage1.Controls.Add(this.cbxEscolha);
            this.tabPage1.Controls.Add(this.lblBuscar);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lstLista);
            this.tabPage1.Controls.Add(this.cbxPrioridade1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar tarefas";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.AutoSize = true;
            this.lblEncontrado.BackColor = System.Drawing.Color.DarkViolet;
            this.lblEncontrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEncontrado.Location = new System.Drawing.Point(58, 183);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(75, 16);
            this.lblEncontrado.TabIndex = 20;
            this.lblEncontrado.Text = "encontrado";
            // 
            // lblErro1
            // 
            this.lblErro1.AutoSize = true;
            this.lblErro1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErro1.Location = new System.Drawing.Point(21, 365);
            this.lblErro1.Name = "lblErro1";
            this.lblErro1.Size = new System.Drawing.Size(45, 16);
            this.lblErro1.TabIndex = 19;
            this.lblErro1.Text = "<erro>";
            // 
            // cbxTarefaEspecifica
            // 
            this.cbxTarefaEspecifica.FormattingEnabled = true;
            this.cbxTarefaEspecifica.Location = new System.Drawing.Point(241, 116);
            this.cbxTarefaEspecifica.Name = "cbxTarefaEspecifica";
            this.cbxTarefaEspecifica.Size = new System.Drawing.Size(100, 24);
            this.cbxTarefaEspecifica.TabIndex = 10;
            this.cbxTarefaEspecifica.SelectedIndexChanged += new System.EventHandler(this.cbxTarefaEspecifica_SelectedIndexChanged);
            // 
            // cbxEscolha
            // 
            this.cbxEscolha.FormattingEnabled = true;
            this.cbxEscolha.Items.AddRange(new object[] {
            "Tudo",
            "Task específica",
            "Prioridade",
            "Data para fazer"});
            this.cbxEscolha.Location = new System.Drawing.Point(125, 117);
            this.cbxEscolha.Name = "cbxEscolha";
            this.cbxEscolha.Size = new System.Drawing.Size(100, 24);
            this.cbxEscolha.TabIndex = 9;
            this.cbxEscolha.SelectedIndexChanged += new System.EventHandler(this.cbxEscolha_SelectedIndexChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuscar.Location = new System.Drawing.Point(35, 119);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(75, 16);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/MM";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(241, 117);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(360, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 24);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(61, 183);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(352, 164);
            this.lstLista.TabIndex = 5;
            // 
            // cbxPrioridade1
            // 
            this.cbxPrioridade1.FormattingEnabled = true;
            this.cbxPrioridade1.Items.AddRange(new object[] {
            "Alta ",
            "Média",
            "Baixa"});
            this.cbxPrioridade1.Location = new System.Drawing.Point(241, 116);
            this.cbxPrioridade1.Name = "cbxPrioridade1";
            this.cbxPrioridade1.Size = new System.Drawing.Size(100, 24);
            this.cbxPrioridade1.TabIndex = 3;
            this.cbxPrioridade1.SelectedIndexChanged += new System.EventHandler(this.cbxPrioridade1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciador de Tarefas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.txbNome);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cbxPrioridadeEditar);
            this.tabPage2.Controls.Add(this.lblErro2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.cbxTarefaEditar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar tarefa existente";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(236, 149);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(121, 22);
            this.txbNome.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(174, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nome";
            // 
            // cbxPrioridadeEditar
            // 
            this.cbxPrioridadeEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrioridadeEditar.FormattingEnabled = true;
            this.cbxPrioridadeEditar.Location = new System.Drawing.Point(236, 192);
            this.cbxPrioridadeEditar.Name = "cbxPrioridadeEditar";
            this.cbxPrioridadeEditar.Size = new System.Drawing.Size(121, 26);
            this.cbxPrioridadeEditar.TabIndex = 27;
            // 
            // lblErro2
            // 
            this.lblErro2.AutoSize = true;
            this.lblErro2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErro2.Location = new System.Drawing.Point(31, 363);
            this.lblErro2.Name = "lblErro2";
            this.lblErro2.Size = new System.Drawing.Size(45, 16);
            this.lblErro2.TabIndex = 26;
            this.lblErro2.Text = "<erro>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(109, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Data para fazer";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(233, 240);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 24);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(160, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 46);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Editar tarefa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxTarefaEditar
            // 
            this.cbxTarefaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbxTarefaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTarefaEditar.ForeColor = System.Drawing.Color.Black;
            this.cbxTarefaEditar.FormattingEnabled = true;
            this.cbxTarefaEditar.Location = new System.Drawing.Point(236, 89);
            this.cbxTarefaEditar.Name = "cbxTarefaEditar";
            this.cbxTarefaEditar.Size = new System.Drawing.Size(121, 26);
            this.cbxTarefaEditar.TabIndex = 21;
            this.cbxTarefaEditar.SelectedIndexChanged += new System.EventHandler(this.cbxTarefaEditar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(82, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Prioridade da tarefa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(92, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Editar qual tarefa?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(154, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Editar tarefa";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.lblErro3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.btnGravarTarefa);
            this.tabPage3.Controls.Add(this.cbxPrioridade);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txbTarefa);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(472, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastrar nova tarefa";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lblErro3
            // 
            this.lblErro3.AutoSize = true;
            this.lblErro3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErro3.Location = new System.Drawing.Point(17, 357);
            this.lblErro3.Name = "lblErro3";
            this.lblErro3.Size = new System.Drawing.Size(45, 16);
            this.lblErro3.TabIndex = 18;
            this.lblErro3.Text = "<erro>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(99, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data para fazer";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // btnGravarTarefa
            // 
            this.btnGravarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarTarefa.Location = new System.Drawing.Point(164, 286);
            this.btnGravarTarefa.Name = "btnGravarTarefa";
            this.btnGravarTarefa.Size = new System.Drawing.Size(136, 49);
            this.btnGravarTarefa.TabIndex = 15;
            this.btnGravarTarefa.Text = "Gravar tarefa";
            this.btnGravarTarefa.UseVisualStyleBackColor = true;
            this.btnGravarTarefa.Click += new System.EventHandler(this.btnGravarTarefa_Click);
            // 
            // cbxPrioridade
            // 
            this.cbxPrioridade.AutoCompleteCustomSource.AddRange(new string[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbxPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrioridade.FormattingEnabled = true;
            this.cbxPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbxPrioridade.Location = new System.Drawing.Point(252, 182);
            this.cbxPrioridade.Name = "cbxPrioridade";
            this.cbxPrioridade.Size = new System.Drawing.Size(132, 28);
            this.cbxPrioridade.TabIndex = 13;
            this.cbxPrioridade.SelectedIndexChanged += new System.EventHandler(this.cbxPrioridade_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(69, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prioridade da tarefa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(53, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oque tem para fazer?";
            // 
            // txbTarefa
            // 
            this.txbTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTarefa.Location = new System.Drawing.Point(252, 132);
            this.txbTarefa.Name = "txbTarefa";
            this.txbTarefa.Size = new System.Drawing.Size(132, 27);
            this.txbTarefa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(120, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adicionar tarefa";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.btnConcluida);
            this.tabPage4.Controls.Add(this.lstListaConcluida);
            this.tabPage4.Controls.Add(this.cbxTarefaConcluida);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(472, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tarefas concluídas";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnConcluida
            // 
            this.btnConcluida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluida.Location = new System.Drawing.Point(149, 312);
            this.btnConcluida.Name = "btnConcluida";
            this.btnConcluida.Size = new System.Drawing.Size(168, 43);
            this.btnConcluida.TabIndex = 4;
            this.btnConcluida.Text = "Tarefa concluída";
            this.btnConcluida.UseVisualStyleBackColor = true;
            this.btnConcluida.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstListaConcluida
            // 
            this.lstListaConcluida.BackColor = System.Drawing.Color.Purple;
            this.lstListaConcluida.ForeColor = System.Drawing.SystemColors.Window;
            this.lstListaConcluida.FormattingEnabled = true;
            this.lstListaConcluida.ItemHeight = 16;
            this.lstListaConcluida.Location = new System.Drawing.Point(62, 149);
            this.lstListaConcluida.Name = "lstListaConcluida";
            this.lstListaConcluida.Size = new System.Drawing.Size(346, 132);
            this.lstListaConcluida.TabIndex = 3;
            // 
            // cbxTarefaConcluida
            // 
            this.cbxTarefaConcluida.FormattingEnabled = true;
            this.cbxTarefaConcluida.Location = new System.Drawing.Point(204, 97);
            this.cbxTarefaConcluida.Name = "cbxTarefaConcluida";
            this.cbxTarefaConcluida.Size = new System.Drawing.Size(113, 24);
            this.cbxTarefaConcluida.TabIndex = 2;
            this.cbxTarefaConcluida.SelectedIndexChanged += new System.EventHandler(this.cbxTarefaConcluida_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(140, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Qual? ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(90, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Concluiu alguma tarefa?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 424);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPrioridade1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxTarefaEditar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGravarTarefa;
        private System.Windows.Forms.ComboBox cbxPrioridade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblErro3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox cbxEscolha;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cbxTarefaEspecifica;
        private System.Windows.Forms.Label lblErro1;
        private System.Windows.Forms.Label lblErro2;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.ComboBox cbxPrioridadeEditar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lstListaConcluida;
        private System.Windows.Forms.ComboBox cbxTarefaConcluida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConcluida;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label12;
    }
}

