using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tutorial
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        IList<Content> contents;
        int currentIndex = 0;
        public MainPage()
        {
            this.InitializeComponent();
            contents = new List<Content>
            {
                new Content("/maymay.jpg", "Maynard", "Maynard loves to sit."),
                new Content("/maynard.jpg", "Maynard", "Maynard loves to lay.")
            };
            SetContent(currentIndex);
        }

        private void SetContent(int index)
        {
            BitmapImage bitmapImage = new BitmapImage();
            // Call BaseUri on the root Page element and combine it with a relative path
            // to consruct an absolute URI.
            bitmapImage.UriSource = new Uri(this.BaseUri, contents[currentIndex].ImagePath);
            ContentImage.Source = bitmapImage;
            ContentHeader.Text = contents[currentIndex].Header;
            ContentText.Text = contents[currentIndex].Text;
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            if(currentIndex > 0)
            {
                SetContent(--currentIndex);
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < contents.Count-1)
            {
                SetContent(++currentIndex);
            }
        }
    }
}
