#if UNITY_5_3_OR_NEWER
using Noesis;
#else
using System.Windows.Media;

#endif
using HUD.UserControls;

namespace HUD
{
    /// <summary>
    /// Interaction logic for application ViewModel
    /// </summary>
    public partial class ViewModel
    {
        public GridListViewModel gridListViewModel { get; set; }

        public ViewModel()
        {
            gridListViewModel = new GridListViewModel();
        }
    }
}
