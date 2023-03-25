using DataAccesLibrary.Model;

namespace DataAccesLibrary
{
    public interface IBudgetBookData
    {
        Task<List<BudgetBookModel>> GetBudgetBooks();
        Task InsertBudgetBook(BudgetBookModel budgetBook);
    }
}