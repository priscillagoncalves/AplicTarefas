using DTO;
using Negocios;
using System;
using System.Windows.Forms;


namespace Interface
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            TarefaNegocios tarefaNegocios = new TarefaNegocios();

            TarefaCollection tarefaCollection = new TarefaCollection();

            tarefaCollection = tarefaNegocios.Consultar();
            //tarefaCollection = tarefaNegocios.ConsultarPorTitulo(textBoxTituloPesq.Text);


            dataGridViewPesq.DataSource = null;
            dataGridViewPesq.DataSource = tarefaCollection;

            dataGridViewPesq.Update();
            dataGridViewPesq.Refresh();

        }

        private void buttonNovaTarefa_Click(object sender, EventArgs e)
        {
            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void buttonExcluirTarefa_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesq.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa selecionada.");
                return;
            }
            DialogResult resultado = MessageBox.Show("Confirmar exclusão", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            Tarefa tarefaSelecionada = (dataGridViewPesq.SelectedRows[0].DataBoundItem as Tarefa);
            TarefaNegocios tarefaNegocios = new TarefaNegocios();
            string retorno = tarefaNegocios.Excluir(tarefaSelecionada);
            try
            {
                int id = Convert.ToInt32(retorno);
                MessageBox.Show("Tarefa excluída com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAlterarTarefa_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesq.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa selecionada.");
                return;
            }
            Tarefa tarefaSelecionada = (dataGridViewPesq.SelectedRows[0].DataBoundItem as Tarefa);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Alterar, tarefaSelecionada);
            DialogResult dialogResult = frmCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonVisualizar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPesq.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa selecionada.");
                return;
            }
            Tarefa tarefaSelecionada = (dataGridViewPesq.SelectedRows[0].DataBoundItem as Tarefa);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Consultar, tarefaSelecionada);
            DialogResult dialogResult = frmCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

    }
}

