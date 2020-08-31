using System.Windows.Forms;

namespace Tic
{
    //Contract für GUI
    public interface IGUIController
    {
        string TopLeftButtonContent { get; set; }
        string TopCenterButtonContent { get; set; }
        string TopRightButtonContent { get; set; }

        string CenterLeftButtonContent { get; set; }
        string CenterButtonContent { get; set; }
        string CenterRightButtonContent { get; set; }

        string BottomLeftButtonContent { get; set; }
        string BottomCenterButtonContent { get; set; }
        string BottomRightButtonContent { get; set; }

    }
}