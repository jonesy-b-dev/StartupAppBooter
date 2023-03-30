using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class SettingsManager
    {

    }


    internal class CustomMenuStripRenderer : ToolStripProfessionalRenderer
    {
        public CustomMenuStripRenderer() : base(new Themes()) { }
    }

    public class Themes : ProfessionalColorTable
    {
        /// Gets the starting color of the gradient used when 
        /// a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(30, 30, 30);

        /// Gets the end color of the gradient used when a top-level 
        /// System.Windows.Forms.ToolStripMenuItem is pressed.
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(30, 30, 30);

        /// Gets the border color to use with a 
        /// System.Windows.Forms.ToolStripMenuItem.
        public override Color MenuItemBorder => Color.DarkGray;

        /// Gets the starting color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(30, 30, 30);

        /// Gets the end color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(30, 30, 30);

        /// Gets the solid background color of the 
        /// System.Windows.Forms.ToolStripDropDown.
        public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 30);

        /// Gets the starting color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        public override Color ImageMarginGradientBegin => Color.DimGray;

        /// Gets the middle color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        public override Color ImageMarginGradientMiddle => Color.DimGray;

        /// Gets the end color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        public override Color ImageMarginGradientEnd => Color.DimGray;

        /// Gets the color to use to for shadow effects on 
        /// the System.Windows.Forms.ToolStripSeparator.
        public override Color SeparatorDark => Color.Black;

        /// Gets the color that is the border color to use 
        /// on a System.Windows.Forms.MenuStrip.
        public override Color MenuBorder => Color.DarkGray;
    }
}
