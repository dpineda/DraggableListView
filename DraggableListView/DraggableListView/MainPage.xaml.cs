using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace DraggableListView
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<CellItem> Items1 { get; set; }
        public MainPage()
        {
			Items1 = new ObservableCollection<CellItem>(new List<CellItem>() {
				new CellItem(){Name="Test1", Height=60.0},
				new CellItem(){Name="Test2", Height=80.0},
				new CellItem(){Name="Test3", Height=80.0},
			});
            InitializeComponent();
            this.BindingContext = this;
        }

    }

	public class CellItem
	{
		public string Name { set; get; }
		public double Height { set; get; }
	}
}
