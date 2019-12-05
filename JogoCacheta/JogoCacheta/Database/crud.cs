using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;
using System.Windows.Forms;

namespace JogoCacheta.Database
{
    class Crud
    {
        private DbProviderFactory Factory { get; set; }
        private DbConnection Connection { get; set; }
        public Crud()
        {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            try
            {
                this.Factory = DbProviderFactories.GetFactory(provider);
                this.Connection = this.Factory.CreateConnection();
                if (this.Connection == null)
                {
                    throw new Exception("Connection Error");
                }
                this.Connection.ConnectionString = connectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private DbCommand NewCommand()
        {
            DbCommand command = this.Factory.CreateCommand();
            try
            {
                if (command == null)
                {
                    this.Connection.Close();
                    throw new Exception("Command Error");
                }
                command.Connection = this.Connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return command;
        }

        public int NovoJogo(byte qtdjog, byte maxpontos)
        {
            this.Connection.Open();
            DbCommand command = NewCommand();
            switch (qtdjog)
            {
                case 3:
                    command.CommandText = "INSERT INTO tb_jogo (qtdjog, pontos1, pontos2, pontos3) OUTPUT INSERTED.cod_jogo values('" + qtdjog + "', '" + maxpontos + "', '" + maxpontos + "', '" + maxpontos + "')";
                    break;
                case 4:
                    command.CommandText = "INSERT INTO tb_jogo (qtdjog, pontos1, pontos2, pontos3, pontos4) OUTPUT INSERTED.cod_jogo values('" + qtdjog + "', '" + maxpontos + "', '" + maxpontos + "', '" + maxpontos + "', '" + maxpontos + "')";
                    break;
                case 5:
                    command.CommandText = "INSERT INTO tb_jogo (qtdjog, pontos1, pontos2, pontos3, pontos4, pontos5) OUTPUT INSERTED.cod_jogo values('" + qtdjog + "', '" + maxpontos + "', '" + maxpontos + "', '" + maxpontos + "', '" + maxpontos + "', '" + maxpontos + "')";
                    break;
                default:
                    command.CommandText = "INSERT INTO tb_jogo (qtdjog, pontos1, pontos2) OUTPUT INSERTED.cod_jogo values('" + qtdjog + "', '" + maxpontos + "', '" + maxpontos + "')";
                    break;
            }
            try
            {
                int cod = (int)command.ExecuteScalar();
                this.Connection.Close();
                return cod;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            return 0;
        }
        
        private byte Select(string column, int cod)
        {
            this.Connection.Open();
            DbCommand command = NewCommand();
            command.CommandText = "SELECT " + column + " FROM tb_jogo WHERE cod_jogo = '" + cod + "'";
            try
            {
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            byte ponto = Convert.ToByte(dataReader[column]);
                            this.Connection.Close();
                            return ponto;
                        }
                    }
                    else
                    {
                        throw new Exception("No data returned");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            this.Connection.Close();
            return 0;
        }
        public byte GetRodada(int cod)
        {
            return Select("rodada", cod);
        }
        public byte GetGanhador(int cod)
        {
            return Select("ganhador", cod);
        }
        public byte GetQtdJog(int cod)
        {
            return Select("qtdjog", cod);
        }
        public byte GetPontos1(int cod)
        {
            return Select("pontos1", cod);
        }
        public byte GetPontos2(int cod)
        {
            return Select("pontos2", cod);
        }
        public byte GetPontos3(int cod)
        {
            return Select("pontos3", cod);
        }
        public byte GetPontos4(int cod)
        {
            return Select("pontos4", cod);
        }
        public byte GetPontos5(int cod)
        {
            return Select("pontos5", cod);
        }

        private void Fold(string column, int cod)
        {
            if (Select(column, cod) > 0)
            {
                this.Connection.Open();
                try
                {
                    DbCommand command = NewCommand();
                    command.CommandText = "UPDATE tb_jogo SET " + column + " = " + column + " - 1 WHERE cod_jogo = '" + cod + "'";
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    this.Connection.Close();
                }
            }
            this.Connection.Close();
        }
        public void Jog1Fold(int cod)
        {
            Fold("pontos1", cod);
        }
        public void Jog2Fold(int cod)
        {
            Fold("pontos2", cod);
        }
        public void Jog3Fold(int cod)
        {
            Fold("pontos3", cod);
        }
        public void Jog4Fold(int cod)
        {
            Fold("pontos4", cod);
        }
        public void Jog5Fold(int cod)
        {
            Fold("pontos5", cod);
        }

        private void Lose(string column, int cod)
        {
            if (Select(column, cod) > 1)
            {
                this.Connection.Open();
                try
                {
                    DbCommand command = NewCommand();
                    command.CommandText = "UPDATE tb_jogo SET " + column + " = " + column + " - 2 WHERE cod_jogo = '" + cod + "'";
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    this.Connection.Close();
                }
            }
            else
            {
                Fold(column, cod);
            }
            this.Connection.Close();
        }
        public void Jog1Lose(int cod)
        {
            Lose("pontos1", cod);
        }
        public void Jog2Lose(int cod)
        {
            Lose("pontos2", cod);
        }
        public void Jog3Lose(int cod)
        {
            Lose("pontos3", cod);
        }
        public void Jog4Lose(int cod)
        {
            Lose("pontos4", cod);
        }
        public void Jog5Lose(int cod)
        {
            Lose("pontos5", cod);
        }

        public void SetGanhador(int cod, byte ganhador)
        {
            this.Connection.Open();
            DbCommand command = NewCommand();
            command.CommandText = "UPDATE tb_jogo SET ganhador = '" + ganhador + "' WHERE cod_jogo = '" + cod + "'";
            command.ExecuteNonQuery();
            this.Connection.Close();
        }

        public void NovaRodada(int cod)
        {
            this.Connection.Open();
            DbCommand command = NewCommand();
            command.CommandText = "UPDATE tb_jogo SET rodada = rodada + 1 WHERE cod_jogo = '" + cod + "'";
            command.ExecuteNonQuery();
            this.Connection.Close();
        }
    }
}
