using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewApp.Models
{
    class MenuOption
    {
        public MenuOption(string title, string image, string subTitle)
        {
            Title = title;
            Image = image;
            SubTitle = subTitle;
        }

        public string Image { get; }
        public string Title { get; }
        public string SubTitle { get; }
    }
}
