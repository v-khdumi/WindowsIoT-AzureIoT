﻿using AzureIoT.DigitalTwins.Core.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureIoT.DigitalTwins.Core.Navigation
{
    public interface INavigationService
    {
        void Configure(AppViews viewKey, Type viewType);
        void InitializeCurrentRootView(object currentRootView);
        void InitializeRootView(object rootView);
        void GoBack();
        void NavigateTo(AppViews viewKey);
        void NavigateTo(AppViews viewKey, object parameter);
        void SwitchToRootViewAsMainNavigationView();
        void ClearViewStack();
    }
}
