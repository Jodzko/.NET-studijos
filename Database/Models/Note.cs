﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _web_api_project.Database.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public Account Account { get; set; }
        public Category? Category { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
