using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public System.Action accionAceptar = null;
    private ListStore listStore = new ListStore(typeof(String), typeof(String));
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        treeview1.AppendColumn("Nombre", new CellRendererText(), "text", 0);
        treeview1.AppendColumn("Teléfono", new CellRendererText(), "text", 1);

        treeview1.Model = listStore;
        vbox1.Sensitive = true;
        listStore.AppendValues("Eiron", "67457567");
        editAction.Sensitive = false;
        vbox2.Visible = false;

        newAction.Activated += (sender, e) =>
        {
            vbox2.Visible = true;
            treeview1.Sensitive = false;
            accionAceptar = () =>Aceptar.Clicked +=delegate {
                listStore.AppendValues(entry1.Text, entry2.Text);
                entry1.Text = "";
                entry2.Text = "";
                vbox2.Visible = false;
                treeview1.Sensitive = true;
            };
            Cancelar.Clicked += delegate {
                entry1.Text = "";
                entry2.Text = "";
                vbox2.Visible = false;
                treeview1.Sensitive = true;
            };
        };
        editAction.Activated += (sender, e) =>
        {
            /*vbox2.Visible = true;
            treeview1.Sensitive = false;*/
            accionAceptar = () => editar();
            Cancelar.Clicked += delegate {
                entry1.Text = "";
                entry2.Text = "";
                vbox2.Visible = false;
                treeview1.Sensitive = true;
            };


        };
        treeview1.Selection.Changed+=(sender, e) => 
        editAction.Sensitive = treeview1.Selection.CountSelectedRows() > 0;
      //  treeview1.Selection.Changed += (sender, e) => Console.WriteLine("La selección ha cambiado", treeview1.Selection.CountSelectedRows());



    }
    private void editar(){
        vbox2.Visible = true;
        treeview1.Sensitive = false;

    }
    private void nuevo(){
        Aceptar.Clicked += delegate
        {
            listStore.AppendValues(entry1.Text, entry2.Text);
            entry1.Text = "";
            entry2.Text = "";
            vbox2.Visible = false;
            treeview1.Sensitive = true;
        };

    }







    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
