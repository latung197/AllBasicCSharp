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

namespace WPF_HelloWord.Form
{
    /// <summary>
    /// Interaction logic for Resource.xaml
    /// </summary>
    public partial class Resource : Window
    {
        // Setup biến toàn cục sử dụng trong tất cả các màn hình thì xử lý trong file App.xaml
        public Resource()
        {
            InitializeComponent();
        }
    }
}