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

        public List<Valoare> SelectValoriList(String perecheValutara)
        {
            List<Valoare> lista = new List<Valoare>();
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    String query = "select Data, OpenPrice, HighPrice, LowPrice, ClosePrice from Valori where Simbol='" + perecheValutara + "'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Valoare val = new Valoare(reader.GetDateTime(0), Double.Parse(reader.GetDecimal(1).ToString()), Double.Parse(reader.GetDecimal(2).ToString()), Double.Parse(reader.GetDecimal(3).ToString()), Double.Parse(reader.GetDecimal(4).ToString()));
                                lista.Add(val);
                            }
                        }
                    }
                    connection.Close();
                    return lista;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            return null;
        }

        public List<Valoare> SelectValoriListaDupaData(String perecheValutara, DateTime dataInceput, DateTime dataFinal)
        {
            List<Valoare> lista = new List<Valoare>();
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    String query = "select Data, OpenPrice, HighPrice, LowPrice, ClosePrice from Valori where Simbol= @simbol and Data between @dataInceput and @dataFinal";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@simbol", perecheValutara);
                    command.Parameters.AddWithValue("@dataInceput", dataInceput.Date);
                    command.Parameters.AddWithValue("@dataFinal", dataFinal.Date);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Valoare val = new Valoare(reader.GetDateTime(0),Double.Parse(reader.GetDecimal(1).ToString()), Double.Parse(reader.GetDecimal(2).ToString()), Double.Parse(reader.GetDecimal(3).ToString()), Double.Parse(reader.GetDecimal(4).ToString()));
                            lista.Add(val);
                        }
                    }

                    connection.Close();
                    return lista;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            return null;
        }


        public List<float> SelectClosePriceValoriList(String perecheValutara)
        {
            List<float> lista = new List<float>();
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    String query = "select ClosePrice from Valori where Simbol='" + perecheValutara + "'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(float.Parse(reader.GetDecimal(0).ToString()));
                            }
                        }
                    }
                    connection.Close();
                    return lista;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace.ToString());
                }
            }
            return null;
        }

        public List<DateTime> SelectDateValoriList(String perecheValutara)
        {
            List<DateTime> lista = new List<DateTime>();
            using (connection = new SqlConnection(Constante.CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    String query = "select Data from Valori where Simbol='" + perecheValutara + "'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(reader.GetDateTime(0));
                            }
                        }
                    }
                    connection.Close();
                    return lista;
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
                        command = new SqlCommand("insert into Valori(Data,OpenPrice,HighPrice,LowPrice,ClosePrice,Simbol) values(@data,@openPrice,@highPrice,@lowPrice,@closePrice,@simbol)", connection);
                        command.Parameters.AddWithValue("@data", valoare.Data);
                        command.Parameters.AddWithValue("@openPrice", valoare.Open);
                        command.Parameters.AddWithValue("@highPrice",valoare.High);
                        command.Parameters.AddWithValue("@lowPrice", valoare.Low);
                        command.Parameters.AddWithValue("@closePrice", valoare.Close);
                        command.Parameters.AddWithValue("@simbol", perecheValutara);
                        command.ExecuteNonQuery();
                        Console.WriteLine("ok");
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


        public void InserarePortofoliu(Portofoliu portofoliu)
        {
            connection = new SqlConnection(Constante.CONNECTION_STRING);
            try
            {
                connection.Open();
                command = new SqlCommand("insert into Portofoliu(Nume) values(@nume)", connection);
                command.Parameters.AddWithValue("@nume", portofoliu.NumePortofoliu);
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
