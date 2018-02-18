﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp.Models
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
    }
}
