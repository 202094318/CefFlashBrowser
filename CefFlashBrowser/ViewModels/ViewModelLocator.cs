﻿using SimpleMvvm.Locator;

namespace CefFlashBrowser.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        public ViewModelLocator()
        {
            Register<MainWindowViewModel>();
            Register<BrowserWindowViewModel>();
        }

        public MainWindowViewModel MainWindowViewModel
        {
            get => GetInstance<MainWindowViewModel>();
        }

        public BrowserWindowViewModel BrowserWindowViewModel
        {
            get => GetInstance<BrowserWindowViewModel>();
        }
    }
}