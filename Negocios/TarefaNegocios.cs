using AcessoBD;
using DTO;
using System;
using System.Data;

namespace Negocios
{
    public class TarefaNegocios
    {
        AcessoDados acessoDados = new AcessoDados();


        public string Inserir(Tarefa tarefa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Titulo", tarefa.Titulo );
                acessoDados.AdicionarParametros("@Descricao", tarefa.Descricao);
                acessoDados.AdicionarParametros("@Data", tarefa.Data);

                string id = acessoDados.ExecutarManipulacao(CommandType.Text, "INSERT INTO Tarefas (Titulo, Descricao, Data) VALUES (@Titulo, @Descricao, @Data); SELECT last_insert_rowid ()").ToString();
                return id;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Alterar(Tarefa tarefa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Id", tarefa.Id);
                acessoDados.AdicionarParametros("@Titulo", tarefa.Titulo);
                acessoDados.AdicionarParametros("@Descricao", tarefa.Descricao);
                acessoDados.AdicionarParametros("@Data", tarefa.Data);

                acessoDados.ExecutarManipulacao(CommandType.Text, "UPDATE Tarefas SET Titulo = @Titulo, Descricao = @Descricao, Data = @Data WHERE Id = @Id");
                return tarefa.Id.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(Tarefa tarefa)
        {
            try
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Id", tarefa.Id);

                acessoDados.ExecutarManipulacao(CommandType.Text, "DELETE FROM Tarefas WHERE Id = @Id");
                return tarefa.Id.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public TarefaCollection ConsultarPorTitulo(string titulo)
        {
            try
            {
                TarefaCollection tarefaCollection = new TarefaCollection();
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Titulo", titulo);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Tarefas WHERE Titulo LIKE '%@Titulo%'");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Tarefa tarefa = new Tarefa();

                    tarefa.Id = Convert.ToInt64(dataRow["Id"]);
                    tarefa.Titulo = Convert.ToString(dataRow["Titulo"]);
                    tarefa.Descricao = Convert.ToString(dataRow["Descricao"]);
                    tarefa.Data = Convert.ToDateTime(dataRow["Data"]);

                    tarefaCollection.Add(tarefa);
                }

                return tarefaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Tarefa por Título. Detalhes: " + ex.Message);
            }
        }

        public TarefaCollection ConsultarPorId (int id)
        {
            try
            {
                TarefaCollection tarefaCollection = new TarefaCollection();

                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Id", id);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Tarefas WHERE @Id = Id");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Tarefa tarefa = new Tarefa();

                    tarefa.Id = Convert.ToInt64(dataRow["Id"]);
                    tarefa.Titulo = Convert.ToString(dataRow["Titulo"]);
                    tarefa.Descricao = Convert.ToString(dataRow["Descricao"]);
                    tarefa.Data = Convert.ToDateTime(dataRow["Data"]);

                    tarefaCollection.Add(tarefa);
                }

                return tarefaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Tarefa por Id. Detalhes: " + ex.Message);
            }
        }

        
         public TarefaCollection Consultar()
         {
             try
             {   
                 TarefaCollection tarefaCollection = new TarefaCollection();

                 acessoDados.LimparParametros();
                 DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, "SELECT * FROM Tarefas");

                 foreach (DataRow dataRow in dataTable.Rows)
                 {
                     Tarefa tarefa = new Tarefa();

                     tarefa.Id = Convert.ToInt64(dataRow["Id"]);
                     tarefa.Titulo = Convert.ToString(dataRow["Titulo"]);
                     tarefa.Descricao = Convert.ToString(dataRow["Descricao"]);
                     tarefa.Data = Convert.ToDateTime(dataRow["Data"]);

                     tarefaCollection.Add(tarefa);
                 }

                 return tarefaCollection;
             }
             catch (Exception ex)
             {
                 throw new Exception("Não foi possível consultar todas Tarefas. Detalhes: " + ex.Message);
             }
         }

    }
}