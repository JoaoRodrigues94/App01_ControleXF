using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Master : MasterDetailPage
  {
    public Master()
    {
      InitializeComponent();
    }

    public void GoActivityIndicator(object sender, EventArgs args)
    {
      Detail = new Controles.ActivityIndicatorPage();
    }    
    public void GoProgressBarPage(object sender, EventArgs args)
    {
      Detail = new Controles.ProgressBarPage();
    }  
    public void GoBoxViewPage(object sender, EventArgs args)
    {
      Detail = new Controles.BoxViewPage();
    }
    public void GoLabelPage(object sender, EventArgs args)
    {
      Detail = new Controles.LabelPage();
    }
    public void GoButtonPage(object sender, EventArgs args)
    {
      Detail = new Controles.ButtonPage();
    }
    public void GoEntryEditorPage(object sender, EventArgs args)
    {
      Detail = new Controles.EntryEditorPage();
    }
    public void GoDatePickerPage(object sender, EventArgs args)
    {
      Detail = new Controles.DatePickerPage();
    }
    public void GoTimePickerPage(object sender, EventArgs args)
    {
      Detail = new Controles.TimpePickerPage();
    }
    public void GoPickerPage(object sender, EventArgs args)
    {
      Detail = new Controles.PickerPage();
    }
    public void GoSearchBarPage(object sender, EventArgs args)
    {
      Detail = new Controles.SearchBarPage();
    }
    public void GoSliderStepperPage(object sender, EventArgs args)
    {
      Detail = new Controles.SliderStepperPage();
    }
    public void GoSwitchPage(object sender, EventArgs args)
    {
      Detail = new Controles.SwitchPage();
    }
    public void GoImagePage(object sender, EventArgs args)
    {
      Detail = new Controles.ImagePage();
    }
    public void GoListViewPage(object sender, EventArgs args)
    {
      Detail = new Controles.ListViewPage();
    }
    public void GoTableViewPage(object sender, EventArgs args)
    {
      Detail = new Controles.TableViewPage();
    }
    public void GoWebViewPage(object sender, EventArgs args)
    {
      Detail = new Controles.WebViewPage();
    }
  }
}