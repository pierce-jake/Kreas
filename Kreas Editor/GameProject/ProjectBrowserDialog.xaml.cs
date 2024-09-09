﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KreasEditor.GameProject
{
    /// <summary>
    /// Interaction logic for ProjectBrowserDialog.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }

        private void OnToggleButton_Click(object sender, RoutedEventArgs e)
        {
            addProjectButton.IsChecked = createProjectButton.IsChecked = false;

            if (sender == addProjectButton)
                browserContent.Margin = new Thickness(-800, 0, 0, 0);
            else
                browserContent.Margin = new Thickness(0, 0, 0, 0);

        }

    }
}
