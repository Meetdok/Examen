using Examen.DB;
using Examen.Models;
using Examen.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Examen.VM
{
    internal class GamesList : BaseTool
    {
        public List<Game> Games { get; set; } // лист
        public CommandVM DeleteGame { get; set; }
        public Game SelectedGame { get; set; } 

        public GamesList()
        {
            Games = Rey_InterpriseContext.GetInstance().Games.Include(s => s.Pegi).ToList(); // лист

            DeleteGame = new CommandVM(() =>
            {
                try
                {
                    var del = Rey_InterpriseContext.GetInstance().Games.Remove(SelectedGame);
                    Rey_InterpriseContext.GetInstance().SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
               
            });
        }
    }
}
