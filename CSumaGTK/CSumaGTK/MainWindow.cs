using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        suma.Clicked+=delegate {
            result.Show();
            int resultado = Convert.ToInt32(entryOne.Text) + Convert.ToInt32(entryTwo.Text);
            result.Text = Convert.ToString(resultado);
        };
        resta.Clicked += delegate {
            result.Show();

            int resultado = Convert.ToInt32(entryOne.Text) - Convert.ToInt32(entryTwo.Text);
            result.Text = Convert.ToString(resultado);
        };
        division.Clicked += delegate {
            result.Show();
            double resultado = Convert.ToDouble(entryOne.Text) / Convert.ToDouble(entryTwo.Text);
            result.Text = Convert.ToString(resultado);
        };
        multiplicacion.Clicked += delegate {
            result.Show();
            int resultado = Convert.ToInt32(entryOne.Text) * Convert.ToInt32(entryTwo.Text);
            result.Text = Convert.ToString(resultado);
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
