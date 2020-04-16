using DTO;
using Negocios;
using System;
using System.Windows.Forms;


namespace Interface
{
    public partial class FrmCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelec;

        public FrmCadastrar(AcaoNaTela acaoNaTela, Tarefa tarefa)
        {
            InitializeComponent();
            acaoNaTelaSelec = acaoNaTela;

            if (acaoNaTela.Equals(AcaoNaTela.Inserir))
            {
                this.Text = ":: Inserir Nova Tarefa ::";
            }
            else if (acaoNaTela.Equals(AcaoNaTela.Alterar))
            {
                this.Text = ":: Alterar Tarefa ::";

                textBoxId.Text = tarefa.Id.ToString();
                textBoxTitulo.Text = tarefa.Titulo;
                textBoxDescricao.Text = tarefa.Descricao;
                dateTimePickerData.Value = tarefa.Data;

                textBoxTitulo.ReadOnly = true;

            }
            else if (acaoNaTela.Equals(AcaoNaTela.Consultar))
            {
                this.Text = ":: Consultar Tarefa ::";

                textBoxId.Text = tarefa.Id.ToString();
                textBoxTitulo.Text = tarefa.Titulo;
                dateTimePickerData.Value = tarefa.Data;
                textBoxDescricao.Text = tarefa.Descricao;

                textBoxTitulo.ReadOnly = true;
                textBoxTitulo.TabStop = false;
                dateTimePickerData.Enabled = false;

                textBoxDescricao.ReadOnly = true;
                textBoxDescricao.TabStop = false;

                buttonSalvarTarefa.Visible = false;
                buttonCancelar.Text = "Fechar";
                buttonCancelar.Focus();

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonSalvarTarefa_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelec == AcaoNaTela.Inserir)
            {
                Tarefa tarefa = new Tarefa();

                tarefa.Titulo = textBoxTitulo.Text;
                tarefa.Descricao = textBoxDescricao.Text;
                tarefa.Data = dateTimePickerData.Value;

                TarefaNegocios tarefaNegocios = new TarefaNegocios();
                string retorno = tarefaNegocios.Inserir(tarefa);

                try
                {
                    int id = Convert.ToInt32(retorno);
                    MessageBox.Show("Tarefa inserida com sucesso. Código: " + id.ToString());
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível inserir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                }
            }
            //Alterar
            else if (acaoNaTelaSelec == AcaoNaTela.Alterar)
            {
                Tarefa tarefa = new Tarefa();

                tarefa.Id = Convert.ToInt64(textBoxId.Text);
                tarefa.Titulo = textBoxTitulo.Text;
                tarefa.Descricao = textBoxDescricao.Text;
                tarefa.Data = dateTimePickerData.Value;

                TarefaNegocios tarefaNegocios = new TarefaNegocios();
                string retorno = tarefaNegocios.Alterar(tarefa);

                try
                {
                    int id = Convert.ToInt32(retorno);
                    MessageBox.Show("Tarefa alterada com sucesso."); 
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                }
            }
        }
                
    }

}
