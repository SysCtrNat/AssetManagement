﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EnterpriseManagement.ServiceManager.Application.Common;

namespace AssetManagementForms
{
    /// <summary>
    /// Interaction logic for NetworkInfraStructureAssetPreview.xaml
    /// </summary>
    public partial class NetworkInfraStructureAssetPreview : UserControl
    {
        //private readonly RelatedItemsPane _relatedItemsPane;
        public NetworkInfraStructureAssetPreview()
		{
			InitializeComponent();
		//	_relatedItemsPane = new RelatedItemsPane(new ConfigItemRelatedItemsConfiguration());
		//	tabItemRelItems.Content = _relatedItemsPane;
		}
    }
}
