﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Keepnote.Models
{
    public class KeepNoteContext: DbContext
    {
       /*
        This class should be used as DbContext to speak to database and should make the use of Code first approach.
        It should autogenerate the database based upon the model class in your application
         */

        public KeepNoteContext() { }

        public KeepNoteContext(DbContextOptions<KeepNoteContext> options): base(options) { }

        public DbSet<Note> Notes { get; set; }


    }
}
