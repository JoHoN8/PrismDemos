﻿using Prism.Modularity;
using System.Windows;

namespace PrismSingle.Views
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell(IModuleManager moduleManager)
        {
            InitializeComponent();
        }
    }
}
