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
  public partial class EntryEditorPage : ContentPage
  {
    public EntryEditorPage()
    {
      InitializeComponent();

      // Atualiza na hora o texto!!
      txtIdade.TextChanged += delegate (object sender, TextChangedEventArgs args) 
      {
        Lbl_Duplicado.Text = args.NewTextValue;
      };

      // Atualiza após sair do campo input!
      TxtComentario.Completed += delegate (object sender, EventArgs args) 
      {
        LblQuantidadecaracteres.Text = TxtComentario.Text.Length.ToString();
      } ;
    }
  }
}