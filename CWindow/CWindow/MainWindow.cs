using System;
using Gtk;
using CWindow;
public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Title = "Mi ventana principal";
        button1.Clicked+=delegate {
            //if (WindowHelper.Confirm(this, "Quieres tomar algo?"))
            //Console.WriteLine("Ha dicho Yes");
            new MyWindow();
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
