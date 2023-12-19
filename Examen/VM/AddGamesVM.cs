using Examen.DB;
using Examen.Models;
using Examen.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Examen.VM
{
    internal class AddGamesVM : BaseTool
    {
        public List<Pegi> PEGI1 { get; set; }
        public string Title { get; set; }
        public Pegi PEGI2 { get; set; }
        public CommandVM SaveGame { get; set; }
        public AddGamesVM()
        {
            PEGI1 = Rey_InterpriseContext.GetInstance().Pegis.ToList();

            SaveGame = new CommandVM(() =>
            {
                var add = Rey_InterpriseContext.GetInstance().Games.Add(new Game { Title = Title, Pegiid = PEGI2.Id });
                Rey_InterpriseContext.GetInstance().SaveChanges();
                MessageBox.Show("Сохранилось");
            });

        }
    }
}
