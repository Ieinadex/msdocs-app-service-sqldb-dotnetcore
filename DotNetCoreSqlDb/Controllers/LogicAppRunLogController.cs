using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDb.Controllers
{
    public class LogicAppRunLogController : Controller
    {
        private readonly MyDatabaseContext _context;

        public LogicAppRunLogController(MyDatabaseContext context)
        {
            _context = context;
        }

        // GET: LogicAppRunLogController
        public async Task<IActionResult> Index()
        {
            var logicAppRunLogs = new List<LogicAppRunLog>();

            try
            {
                logicAppRunLogs = await _context.LogicAppRunLog.ToListAsync();
            }
            catch (Exception e)
            {
                return View(logicAppRunLogs);
            }

            return View(logicAppRunLogs);
            
        }        
    }
}
