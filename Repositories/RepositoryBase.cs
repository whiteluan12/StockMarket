using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace MVVM.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "server=localhost; uid=root; pwd=matkhaula123; database=mvvmlogindb";
        }

        protected MySqlConnection GetConnection() 
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
