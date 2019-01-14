using System;
using Gtk;
using System.Collections.Generic;
using CBingo;

public partial class MainWindow : Gtk.Window
{

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Panel panel = new Panel(vBox);
        Bombo bombo = new Bombo();

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
