#if UNITY_5_3_OR_NEWER
using Noesis;
#else
using System.Windows.Media;

#endif

namespace Main
{
    /// <summary>
    /// Interaction logic for application ViewModel
    /// </summary>
    public partial class ViewModel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        public ViewModel()
        {
            TopColor = Color.FromRgb(17, 102, 157);
            BottomColor = Color.FromRgb(18, 57, 87);
        }
    }
}
