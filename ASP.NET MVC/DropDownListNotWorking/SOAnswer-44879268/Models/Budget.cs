using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAnswer_44879268.Models
{
    public class BudgetModel
    {
        public int MONTH { get; set; }

        public int YEAR { get; set; }

        public string DEPARTMENTID { get; set; }

        public DateTime DATETIME { get; set; }

        //[DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]

        public double BUDGET { get; set; }

        public string GROUPID { get; set; }

    }

    public class BudgetViewModel : BudgetModel

    {

        public string DEPARTMENTNAME { get; set; }

        public double EXPENCES { get; set; }

        public double BALANCE { get; set; }

    }
}