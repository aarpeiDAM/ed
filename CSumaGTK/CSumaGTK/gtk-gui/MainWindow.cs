
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Entry entryOne;

	private global::Gtk.Entry entryTwo;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Button suma;

	private global::Gtk.Button resta;

	private global::Gtk.Button multiplicacion;

	private global::Gtk.Button division;

	private global::Gtk.Label result;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryOne = new global::Gtk.Entry();
		this.entryOne.CanFocus = true;
		this.entryOne.Name = "entryOne";
		this.entryOne.IsEditable = true;
		this.entryOne.InvisibleChar = '•';
		this.hbox2.Add(this.entryOne);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryOne]));
		w1.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryTwo = new global::Gtk.Entry();
		this.entryTwo.CanFocus = true;
		this.entryTwo.Name = "entryTwo";
		this.entryTwo.IsEditable = true;
		this.entryTwo.InvisibleChar = '•';
		this.hbox2.Add(this.entryTwo);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entryTwo]));
		w2.Position = 1;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.suma = new global::Gtk.Button();
		this.suma.CanFocus = true;
		this.suma.Name = "suma";
		this.suma.UseStock = true;
		this.suma.UseUnderline = true;
		this.suma.Label = "Suma";
		this.hbox1.Add(this.suma);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.suma]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.resta = new global::Gtk.Button();
		this.resta.CanFocus = true;
		this.resta.Name = "resta";
		this.resta.UseStock = true;
		this.resta.UseUnderline = true;
		this.resta.Label = "Resta";
		this.hbox1.Add(this.resta);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.resta]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.multiplicacion = new global::Gtk.Button();
		this.multiplicacion.CanFocus = true;
		this.multiplicacion.Name = "multiplicacion";
		this.multiplicacion.UseStock = true;
		this.multiplicacion.UseUnderline = true;
		this.multiplicacion.Label = "Multiplicación";
		this.hbox1.Add(this.multiplicacion);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.multiplicacion]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.division = new global::Gtk.Button();
		this.division.CanFocus = true;
		this.division.Name = "division";
		this.division.UseStock = true;
		this.division.UseUnderline = true;
		this.division.Label = "División";
		this.hbox1.Add(this.division);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.division]));
		w7.Position = 3;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.result = new global::Gtk.Label();
		this.result.Name = "result";
		this.result.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
		this.vbox1.Add(this.result);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.result]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 326;
		this.DefaultHeight = 300;
		this.result.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
