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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DnD_Project.CharacterModule;

namespace DnD_Project
{
    /// <summary>
    /// Логика взаимодействия для CharSheet.xaml
    /// </summary>
    public partial class CharSheet : UserControl
    {
        private Character _character;
        public CharSheet(Character character)
        {
            InitializeComponent();
            CharacterName.Text = character.Name.ToString();
        }
    }
}
