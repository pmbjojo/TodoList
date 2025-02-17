﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace TodoList.Shared.Domains
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public DateTime? DeadLine { get; set; }
        public Status? Status { get; set; }
    }
}
