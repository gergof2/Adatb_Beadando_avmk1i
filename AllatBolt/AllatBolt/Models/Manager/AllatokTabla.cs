using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using AllatBolt.Models.Records;

namespace AllatBolt.Models.Manager
{
    class AllatokTabla : DatabaseConnection
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();
            string connectionString = @"Data Source = 193.225.33.71;User Id = ORA_S1340;Password = EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }

        public List<Boltok> BoltSelect()
        {
            List<Boltok> records = new List<Boltok>();
            OracleCommand command = new OracleCommand();

            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT id, nev FROM boltok";
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Boltok bolt = new Boltok();
                bolt.id = int.Parse(reader["id"].ToString());
                bolt.nev = (string)reader["nev"];

                records.Add(bolt);
            }
            reader.Close();
            return records;
        }

        public List<Allatok> Select()
        {
            List<Allatok> records = new List<Allatok>();
            OracleCommand command = new OracleCommand();

            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT idszam, faj, nem, etkezes, ar, bolt_id FROM allatok";

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Allatok allat = new Allatok();
                allat.idszam = (string)reader["idszam"];
                allat.faj = (string)reader["faj"];
                allat.nem = (string)reader["nem"];
                allat.etkezes = (string)reader["etkezes"];
                allat.ar = (string)reader["ar"];
                allat.bolt_id = int.Parse(reader["bolt_id"].ToString());

                records.Add(allat);
            }
            reader.Close();
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
                CommandText = "DELETE FROM allatok WHERE idszam = :idszam"
            };

            OracleParameter idszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":idszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.idszam
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
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO allatok(idszam, faj, nem, etkezes, ar, bolt_id) VALUES(:idszam, :faj, :nem, :etkezes, :ar, :bolt_id)";

            OracleParameter pidszam = new OracleParameter();
            pidszam.ParameterName = ":idszam";
            pidszam.OracleDbType = OracleDbType.Varchar2;
            pidszam.Direction = System.Data.ParameterDirection.Input;
            pidszam.Value = record.idszam;

            OracleParameter pfaj = new OracleParameter();
            pfaj.ParameterName = ":faj";
            pfaj.OracleDbType = OracleDbType.Varchar2;
            pfaj.Direction = System.Data.ParameterDirection.Input;
            pfaj.Value = record.faj;

            OracleParameter pnem = new OracleParameter();
            pnem.ParameterName = ":nem";
            pnem.OracleDbType = OracleDbType.Varchar2;
            pnem.Direction = System.Data.ParameterDirection.Input;
            pnem.Value = record.nem;

            OracleParameter petkezes = new OracleParameter();
            petkezes.ParameterName = ":etkezes";
            petkezes.OracleDbType = OracleDbType.Varchar2;
            petkezes.Direction = System.Data.ParameterDirection.Input;
            petkezes.Value = record.etkezes;

            OracleParameter par = new OracleParameter();
            par.ParameterName = ":ar";
            par.OracleDbType = OracleDbType.Varchar2;
            par.Direction = System.Data.ParameterDirection.Input;
            par.Value = record.ar;

            OracleParameter pboltid = new OracleParameter();
            pboltid.ParameterName = ":bolt_id";
            pboltid.OracleDbType = OracleDbType.Long;
            pboltid.Direction = System.Data.ParameterDirection.Input;
            pboltid.Value = record.bolt_id;

            command.Parameters.Add(pidszam);
            command.Parameters.Add(pfaj);
            command.Parameters.Add(pnem);
            command.Parameters.Add(petkezes);
            command.Parameters.Add(par);
            command.Parameters.Add(pboltid);

            return command.ExecuteNonQuery();
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
