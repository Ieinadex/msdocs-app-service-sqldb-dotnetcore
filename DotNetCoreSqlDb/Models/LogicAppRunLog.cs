using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreSqlDb.Models
{
    public class LogicAppRunLog
    {
        public int LogicAppRunLogID { get; set; }        

        [Display(Name = "Execution Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm:ss zzz}", ApplyFormatInEditMode = true)]
        public DateTime ExecutionDateTime { get; set; }

        public int TodoID { get; set; }

        public string Info { get; set; }

    }
}
