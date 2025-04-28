using _web_api_project.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.BusinessLogic.Contracts
{
    public class NoteResponse
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public string AccountName { get; set; }
        public string CategoryName { get; set; }
    }
}
