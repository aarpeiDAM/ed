using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        treeview1.AppendColumn("Nombre", new CellRendererText(), "text", 0);
        treeview1.AppendColumn("Teléfono", new CellRendererText(), "text", 1);
        ListStore listStore = new ListStore(typeof(String), typeof(String));
        treeview1.Model = listStore;
        listStore.AppendValues("Eiron", "67457567");
        editAction.Sensitive = false;
        table1.Sensitive = false;
        newAction.Activate
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
