using System;
using System.Data;
using System.Data.SQLite;


namespace AcessoBD
{
    public class AcessoDados
    {
        private SQLiteConnection CriarConexao()
        {
            return new SQLiteConnection("Data Source = .\\Tarefas.db; Version = 3");
        }

        private SQLiteParameterCollection sqlParameterCollection = new SQLiteCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SQLiteParameter(nomeParametro, valorParametro));
        }

        //Persistência, inserir, alterar, excluir
        public object ExecutarManipulacao(CommandType commandType, string query)
        {
            try
            {
                SQLiteConnection sqliteConnection = CriarConexao();
                sqliteConnection.Open();
                SQLiteCommand sqliteCommand = sqliteConnection.CreateCommand();
                sqliteCommand.CommandType = commandType;
                sqliteCommand.CommandText = query;
                sqliteCommand.CommandTimeout = 300;

                foreach (SQLiteParameter sqliteParameter in sqlParameterCollection)
                    sqliteCommand.Parameters.Add(new SQLiteParameter(sqliteParameter.ParameterName, sqliteParameter.Value));

                return sqliteCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Select
        public DataTable ExecutarConsulta(CommandType commandType, string query)
        {
            try
            {
                SQLiteConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SQLiteCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = query;
                sqlCommand.CommandTimeout = 300;

                foreach (SQLiteParameter sqliteParameter in sqlParameterCollection)
                    sqlCommand.Parameters.Add(new SQLiteParameter(sqliteParameter.ParameterName, sqliteParameter.Value));

                //Cria adaptador e passa o command que está com os parametros
                SQLiteDataAdapter sqliteDataAdapter = new SQLiteDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                sqliteDataAdapter.Fill(dataTable);//fill preencher

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}