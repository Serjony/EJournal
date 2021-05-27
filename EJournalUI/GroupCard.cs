﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace EJournalUI
{
    public class GroupCard : Border
    {
        public GroupCard()
        {
            Height = 70;
            Width = 563;
            BorderThickness = new Thickness(3);
            BorderBrush = Brushes.Black;
            Margin = new Thickness(2);

            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(126, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(149, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(282, GridUnitType.Star) });

            Child = grid;
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "SomeText";
            textBlock.Margin = new Thickness(15, 22, 15, 24);
            textBlock.TextAlignment = TextAlignment.Center;
            Grid.SetColumn(textBlock, 0);
            grid.Children.Add(textBlock);

            textBlock = new TextBlock();
            textBlock.Text = "Students count:";
            textBlock.Margin = new Thickness(0, 23, 59, 23);
            textBlock.TextAlignment = TextAlignment.Center;
            Grid.SetColumn(textBlock, 1);
            grid.Children.Add(textBlock);

            textBlock = new TextBlock();
            textBlock.Text = "20";
            textBlock.Margin = new Thickness(89, 23, 1, 23);
            textBlock.TextAlignment = TextAlignment.Center;
            Grid.SetColumn(textBlock, 1);
            grid.Children.Add(textBlock);

            Button button = new Button();
            button.Width = 40;
            button.Margin = new Thickness(140, 20, 4, 20);

            button.Content = "Edit";
            Grid.SetColumn(button, 2);

            grid.Children.Add(button);
        }
    }
}