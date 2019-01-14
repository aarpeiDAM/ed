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
        button2.Clicked+= delegate {
            int numero=bombo.sacarBola();
            Console.WriteLine("Se ha de marcar el número: "+numero);
            panel.Marcar(numero);
            button2.Sensitive = bombo.quedanBolas();
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
