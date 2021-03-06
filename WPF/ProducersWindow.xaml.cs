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
using Galazkiewicz.ProjectTireCatalog.Interfaces;

namespace Galazkiewicz.ProjectTireCatalog.WPF
{
    public partial class ProducersWindow : Window
    {
        public List<IProducer> Producers { get; set; }

        public ProducersWindow()
        {
            Properties.Settings properties = new Properties.Settings();
            BLC.DataProvider dataProvider = new BLC.DataProvider("DAOMock");

            Producers = new List<IProducer>(dataProvider.Producers);

            InitializeComponent();
        }
    }
}
