using ContentViewApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContentViewApp.ViewModels
{
    class MenuOptionViewModel : INotifyPropertyChanged
    {
        public MenuOption BarsAndHotelsMenuOption   { get; } = new MenuOption("Bar and Hotels", "beer.png", "42 Place");
        public MenuOption FineDiningMenuOption      { get; } = new MenuOption("Fine Dining", "serving_dish.png", "15 Place");
        public MenuOption CafesMenuOption           { get; } = new MenuOption("Cafes", "coffee_shop.png", "28 Place");
        public MenuOption NearbyMenuOption          { get; } = new MenuOption("Nearby", "destination.png", "34 Place");
        public MenuOption FastFoodsMenuOption       { get; } = new MenuOption("Fast Foods", "fast_food.png", "29 Place");
        public MenuOption FeaturedFoodsMenuOption   { get; } = new MenuOption("Featured Foods", "pizza.png", "21 Place");

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
