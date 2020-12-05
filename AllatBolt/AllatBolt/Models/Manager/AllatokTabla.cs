using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using AllatBolt.Models.Records;

namespace AllatBolt.Models.Manager
{
    class AllatokTabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();
            string connectionString = @"Data Source=193.225.33.71;User Id=ORA_S1340;Password=EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }

        public List<Allatok> Select()
        {
            List<Allatok> records = new List<Allatok>();
            OracleConnection oc = new OracleConnection();
            oc.Open();
            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT a.idszam, a.faj, a.nem, a.etkezes, a.ar, b.nev FROM " +
                " allatok a INNER JOIN boltok b ON b.id = a.bolt_id"
            };
            command.Connection = oc;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Allatok allat = new Allatok();
                allat.Allat_id = reader["idszam"].ToString();
                allat.Faj = reader["faj"].ToString();
                allat.Nem = reader["nem"].ToString();
                allat.Etkezes = reader["etkezes"].ToString();
                allat.Ar = int.Parse(reader["ar"].ToString());
                allat.Bolt = reader["nev"].ToString();

                records.Add(allat);
            }
            oc.Close();
            return records;
        }

        public int Delete(Allatok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM allatok WHERE allat_id = :idszam"
            };

            OracleParameter idszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":p_idszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Allat_id
            };
            command.Parameters.Add(idszamParameter);

            command.Connection = oc;
            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch(Exception)
            {
                ot.Rollback();
            }
            return affectedRows;
        }

        public int Insert(Allatok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_allatok"
            };
            OracleParameter idszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_idszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Allat_id
            };
            command.Parameters.Add(idszamParameter);

            OracleParameter fajParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_faj",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Faj
            };
            command.Parameters.Add(fajParameter);

            OracleParameter nemParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_nem",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Nem
            };
            command.Parameters.Add(nemParameter);

            OracleParameter etkezesParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_etkezes",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Etkezes
            };
            command.Parameters.Add(etkezesParameter);

            OracleParameter arParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_ar",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Ar
            };
            command.Parameters.Add(arParameter);

            OracleParameter boltParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_bolt_nev",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Bolt
            };
            command.Parameters.Add(boltParameter);

            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };

            command.Connection = oc;
            command.Transaction = ot;

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                ot.Commit();
                return affectedRows;
            }
            catch(Exception)
            {
                ot.Rollback();
                return 0;
            }
        }

        public bool CheckIdszam(string idszam)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sfcheck_idszam"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter idszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_idszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = idszam
            };
            command.Parameters.Add(idszamParameter);
            command.Connection = oc;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());
                return succesful != 0;
            }
            catch(Exception)
            {
                return false;
            }
        }

    }
}
