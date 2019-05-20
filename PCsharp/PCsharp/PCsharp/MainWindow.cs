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
            Aceptar.Clicked +=delegate {
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
            vbox2.Visible = true;
            treeview1.Sensitive = false;
            Aceptar.Clicked +=AceptarEdit;
            
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

    void Aceptar_Clicked(object sender, EventArgs e)
    {
    }



    void Aceptar_Clicked(object sender, EventArgs e)
    {
    }



    void Aceptar_Clicked(object sender, EventArgs e)
    {
    }



    void Aceptar_Clicked(object sender, EventArgs e)
    {
    }


    private void AceptarEdit()
    {
        treeview1.Selection.GetSelected(out TreeIter treeIter);
        treeview1.Model.SetValue(treeIter, 0, entry1.Text);
        treeview1.Model.SetValue(treeIter, 1, entry2.Text);
        entry1.Text = "";
        entry2.Text = "";
        vbox2.Visible = false;
        treeview1.Sensitive = true;
    }
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
