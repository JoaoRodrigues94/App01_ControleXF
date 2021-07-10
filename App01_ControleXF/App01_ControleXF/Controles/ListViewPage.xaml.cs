using App01_ControleXF.Modelo;
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
  public partial class ListViewPage : ContentPage
  {
    public ListViewPage()
    {
      InitializeComponent();

      List<Pessoa> lista = new List<Pessoa>();
      lista.Add(new Pessoa { nome = "José", idade = "20" });
      lista.Add(new Pessoa { nome = "Apolo", idade = "2" });
      lista.Add(new Pessoa { nome = "João Paulo", idade = "26" });
      lista.Add(new Pessoa { nome = "Ana", idade = "66" });
      lista.Add(new Pessoa { nome = "Paulo", idade = "67" });

      ListaPessoas.ItemsSource = lista;
    }
  }
}