﻿using FormBuilderApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FormBuilderApp.DataContexts
{
    public class FormBuilderDb : DbContext
    {
        public FormBuilderDb()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<InputField> InputFields { get; set; }
    }
}