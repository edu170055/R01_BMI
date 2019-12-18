using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            double _height = double.Parse(height.Text);
            double _weight = double.Parse(weight.Text);

            double _result = _weight / Math.Pow(_height / 100, 2);
            _result = Math.Round(_result, 2, MidpointRounding.AwayFromZero);
            result.Text = "BMI: " + _result;
        }
    }
}
