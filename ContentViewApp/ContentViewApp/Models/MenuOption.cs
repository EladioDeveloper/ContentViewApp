using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewApp.Models
{
    class MenuOption
    {
        public MenuOption(string image, string title, string subTitle)
        {
            Image = image;
            Title = title;
            SubTitle = subTitle;
        }

        public string Image { get; }
        public string Title { get; }
        public string SubTitle { get; }
    }
}
