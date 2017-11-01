using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ultimate_GamingPCsUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void cbProductSlector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string pSelected = "";

            var comboBoxItem = cbProductSlector.Items[cbProductSlector.SelectedIndex] as ComboBoxItem;
            if (comboBoxItem != null)
            {
                pSelected = comboBoxItem.Content.ToString();
            }
            try
            {
                WebServiceUGP.UGPWebServiceSoapClient serviceUGPWebDetails = new WebServiceUGP.UGPWebServiceSoapClient();
                WebServiceUGP.GetPcDetailsResponse UGPWebResponse = await serviceUGPWebDetails.GetPcDetailsAsync(pSelected);

                txtProductTitle.Text = UGPWebResponse.Body.GetPcDetailsResult.ProductTitle;
                txtProductDescription.Text = UGPWebResponse.Body.GetPcDetailsResult.ProductDescription;
                txtProductPrice.Text = "$" + UGPWebResponse.Body.GetPcDetailsResult.ProductPrice;
            }
            catch (Exception)
            {
                var dialog = new MessageDialog("An error has occourd trying to access the web resorce.");
                await dialog.ShowAsync();
            }
        }
    }
}
