﻿using Microsoft.EntityFrameworkCore;
using StackUnderflow.DatabaseModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackUnderflow.EF
{
    public class DatabaseContext
    {
        public DatabaseContext()
        {

        }

        //public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        //{ }

        public DbSet<QuestionDB> Questions { get; set; }
    }
}