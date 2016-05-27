using System;
using Gtk;
using System.IO;
using System.Diagnostics;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}




	public bool calcular(String ruta, String ruta2, int numeroFicheros, double tamanoFichero)
	{
		double[] tiempos = new double[numeroFicheros];
		double[] tiempos2 = new double[numeroFicheros];

		int i = 0;
		for (i = 0; i < numeroFicheros; i++) {
			Stopwatch sw = Stopwatch.StartNew(); //Empezamos a contar el tiempo...
			FileStream fs1 = new FileStream(ruta + "/archivo", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer = new StreamWriter(fs1);
			while (fs1.Length < tamanoFichero*1048576) //Pasamos de MB a bytes.
				writer.Write("a");
			writer.Close();
			fs1.Close ();
			sw.Stop(); //Paramos el tiempo...
			TimeSpan elapsedTime = sw.Elapsed;
			tiempos[i]=elapsedTime.TotalMilliseconds;
			File.Delete (ruta + "/archivo"); //Eliminamos el fichero
		}
		for (i = 0; i < numeroFicheros; i++) {
			Stopwatch sw2 = Stopwatch.StartNew(); //Empezamos a contar el tiempo...
			FileStream fs2 = new FileStream(ruta2 + "/archivo", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer2 = new StreamWriter(fs2);
			while (fs2.Length < tamanoFichero*1048576) //Pasamos de MB a bytes.
				writer2.Write("a");
			writer2.Close();
			fs2.Close ();
			sw2.Stop(); //Paramos el tiempo...
			TimeSpan elapsedTime2 = sw2.Elapsed;
			tiempos2[i]=elapsedTime2.TotalMilliseconds;
			File.Delete (ruta2 + "/archivo"); //Eliminamos el fichero
		}
		StatDisk.StatsWindow Form = new StatDisk.StatsWindow ();
		Form.Show ();
		Form.rellenarVisor (tiempos,tamanoFichero);
		Form.rellenarVisorCalculos (tiempos);
		Form.rellenarVisor2 (tiempos2,tamanoFichero);
		Form.rellenarVisorCalculos2 (tiempos2);
		this.Hide ();

		return true;
	}


	protected void OnBotonSalirClicked (object sender, EventArgs e)
	{
		Application.Quit ();
	}

	protected void OnBotonCalcularClicked (object sender, EventArgs e)
	{
	
		String ruta = dialogoRuta.CurrentFolder.ToString();
		String ruta2 = dialogoRuta1.CurrentFolder.ToString();
			int numeroFicheros = spinNumeroFicheros.ValueAsInt;
			double tamanoFichero = spinTamanoFichero.Value;
		if (calcular (ruta,ruta2,numeroFicheros,tamanoFichero) == true) {
				MessageDialog mensaje2 = new MessageDialog (this, 
					DialogFlags.DestroyWithParent,
					MessageType.Info, 
					ButtonsType.Close, "El analisis se ha llevado a cabo con exito.");
				int result2 = mensaje2.Run ();
				mensaje2.Destroy();
				
			} else {
				MessageDialog mensaje3 = new MessageDialog (this, 
					DialogFlags.DestroyWithParent,
					MessageType.Error, 
					ButtonsType.Close, "Ha ocurrido un error y no se ha podido realizar el analisis. Vuelve a intentarlo más tarde...");
					int result3 = mensaje3.Run ();
					mensaje3.Destroy();
			}
		}
	
	public static void Quit()
	{
		Application.Quit ();
	}
}
