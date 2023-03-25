using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLibrary.Model
{
    public class BudgetBookModel
    {
       public string Description { get; set; } 
       public decimal  Amount { get; set; }

        public BudgetBookModel()
        {

        }
    }
}
