﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class SearchBarPage : ContentPage
  {
    private List<String> empresasTI;
    public SearchBarPage()
    {
      InitializeComponent();

      empresasTI = new List<string>();
      empresasTI.Add("Microsoft");
      empresasTI.Add("Apple");
      empresasTI.Add("Oracle");
      empresasTI.Add("IBM");
      empresasTI.Add("Sap");
      empresasTI.Add("Uber");
      empresasTI.Add("99Taxi");

      Preencher(empresasTI);
    }

    private void PesquisarButton(object sender, EventArgs args)
    {
      var resultado = empresasTI.Where(x => x.Contains(((SearchBar)sender).Text)).ToList<String>();

      Preencher(resultado);
    }
    private void Pesquisar(object sender, TextChangedEventArgs args)
    {
      var resultado = empresasTI.Where(x => x.Contains(args.NewTextValue)).ToList<String>();

      Preencher(resultado);
    }
    private void Preencher(List<String> empresasTI)
    {
      ListResult.Children.Clear();
      foreach (var emp in empresasTI)
      {
        ListResult.Children.Add(new Label { Text = emp });
      }
    }
  }
}