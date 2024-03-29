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

namespace Kita2508_Q4
{
    /// <summary>
    /// Interaction logic for SliderUserControl.xaml
    /// </summary>
    public partial class SliderUserControl : UserControl
    {
        public SliderUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Title { get; set; }

        public int MaxLength { get; set; }
        public int SliderVal { get; set; }
        public int MinLength { get; set; }

        //public string ConverterResource { get; set; }
    }
}
