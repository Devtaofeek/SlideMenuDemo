﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PropertyChanged;
using SlideMenuDemo.Views;

namespace SlideMenuDemo.ViewModels
{
	[ImplementPropertyChanged]
	public class MainViewModel
	{
		public MainViewModel()
		{
			Position = 0;
			ItemsSource = new ObservableCollection<int>() { 0, 1 };
			TemplateSelector = new MyTemplateSelector(); //new DataTemplate (typeof(MyView));
		}

		public int Position { get; set; }

		public ObservableCollection<int> ItemsSource { get; set; }

		public MyTemplateSelector TemplateSelector { get; set; }
	}
}
