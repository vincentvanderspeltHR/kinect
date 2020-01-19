// -----------------------------------------------------------------------
// <copyright file="HomeScreenView.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------

using Microsoft.Samples.Kinect.InteractionGallery.ViewModels;

namespace Microsoft.Samples.Kinect.InteractionGallery.Views
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    /// <summary>
    /// Interaction logic for HomeScreenView.xaml
    /// </summary>
    public partial class HomeScreenView : UserControl
    {
        public HomeScreenView()
        {
            this.InitializeComponent();
            //if ()
            //LeftButton.Margin = new Thickness(400, 600, 0, 0);

        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (this.DataContext != null)
            {
                SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);
            }
            else
            {
                SetButtons(0);
            }
        }

        /// <summary>
        /// Handle paging right (next button).
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void PageRightButtonClick(object sender, RoutedEventArgs e)
        {
            (this.DataContext as HomeScreenViewModel).CurrentIndex += 1;
            SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);

            //scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + PixelScrollByAmount);
        }

        /// <summary>
        /// Handle paging left (previous button).
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void PageLeftButtonClick(object sender, RoutedEventArgs e)
        {
            (this.DataContext as HomeScreenViewModel).CurrentIndex -= 1;
            SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);

            //scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset - PixelScrollByAmount);
        }

        private void SetButtons(int currentindex)
        {
            OogtestHover.Visibility = Visibility.Hidden;
            OogtestClick.Visibility = Visibility.Hidden;
            CityClick.Visibility = Visibility.Hidden;
            CityConfirmClick.Visibility = Visibility.Hidden;
            HomeClick.Visibility = Visibility.Hidden;
            DoneClick.Visibility = Visibility.Hidden;

            if (currentindex == 0)
            {
                OogtestHover.Visibility = Visibility.Visible;
            }
            else if (currentindex == 1)
            {
                OogtestClick.Visibility = Visibility.Visible;
            }
            else if (currentindex == 2)
            {
                CityClick.Visibility = Visibility.Visible;
                HomeClick.Visibility = Visibility.Visible;
            }
            else if (currentindex == 3)
            {
                CityConfirmClick.Visibility = Visibility.Visible;
                HomeClick.Visibility = Visibility.Visible;
            }
            else if (currentindex == 4)
            {
                DoneClick.Visibility = Visibility.Visible;
                HomeClick.Visibility = Visibility.Visible;
            }
        }
        private void OogtestHover_click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as HomeScreenViewModel).CurrentIndex = 1;
            SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);

        }

        private void OogtestClick_click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as HomeScreenViewModel).CurrentIndex = 2;
            SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);

        }
        private void CityClick_click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as HomeScreenViewModel).CurrentIndex = 3;
            SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);

        }
        private void CityConfirmClick_click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as HomeScreenViewModel).CurrentIndex = 4;
            SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);

        }
        private void HomeButton_click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as HomeScreenViewModel).CurrentIndex = 0;
            SetButtons((this.DataContext as HomeScreenViewModel).CurrentIndex);

        }
        
    }
}
