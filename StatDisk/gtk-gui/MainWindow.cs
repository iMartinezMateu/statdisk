
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Label label1;
	private global::Gtk.HBox hbox2;
	private global::Gtk.VBox vbox3;
	private global::Gtk.HBox hbox3;
	private global::Gtk.HBox hbox9;
	private global::Gtk.Label label2;
	private global::Gtk.VBox vbox4;
	private global::Gtk.FileChooserWidget dialogoRuta;
	private global::Gtk.Label label5;
	private global::Gtk.FileChooserWidget dialogoRuta1;
	private global::Gtk.Label label4;
	private global::Gtk.SpinButton spinTamanoFichero;
	private global::Gtk.Label label3;
	private global::Gtk.SpinButton spinNumeroFicheros;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Button botonSalir;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Button botonCalcular;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("StatDisk");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.DefaultWidth = 800;
		this.DefaultHeight = 600;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 0F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Este programa es capaz de analizar el rendimiento de escritura de un medio de almacenamiento\ncualquiera.\nPara continuar con el test, es necesario proporcionar algunos datos.");
		this.vbox2.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox ();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Ubicación del primer medio de almacenamiento A a comparar donde almacenar los ficheros (asegurate de tener privilegios de escritura sobre ella)");
		this.hbox9.Add (this.label2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label2]));
		w2.Position = 0;
		this.hbox3.Add (this.hbox9);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbox9]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox3.Add (this.hbox3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		this.hbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
		w6.Position = 1;
		w6.Expand = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.dialogoRuta = new global::Gtk.FileChooserWidget (((global::Gtk.FileChooserAction)(2)));
		this.dialogoRuta.Name = "dialogoRuta";
		this.vbox4.Add (this.dialogoRuta);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.dialogoRuta]));
		w7.Position = 0;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.Xalign = 0F;
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Ubicación del segundo medio de almacenamiento B a comparar donde almacenar los ficheros (asegurate de tener privilegios de escritura sobre ella)");
		this.vbox4.Add (this.label5);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label5]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.dialogoRuta1 = new global::Gtk.FileChooserWidget (((global::Gtk.FileChooserAction)(2)));
		this.dialogoRuta1.Name = "dialogoRuta1";
		this.vbox4.Add (this.dialogoRuta1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.dialogoRuta1]));
		w9.Position = 2;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.Xalign = 0F;
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Tamaño de fichero a crear en MB");
		this.vbox4.Add (this.label4);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label4]));
		w10.Position = 3;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.spinTamanoFichero = new global::Gtk.SpinButton (1, 1024, 0.5);
		this.spinTamanoFichero.CanFocus = true;
		this.spinTamanoFichero.Name = "spinTamanoFichero";
		this.spinTamanoFichero.Adjustment.PageIncrement = 10;
		this.spinTamanoFichero.ClimbRate = 1;
		this.spinTamanoFichero.Digits = ((uint)(2));
		this.spinTamanoFichero.Numeric = true;
		this.spinTamanoFichero.Value = 5.5;
		this.vbox4.Add (this.spinTamanoFichero);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.spinTamanoFichero]));
		w11.Position = 4;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.Xalign = 0F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Número de ficheros a crear");
		this.vbox4.Add (this.label3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label3]));
		w12.Position = 5;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.spinNumeroFicheros = new global::Gtk.SpinButton (1, 300, 1);
		this.spinNumeroFicheros.CanFocus = true;
		this.spinNumeroFicheros.Name = "spinNumeroFicheros";
		this.spinNumeroFicheros.Adjustment.PageIncrement = 10;
		this.spinNumeroFicheros.ClimbRate = 1;
		this.spinNumeroFicheros.Numeric = true;
		this.spinNumeroFicheros.Value = 1;
		this.vbox4.Add (this.spinNumeroFicheros);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.spinNumeroFicheros]));
		w13.Position = 6;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox2.Add (this.vbox4);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox4]));
		w14.Position = 2;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.botonSalir = new global::Gtk.Button ();
		this.botonSalir.CanFocus = true;
		this.botonSalir.Name = "botonSalir";
		this.botonSalir.UseUnderline = true;
		this.botonSalir.Label = global::Mono.Unix.Catalog.GetString ("Salir");
		this.hbox1.Add (this.botonSalir);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.botonSalir]));
		w15.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		this.hbox1.Add (this.hbox6);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox6]));
		w16.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.botonCalcular = new global::Gtk.Button ();
		this.botonCalcular.CanFocus = true;
		this.botonCalcular.Name = "botonCalcular";
		this.botonCalcular.UseUnderline = true;
		this.botonCalcular.Label = global::Mono.Unix.Catalog.GetString ("Calcular");
		this.hbox1.Add (this.botonCalcular);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.botonCalcular]));
		w17.Position = 2;
		this.vbox2.Add (this.hbox1);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
		w18.Position = 3;
		w18.Expand = false;
		w18.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w19.Position = 0;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.botonSalir.Clicked += new global::System.EventHandler (this.OnBotonSalirClicked);
		this.botonCalcular.Clicked += new global::System.EventHandler (this.OnBotonCalcularClicked);
	}
}
