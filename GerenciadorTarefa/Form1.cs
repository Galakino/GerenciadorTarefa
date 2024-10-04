using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorTarefa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGravarTarefa_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                ("server=127.0.0.1;userid=root;password=root;database=taskcsharp");

                conn.Open();

                string dataCadastro = DateTime.Now.ToString("dd/MM/yyyy");
                string diaMes = dateTimePicker1.Value.ToString("dd/MM");

                string query = "INSERT INTO `tarefas` (tarefaNome, dataFazer, prioridade, dataCadastro) VALUES (@tarefaNome, @data, @prioridade, @dataCadastro);";

                using (MySqlCommand comando = new MySqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@tarefaNome", txbTarefa.Text);
                    comando.Parameters.AddWithValue("@data", diaMes);
                    comando.Parameters.AddWithValue("@prioridade", cbxPrioridade.Text);
                    comando.Parameters.AddWithValue("@dataCadastro", dataCadastro);  // Adicionando o parâmetro de data corretamente

                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Tarefa salva", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                lblErro3.Text = ex.Message;
            }
            finally
            {
                txbTarefa.Text = "";
                dateTimePicker1.Text = "";
                cbxPrioridade.Text = "";
            }
        }

        

        private void cbxEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxEscolha.SelectedIndex)
            {
                case 0:
                    lstLista.Items.Clear();
                    lblEncontrado.Text = "";
                    lblBuscar.Location = new Point(63, 100);
                    cbxEscolha.Location = new Point(135, 97);
                    btnBuscar.Location = new Point(230, 97);
                    dateTimePicker3.Visible = false;
                    cbxPrioridade1.Visible = false;
                    cbxTarefaEspecifica.Visible = false;
                    break;

                //Tarefa específica
                case 1:
                    lstLista.Items.Clear();
                    lblEncontrado.Text = "";
                    lblBuscar.Location = new Point(32, 100);
                    cbxEscolha.Location = new Point(97, 97);
                    cbxTarefaEspecifica.Location = new Point(184, 97);
                    btnBuscar.Location = new Point(265, 97);
                    dateTimePicker3.Visible = false;
                    cbxPrioridade1.Visible = false;
                    cbxTarefaEspecifica.Visible = true;
                    break;

                //Prioridade 
                case 2:
                    lstLista.Items.Clear();
                    lblEncontrado.Text = "";
                    lblBuscar.Location = new Point(32, 100);
                    cbxEscolha.Location = new Point(97, 97);
                    cbxPrioridade1.Location = new Point(184, 97);
                    btnBuscar.Location = new Point(265, 97);
                    dateTimePicker3.Visible = false;
                    cbxPrioridade1.Visible = true;
                    cbxTarefaEspecifica.Visible = false;
                    break;

                //Data para fazer
                case 3:
                    lstLista.Items.Clear();
                    lblEncontrado.Text = "";
                    lblBuscar.Location = new Point(32, 100);
                    cbxEscolha.Location = new Point(97, 97);
                    dateTimePicker3.Location = new Point(184, 97);
                    btnBuscar.Location = new Point(265, 97);
                    dateTimePicker3.Visible = true;
                    cbxPrioridade1.Visible = false;
                    cbxTarefaEspecifica.Visible = false;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();
                string tarefa = cbxTarefaEspecifica.Text;
                string prioridade = cbxPrioridade1.Text;
                string data = dateTimePicker3.Text;

                int desc = cbxEscolha.SelectedIndex;
                MySqlCommand cmd;
                MySqlDataReader reader;

                switch (desc)
                {
                    //Listar tudo
                    case 0:
                        try
                        {
                            cmd = new MySqlCommand("SELECT * FROM `tarefas`", conn);
                            reader = cmd.ExecuteReader();

                            lstLista.Items.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lstLista.Items.Add("Tarefa: " + reader.GetString(1));
                                    lstLista.Items.Add("Prioridade: " + reader.GetString(3));
                                    lstLista.Items.Add("Data em que a tarefa foi cadastrada: " + reader.GetString(4));
                                    lstLista.Items.Add("Data para concluir a tarefa: " + reader.GetString(2));
                                    lstLista.Items.Add("-----------------------------------\n");
                                }
                            }
                            else
                            {
                                lstLista.Items.Add("Nenhuma tarefa encontrada.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                        finally
                        {
                            cmd = null;
                        }
                        break;

                    //Listar tarefa
                    case 1:
                        if (string.IsNullOrEmpty(tarefa))
                        {
                            MessageBox.Show("Escolha alguma tarefa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                lstLista.Items.Clear();

                                cmd = new MySqlCommand("SELECT *  FROM `tarefas` WHERE `tarefaNome` = @tarefa", conn);
                                cmd.Parameters.AddWithValue("@tarefa", tarefa);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    lblEncontrado.Text = "Tarefa: " + reader.GetString(1);
                                    lstLista.Items.Add("\n" + "\n");
                                    lstLista.Items.Add("Prioridade: " + reader.GetString(3));
                                    lstLista.Items.Add("Data em que a tarefa foi cadastrada: " + reader.GetString(4));
                                    lstLista.Items.Add("Data para concluir a tarefa: " + reader.GetString(2));
                                    lstLista.Items.Add("-----------------------------------\n");
                                }
                                reader.Close();

                            }
                            catch (Exception ex)
                            {
                                lblErro1.Text = "Erro: " + ex.Message;
                            }
                            finally
                            {
                                cmd = null; // Libera o comando
                            }
                        }
                        break;

                    //Listar por prioridade
                    case 2:
                        if (string.IsNullOrEmpty(prioridade))
                        {
                            MessageBox.Show("Escolha alguma tarefa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                lstLista.Items.Clear();

                                cmd = new MySqlCommand("SELECT * FROM `tarefas` WHERE `prioridade` = @prioridade", conn);
                                cmd.Parameters.AddWithValue("@prioridade", prioridade);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    lblEncontrado.Text = "Prioridade: " + reader.GetString(3);
                                    lstLista.Items.Add("\n" + "\n");
                                    lstLista.Items.Add("Tarefa: " + reader.GetString(1));
                                    lstLista.Items.Add("Data em que a tarefa foi cadastrada: " + reader.GetString(4));
                                    lstLista.Items.Add("Data para concluir a tarefa: " + reader.GetString(2));
                                    lstLista.Items.Add("-----------------------------------\n");
                                }
                                reader.Close();

                            }
                            catch (Exception ex)
                            {
                                lblErro1.Text = "Erro: " + ex.Message;
                            }
                            finally
                            {
                                cmd = null; // Libera o comando
                            }
                        }
                        break;
                    //Listar por data
                    case 3:
                        if (string.IsNullOrEmpty(data))
                        {
                            MessageBox.Show("Escolha alguma tarefa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                lstLista.Items.Clear();

                                cmd = new MySqlCommand("SELECT * FROM `tarefas` WHERE `dataFazer` = @dataFazer", conn);
                                cmd.Parameters.AddWithValue("@dataFazer", data);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    lblEncontrado.Text = "Tarefas para concluir nesta data: " + reader.GetString(2);
                                    lstLista.Items.Add("\n" + "\n");
                                    lstLista.Items.Add("Tarefa: " + reader.GetString(1));
                                    lstLista.Items.Add("Prioridade: " + reader.GetString(3));
                                    lstLista.Items.Add("Data em que a tarefa foi cadastrada: " + reader.GetString(4));
                                    lstLista.Items.Add("-----------------------------------\n");
                                }
                                reader.Close();

                            }
                            catch (Exception ex)
                            {
                                lblErro1.Text = "Erro: " + ex.Message;
                            }
                            finally
                            {
                                cmd = null; // Libera o comando
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTarefaEspecifica_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTarefaEspecifica.SelectedIndex) 
            {
                case 0:
                    lblEncontrado.Text = "";
                    break;
                case 1:
                    lblEncontrado.Text = "";
                    break;
                case 2:
                    lblEncontrado.Text = "";
                    break;
            }

        }

        private void cbxPrioridade1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPrioridade1.SelectedIndex)
            {
                case 0:
                    lblEncontrado.Text = "";
                    break;
                case 1:
                    lblEncontrado.Text = "";
                    break;
                case 2:
                    lblEncontrado.Text = "";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEncontrado.Text = "";
            lstLista.Items.Clear();
            lblErro1.Text = "";
            lblErro2.Text = "";
            lblErro3.Text = "";
            lblBuscar.Location = new Point(63, 100);
            cbxEscolha.Location = new Point(135, 97);
            btnBuscar.Location = new Point(230, 97);
            dateTimePicker3.Visible = false;
            cbxPrioridade1.Visible = false;
            cbxTarefaEspecifica.Visible = false;

            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();
                MySqlCommand inserir = new MySqlCommand("SELECT `tarefaNome` FROM `tarefas`;", conn);
                MySqlDataReader ler = inserir.ExecuteReader();
                while (ler.Read())
                {
                    cbxTarefaEspecifica.Items.Add(ler[0]);
                    cbxTarefaEditar.Items.Add(ler[0]);
                    cbxTarefaConcluida.Items.Add(ler[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTarefaEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tarefaSelecionada = cbxTarefaEditar.SelectedItem.ToString();

                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT tarefaNome, prioridade, dataFazer, dataCadastro FROM tarefas WHERE tarefaNome = @nomeTarefa;", conn);
                cmd.Parameters.AddWithValue("@nomeTarefa", tarefaSelecionada);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Verifica se a tarefa já está no ComboBox para não adicionar duplicados
                    if (!cbxTarefaEditar.Items.Contains(reader.GetString(0)))
                    {
                        cbxTarefaEditar.Items.Add(reader.GetString(0));
                        
                    }
                    txbNome.Text = reader.GetString(0);

                    string prioridade = reader.GetString(1);

                    cbxPrioridadeEditar.Items.Clear();
                    cbxPrioridadeEditar.Items.Add(prioridade);  

                    // Ajusta o ComboBox para mostrar as outras prioridades disponíveis
                    if (prioridade == "Alta")
                    {
                        cbxPrioridadeEditar.Items.Add("Média");
                        cbxPrioridadeEditar.Items.Add("Baixa");
                    }
                    else if (prioridade == "Média")
                    {
                        cbxPrioridadeEditar.Items.Add("Alta");
                        cbxPrioridadeEditar.Items.Add("Baixa");
                    }
                    else if (prioridade == "Baixa")
                    {
                        cbxPrioridadeEditar.Items.Add("Alta");
                        cbxPrioridadeEditar.Items.Add("Média");
                    }

                    // Definir a prioridade selecionada como a primeira (a que já estava atribuída)
                    cbxPrioridadeEditar.SelectedIndex = 0;

                    // Definir a data usando DateTimePicker
                    dateTimePicker2.Value = DateTime.Parse(reader.GetString(2));
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string tarefaSelecionada = cbxTarefaEditar.SelectedItem.ToString();
                string novoNome = txbNome.Text;  
                string novaPrioridade = cbxPrioridadeEditar.SelectedItem.ToString();  
                string novaDataFazer = dateTimePicker2.Value.ToString("dd/MM");  

                // Conectando ao banco de dados para atualizar as informações da tarefa
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();

                // Comando UPDATE para atualizar o nome, prioridade e dataFazer
                MySqlCommand cmd = new MySqlCommand("UPDATE tarefas SET tarefaNome = @novoNome, prioridade = @novaPrioridade, dataFazer = @novaData WHERE tarefaNome = @nomeTarefa;", conn);

                // Adiciona os parâmetros ao comando
                cmd.Parameters.AddWithValue("@novoNome", novoNome);
                cmd.Parameters.AddWithValue("@novaPrioridade", novaPrioridade);
                cmd.Parameters.AddWithValue("@novaData", novaDataFazer);
                cmd.Parameters.AddWithValue("@nomeTarefa", tarefaSelecionada);

                // Executa o comando UPDATE
                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Tarefa atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhuma tarefa foi atualizada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cbxTarefaEditar.Text = "";
                txbNome.Text = "";
                cbxPrioridadeEditar.Text = "";
                dateTimePicker2.Text = DateTime.Now.ToString();
            }
        }

        private void cbxTarefaConcluida_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string tarefaSelecionada = cbxTarefaConcluida.SelectedItem.ToString();

                // Conectando ao banco de dados para buscar informações da tarefa
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT tarefaNome, prioridade, dataFazer, dataCadastro FROM tarefas WHERE tarefaNome = @nomeTarefa;", conn);
                cmd.Parameters.AddWithValue("@nomeTarefa", tarefaSelecionada);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Limpando a lista antes de adicionar novos dados
                    lstListaConcluida.Items.Clear();

                    // Adicionando informações específicas da tarefa selecionada
                    lstListaConcluida.Items.Add("Tarefa: " + reader.GetString("tarefaNome"));
                    lstListaConcluida.Items.Add("Prioridade: " + reader.GetString("prioridade"));
                    lstListaConcluida.Items.Add("Data para fazer: " + reader.GetString("dataFazer"));
                    lstListaConcluida.Items.Add("Data em que a tarefa foi cadastrada: " + reader.GetString("dataCadastro"));
                    lstListaConcluida.Items.Add("-----------------------------------\n");
                }

                reader.Close();
                conn.Close();

            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tarefaSelecionada = cbxTarefaConcluida.SelectedItem.ToString();

                // Conectando ao banco de dados para buscar informações da tarefa
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();

                // Criando o comando para deletar a tarefa selecionada
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `tarefas` WHERE tarefaNome = @nomeTarefa;", conn);
                cmd.Parameters.AddWithValue("@nomeTarefa", tarefaSelecionada);

                // Executando o comando de exclusão
                int linhasAfetadas = cmd.ExecuteNonQuery();
                cbxTarefaConcluida.Text = "";
                lstListaConcluida.Items.Clear();

                // Verifica se alguma linha foi afetada (tarefa removida)
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Tarefa concluída e apagada. Cadastre uma nova tarefa", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A tarefa não foi encontrada ou já foi removida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();
                MySqlCommand inserir = new MySqlCommand("SELECT `tarefaNome` FROM `tarefas`;", conn);
                MySqlDataReader reader = inserir.ExecuteReader();
                while (reader.Read())
                {
                    // Verifica se a tarefa já está no ComboBox para não adicionar duplicados
                    if (!cbxTarefaEditar.Items.Contains(reader.GetString(0)))
                    {
                        cbxTarefaEditar.Items.Add(reader.GetString(0));

                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();
                MySqlCommand inserir = new MySqlCommand("SELECT `tarefaNome` FROM `tarefas`;", conn);
                MySqlDataReader reader = inserir.ExecuteReader();
                while (reader.Read())
                {
                    // Verifica se a tarefa já está no ComboBox para não adicionar duplicados
                    if (!cbxTarefaConcluida.Items.Contains(reader.GetString(0)))
                    {
                        cbxTarefaConcluida.Items.Add(reader.GetString(0));

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=taskcsharp");
                conn.Open();
                MySqlCommand inserir = new MySqlCommand("SELECT `tarefaNome` FROM `tarefas`;", conn);
                MySqlDataReader reader = inserir.ExecuteReader();
                while (reader.Read())
                {
                    // Verifica se a tarefa já está no ComboBox para não adicionar duplicados
                    if (!cbxTarefaEspecifica.Items.Contains(reader.GetString(0)))
                    {
                        cbxTarefaEspecifica.Items.Add(reader.GetString(0));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lstLista.Items.Clear();
                lblEncontrado.Text = "";
                cbxEscolha.Text = "";
                cbxTarefaEspecifica.Text = "";
                cbxPrioridade1.Text = "";
                dateTimePicker3.Text = DateTime.Now.ToString();
            }
        }

        private void cbxPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
