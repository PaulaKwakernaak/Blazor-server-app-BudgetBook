using DataAccesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLibrary
{
    public class BudgetBookData : IBudgetBookData
    {
        private readonly ISqlDataAcces _db;
        public BudgetBookData(ISqlDataAcces db)
        {
            _db = db;
        }

        public Task<List<BudgetBookModel>> GetBudgetBooks()
        {
            string sql = "select * from dbo.BudgetBook";
            return _db.LoadData<BudgetBookModel, dynamic>(sql, new { });
        }

        public Task InsertBudgetBook(BudgetBookModel budgetBook)
        {
            string sql = @"insert into dbo.BudgetBook (Description, Amount)
                    values (@Description, @Amount);";
            return _db.SaveData(sql, budgetBook);
        }
    }
}
