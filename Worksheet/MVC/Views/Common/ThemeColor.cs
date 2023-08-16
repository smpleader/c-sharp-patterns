using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unvell.ReoGrid;

namespace Worksheet.MVC.Views.Common
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static string ColorDefault = "#018790";
        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#0E3441",
                                                                    "#00B0AD",
                                                                    "#721D47",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        [Obsolete]
        public static ControlAppearanceStyle DefaultControlReoGridStyle()
        {
            ControlAppearanceStyle rgcs = new ControlAppearanceStyle();
            rgcs[ControlAppearanceColors.LeadHeadNormal] = Color.FromArgb(255, 230, 230, 250);
            rgcs[ControlAppearanceColors.LeadHeadHover] = Color.FromArgb(0, 0, 0, 0);
            rgcs[ControlAppearanceColors.LeadHeadSelected] = Color.FromArgb(255, 230, 230, 250);
            rgcs[ControlAppearanceColors.LeadHeadIndicatorStart] = Color.FromArgb(255, 220, 220, 220);
            rgcs[ControlAppearanceColors.LeadHeadIndicatorEnd] = Color.FromArgb(255, 192, 192, 192);
            rgcs[ControlAppearanceColors.ColHeadSplitter] = Color.FromArgb(255, 176, 196, 222);
            rgcs[ControlAppearanceColors.ColHeadNormalStart] = Color.FromArgb(255, 255, 255, 255);
            rgcs[ControlAppearanceColors.ColHeadNormalEnd] = Color.FromArgb(255, 230, 230, 250);
            rgcs[ControlAppearanceColors.ColHeadHoverStart] = Color.FromArgb(255, 208, 208, 208);
            rgcs[ControlAppearanceColors.ColHeadHoverEnd] = Color.FromArgb(255, 208, 208, 208);
            rgcs[ControlAppearanceColors.ColHeadSelectedStart] = Color.FromArgb(255, 208, 208, 208);
            rgcs[ControlAppearanceColors.ColHeadSelectedEnd] = Color.FromArgb(255, 208, 208, 208);
            rgcs[ControlAppearanceColors.ColHeadFullSelectedStart] = Color.FromArgb(255, 245, 245, 245);
            rgcs[ControlAppearanceColors.ColHeadFullSelectedEnd] = Color.FromArgb(255, 208, 208, 208);
            rgcs[ControlAppearanceColors.ColHeadInvalidStart] = Color.FromArgb(0, 0, 0, 0);
            rgcs[ControlAppearanceColors.ColHeadInvalidEnd] = Color.FromArgb(0, 0, 0, 0);
            rgcs[ControlAppearanceColors.ColHeadText] = Color.FromArgb(255, 0, 0, 139);
            rgcs[ControlAppearanceColors.RowHeadSplitter] = Color.FromArgb(255, 176, 196, 222);
            rgcs[ControlAppearanceColors.RowHeadNormal] = Color.FromArgb(255, 240, 248, 255);
            rgcs[ControlAppearanceColors.RowHeadHover] = Color.FromArgb(255, 176, 196, 222);
            rgcs[ControlAppearanceColors.RowHeadSelected] = Color.FromArgb(255, 208, 208, 208);
            rgcs[ControlAppearanceColors.RowHeadFullSelected] = Color.FromArgb(255, 208, 208, 208);
            rgcs[ControlAppearanceColors.RowHeadInvalid] = Color.FromArgb(0, 0, 0, 0);
            rgcs[ControlAppearanceColors.RowHeadText] = Color.FromArgb(255, 0, 0, 139);
            rgcs[ControlAppearanceColors.SelectionBorder] = Color.FromArgb(180, 0, 120, 215);
            rgcs[ControlAppearanceColors.SelectionFill] = Color.FromArgb(30, 0, 120, 215);
            rgcs[ControlAppearanceColors.GridBackground] = Color.FromArgb(255, 255, 255, 255);
            rgcs[ControlAppearanceColors.GridText] = Color.FromArgb(255, 0, 0, 0);
            rgcs[ControlAppearanceColors.GridLine] = Color.FromArgb(255, 208, 215, 229);
            rgcs[ControlAppearanceColors.OutlinePanelBorder] = Color.FromArgb(255, 192, 192, 192);
            rgcs[ControlAppearanceColors.OutlinePanelBackground] = Color.FromArgb(255, 240, 240, 240);
            rgcs[ControlAppearanceColors.OutlineButtonBorder] = Color.FromArgb(255, 0, 0, 0);
            rgcs[ControlAppearanceColors.OutlineButtonText] = Color.FromArgb(255, 0, 0, 0);
            rgcs[ControlAppearanceColors.SheetTabBorder] = Color.FromArgb(255, 0, 120, 215);
            rgcs[ControlAppearanceColors.SheetTabBackground] = Color.FromArgb(255, 255, 255, 255);
            rgcs[ControlAppearanceColors.SheetTabText] = Color.FromArgb(255, 0, 0, 0);
            rgcs[ControlAppearanceColors.SheetTabSelected] = Color.FromArgb(255, 255, 255, 255);

            return rgcs;
        }

    }

}
