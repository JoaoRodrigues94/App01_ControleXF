using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class SliderStepperPage : ContentPage
  {
    public SliderStepperPage()
    {
      InitializeComponent();
    }

    private void ActionValorMudou(Object sender, ValueChangedEventArgs args)
    {
      SliderResult.Text = args.NewValue.ToString();
    }

    private void ActionValorMudouStepper(Object sender, ValueChangedEventArgs args)
    {
      SteperResult.Text = args.NewValue.ToString();
    }
  }
}