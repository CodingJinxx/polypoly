using System;
using Noesis;
using UnityEngine;
using HUD;
using HUD.UserControls;

namespace DefaultNamespace
{
    public class GridListDataContextAssignment : MonoBehaviour
    {
        public NoesisView view;
        public GridInteractionController controller;
        
        public GridTile RoadTile;
        public GridTile TreeTile;
        public GridTile RockTile;
        
        private ViewModel viewmodel;
        private GridListViewModel gridviewmodel;

        private void Start()
        {
            viewmodel = new ViewModel();
            gridviewmodel = new GridListViewModel();
            
              
            gridviewmodel.RoadSelected += () => controller.CurrentTile = RoadTile;
            gridviewmodel.TreeSelected += () => controller.CurrentTile = TreeTile;
            gridviewmodel.RockSelected += () => controller.CurrentTile = RockTile;
            viewmodel.gridListViewModel = gridviewmodel;
            
            view.Content.DataContext = viewmodel;
        }
    }
}