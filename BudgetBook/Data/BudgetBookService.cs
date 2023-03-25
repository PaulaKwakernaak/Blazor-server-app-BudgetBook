namespace BudgetBook.Data
{
    public class BudgetBookService
    {
        private static List<BudgetBook> mockDb = new List<BudgetBook>()
        {
            new BudgetBook(){Description = "Test", Amount = 4.00m}
        };

        public async Task<bool>  AddBudgetBook(BudgetBook newBudgetBook)
        {
                mockDb.Add(newBudgetBook);
                return true;
        }

        public async Task <List<BudgetBook>>GetAllBudgetBooks()
        {
            return mockDb;
        }

        public async Task<decimal>  GetTotalAmount()
        {
            decimal amount = 0.00m;
            foreach(var item in mockDb)
            {
                 amount += item.Amount;
            }
            return amount;
        }
    }

    
}
