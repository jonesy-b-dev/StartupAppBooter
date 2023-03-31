using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class SettingsManager
    {

    }


    internal class DarkThemeRenderer : ToolStripProfessionalRenderer
    {
        public DarkThemeRenderer() : base(new DarkTheme()) { }
    }

    public class DarkTheme : ProfessionalColorTable
    {
        // Gets the starting color of the gradient used when 
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(30, 30, 30);

        // Gets the end color of the gradient used when a top-level 
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(30, 30, 30);

        // Gets the solid background color of the 
        public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 30);
        
        // Gets the starting color of the gradient used in the //image 
        public override Color ImageMarginGradientBegin => Color.FromArgb(40, 40, 40);
        
        // Gets the middle color of the gradient used in the //image 
        public override Color ImageMarginGradientMiddle => Color.FromArgb(40, 40, 30);
        
        // Gets the end color of the gradient used in the image 
        public override Color ImageMarginGradientEnd => Color.FromArgb(40, 40, 40);
    }

    internal class LightThemeRenderer : ToolStripProfessionalRenderer
    {
        public LightThemeRenderer() : base(new LightTheme()) { }
    }

    public class LightTheme : ProfessionalColorTable
    {
        // Gets the starting color of the gradient used when 
        public override Color MenuItemPressedGradientBegin => default;

        // Gets the end color of the gradient used when a top-level 
        public override Color MenuItemPressedGradientEnd => default;

        // Gets the solid background color of the 
        public override Color ToolStripDropDownBackground => default;

        // Gets the starting color of the gradient used in the //image 
        public override Color ImageMarginGradientBegin => default;

        // Gets the middle color of the gradient used in the //image 
        public override Color ImageMarginGradientMiddle => default;

        // Gets the end color of the gradient used in the image 
        public override Color ImageMarginGradientEnd => default;
    }
}
