﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TodoList_NETServer.Models.DbEntity
{
    [Table("TodoList")]
    public partial class TodoList
    {
        public TodoList()
        {
            TodoItems = new HashSet<TodoItem>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [InverseProperty(nameof(TodoItem.List))]
        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }
}
