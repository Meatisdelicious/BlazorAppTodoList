using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// notre modèle de base
namespace BlazorAppTodoList.Data.Models
{
    public class TaskModel
    {
        public string TaskName { get; set; } = default!;
        public bool IsComplete { get; set; }
    }
}
