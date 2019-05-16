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
        vbox1.Sensitive = true;
        listStore.AppendValues("Eiron", "67457567");
        editAction.Sensitive = false;
        vbox2.Visible = false;
        newAction.Activated += (sender, e) =>
        {
            vbox2.Visible = true;
            treeview1.Sensitive = false;    
        };
        editAction.Activated += (sender, e) =>
        {
            vbox2.Visible = true;
            treeview1.Sensitive = false;

        };
        treeview1.Selection.Changed+=(sender, e) => 
        editAction.Sensitive = treeview1.Selection.CountSelectedRows() > 0;
      //  treeview1.Selection.Changed += (sender, e) => Console.WriteLine("La selección ha cambiado", treeview1.Selection.CountSelectedRows());



    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
