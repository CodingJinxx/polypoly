using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HUD.UserControls
{
    public class GridListViewModel
    {
        public event Action RoadSelected;
        public event Action TreeSelected;
        public event Action RockSelected;

        private ICommand _roadCallback;
        private ICommand _treeCallback; 
        private ICommand _rockCallback;

        public ICommand RoadCallback { get => _roadCallback ?? (_roadCallback = new CommandHandler(() => RoadSelected?.Invoke(), () => true)); }
        public ICommand TreeCallback { get => _treeCallback ?? (_treeCallback = new CommandHandler(() => TreeSelected?.Invoke(), () => true)); }
        public ICommand RockCallback { get => _rockCallback ?? (_rockCallback = new CommandHandler(() => RockSelected?.Invoke(), () => true)); }

        public GridListViewModel()
        {
        }


    }
}
