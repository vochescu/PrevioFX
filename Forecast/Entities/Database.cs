using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Forecast.Entities
{
    class Database
    {
        SqlConnection connection;
        SqlCommand command;

        public Database()
        {

        }

        public DataSet SelectTotPerecheValutaraDataset()
        {
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string perechiValutarequery = "select Simbol from PerechiValutare";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(perechiValutarequery, connection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, Constante.DATASET_NAME_PERECHI_VALUTARE);
                    connection.Close();
                    return dataSet;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            return null;
        }

        public DataTable SelectTotValoriDataTable(String perecheValutara)
        {
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("select Data, OpenPrice, HighPrice, LowPrice, ClosePrice from Valori where Simbol='" + perecheValutara + "'", connection);
                    adapter.Fill(dataTable);
                    connection.Close();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            return null;
        }

        public void InsertPerecheValutaraIntoDatabase(String simbol, String denumire)
        {
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into PerechiValutare(Simbol,Denumire) values (@simbol,@denumire)", connection);
                    command.Parameters.AddWithValue("@simbol", simbol);
                    command.Parameters.AddWithValue("@denumire", denumire);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
        }

        public void InsertListaValoriIntoDatabase(List<Valoare> listaValori, String perecheValutara)
        {
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    foreach (Valoare valoare in listaValori)
                    {
                        command = new SqlCommand("insert into Valori(Data, OpenPrice, HighPrice, LowPrice, ClosePrice,Simbol) values(@data,@openPrice,@highPrice,@lowPrice,@closePrice, @simbol)", connection);
                        command.Parameters.AddWithValue("@data", valoare.Data);
                        command.Parameters.AddWithValue("@openPrice", valoare.Open);
                        command.Parameters.AddWithValue("@highPrice",valoare.High);
                        command.Parameters.AddWithValue("@lowPrice", valoare.Low);
                        command.Parameters.AddWithValue("@closePrice", valoare.Close);
                        command.Parameters.AddWithValue("@simbol", perecheValutara);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
        }

        public void InsertValoriIntoDatabase(Valoare valoare, String perecheValutara)
        {
            connection = new SqlConnection(Constante.CONNECTION_STRING);
            try
            {
                connection.Open();
                command = new SqlCommand("insert into Valori(Data, OpenPrice, HighPrice, LowPrice, ClosePrice,Simbol) values(@data,@openPrice,@highPrice,@lowPrice,@closePrice, @simbol)", connection);
                command.Parameters.AddWithValue("@data", valoare.Data);
                command.Parameters.AddWithValue("@openPrice", valoare.Open);
                command.Parameters.AddWithValue("@highPrice", valoare.High);
                command.Parameters.AddWithValue("@lowPrice", valoare.Low);
                command.Parameters.AddWithValue("@closePrice", valoare.Close);
                command.Parameters.AddWithValue("@simbol", perecheValutara);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        public void UpdateValoriIntoDatabase(Valoare valoare)
        {
            connection = new SqlConnection(Constante.CONNECTION_STRING);
            try
            {
                connection.Open();
                command = new SqlCommand("update Valori set OpenPrice=@openPrice, HighPrice=@highPrice, LowPrice=@lowPrice, ClosePrice=@closePrice where Data=@data", connection);
                command.Parameters.AddWithValue("@data", valoare.Data);
                command.Parameters.AddWithValue("@openPrice", valoare.Open);
                command.Parameters.AddWithValue("@highPrice", valoare.High);
                command.Parameters.AddWithValue("@lowPrice",valoare.Low);
                command.Parameters.AddWithValue("@closePrice", valoare.Close);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        public void DeleteValoriIntoDatabase(Valoare valoare)
        {
            connection = new SqlConnection(Constante.CONNECTION_STRING);
            try
            {
                connection.Open();
                command = new SqlCommand("delete from Valori where Data=@data", connection);
                command.Parameters.AddWithValue("@data", valoare.Data);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }
    }
}
