using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace LoginApp.Helpers
{
    internal class Helper
    {
        internal static void ToggalTheme(Grid myGrid, Button WDbtn, Button regBtn, Label hading, ref int count)
        {
            if (count == 1)
            {
                // Light Mode
                WDbtn.Text = "Light";
                WDbtn.TextColor = Colors.Black;
                WDbtn.BackgroundColor = Colors.White;
                regBtn.BackgroundColor = Color.FromRgb(255, 191, 52);
                regBtn.TextColor = Colors.Black;

                foreach (var child in myGrid.Children)
                {
                    myGrid.BackgroundColor = Colors.Black;
                    hading.TextColor = Color.FromRgb(255, 191, 52);

                    if (child is Label label)
                    {
                        label.TextColor = Colors.White;
                        label.BackgroundColor = Colors.Black;
                    }
                    else if (child is Entry entry)
                    {
                        entry.TextColor = Colors.White;
                        entry.PlaceholderColor = Colors.Gray;
                    }
                    else if (child is Picker picker)
                    {
                        picker.TextColor = Colors.White;
                    }
                    else if (child is CheckBox check)
                    {
                        check.Color = Colors.Blue;
                    }
                }

                count = 0;
            }
            else
            {
                // Dark Mode
                WDbtn.Text = "Dark";

                foreach (var child in myGrid.Children)
                {
                    myGrid.BackgroundColor = Colors.White;
                    hading.TextColor = Color.FromRgb(255, 191, 52);

                    if (child is Label label)
                    {
                        label.TextColor = Colors.Black;
                        label.BackgroundColor = Colors.Transparent;
                    }
                    else if (child is Button button)
                    {
                        button.TextColor = Colors.White;
                        button.BackgroundColor = Colors.Black;
                    }
                    else if (child is Entry entry)
                    {
                        entry.TextColor = Colors.Black;
                        entry.PlaceholderColor = Colors.Gray;
                    }
                    else if (child is Picker picker)
                    {
                        picker.TextColor = Colors.Black;
                    }
                    else if (child is CheckBox check)
                    {
                        check.Color = Colors.Blue;
                    }
                }

                count = 1;
            }
        }


    }
}
