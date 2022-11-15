using PadamBookStore.DataAccess.Repository.IRepository;
using PadamBookStore.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace PadamBookStore.DataAccess.Repository
{
    public class SP_Call: ISP_Call
    {
        //access the database
        private readonly ApplicationDbContext _db;
        private static String ConnectionString = ""; // needed to called the stored procedures


        // consturctor to open a SQL Connection
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }

        // impplement the ISP_Call interface
        public void Dispose()
        {
            _db.Dispose();
        }

        public IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}
