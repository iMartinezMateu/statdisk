using System;
using System.Collections.Generic;
using System.IO;
using Gtk;

namespace StatDisk
{
	public partial class StatsWindow : Gtk.Dialog
	{

		public StatsWindow ()
		{
			this.Build ();

		}

		public void rellenarVisor(double[] tiempos, double tamanoFichero)
		{
			Gtk.TextBuffer buffer;
			int i = 1;

			buffer = visorTiempos.Buffer;
			buffer.InsertAtCursor ("Estas son los distintos tiempos obtenidos para la escritura de un fichero con tamaño de " + tamanoFichero + " MB en el primer dispositivo de almacenamiento A.\n");
			buffer.InsertAtCursor ("======================================================================================================\n\n\n");
			foreach (double d in tiempos) {
				buffer.InsertAtCursor( "Tiempo "+ i +" de "+ tiempos.Length +" = " + d.ToString () + " milisegundos.\n");
				i++;

			}

		}

		public void rellenarVisorCalculos(double[] tiempos)
		{
			Gtk.TextBuffer buffer;
			List<double> data = new List<double>();

			buffer = visorCalculos.Buffer;
			buffer.InsertAtCursor ("A continuación se muestra diversos cálculos estadísticos para las cifras temporales obtenidas para una población de " + tiempos.Length + " muestras en el primer dispositivo de almacenamiento A.\n");
			buffer.InsertAtCursor ("=========================================================================================================\n\n\n");
			foreach (double d in tiempos) {
				//Para poder realizar la media, la varianza y otros calculos, nos serviremos de la potencia de C# y las listas, por lo que cogemos cada valor del array y lo metemos en una lista data	
				data.Add (d);
			}
			double media = data.Mean ();
			double varianza = data.Variance ();
			double desviaciontipica = data.StandardDeviation ();

			buffer.InsertAtCursor ("La media aritmetica es de " + media + " milisegundos\n");
			buffer.InsertAtCursor ("La varianza es de " + varianza + " \n");
			buffer.InsertAtCursor ("La desviacion tipica es de " + desviaciontipica + " \n");

			FileStream fs1 = new FileStream("dispositivoA.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer = new StreamWriter(fs1);
			foreach (double d in tiempos)
				writer.Write(d + "\n");
			writer.Close();
			fs1.Close ();

		}

		public void rellenarVisor2(double[] tiempos, double tamanoFichero)
		{
			Gtk.TextBuffer buffer2;
			int i = 1;

			buffer2 = visorTiempos1.Buffer;
			buffer2.InsertAtCursor ("Estas son los distintos tiempos obtenidos para la escritura de un fichero con tamaño de " + tamanoFichero + " MB en el segundo dispositivo de almacenamiento B.\n");
			buffer2.InsertAtCursor ("======================================================================================================\n\n\n");
			foreach (double d in tiempos) {
				buffer2.InsertAtCursor( "Tiempo "+ i +" de "+ tiempos.Length +" = " + d.ToString () + " milisegundos.\n");
				i++;

			}
		}

		public void rellenarVisorCalculos2(double[] tiempos)
		{
			Gtk.TextBuffer buffer2;
			List<double> data2 = new List<double>();

			buffer2 = visorCalculos1.Buffer;
			buffer2.InsertAtCursor ("A continuación se muestra diversos cálculos estadísticos para las cifras temporales obtenidas para una población de " + tiempos.Length + " muestras en el segundo dispositivo de almacenamiento B.\n");
			buffer2.InsertAtCursor ("=========================================================================================================\n\n\n");
			foreach (double d in tiempos) {
				//Para poder realizar la media, la varianza y otros calculos, nos serviremos de la potencia de C# y las listas, por lo que cogemos cada valor del array y lo metemos en una lista data	
				data2.Add (d);
			}
			double media = data2.Mean ();
			double varianza = data2.Variance ();
			double desviaciontipica = data2.StandardDeviation ();

			buffer2.InsertAtCursor ("La media aritmetica es de " + media + " milisegundos\n");
			buffer2.InsertAtCursor ("La varianza es de " + varianza + " \n");
			buffer2.InsertAtCursor ("La desviacion tipica es de " + desviaciontipica + " \n");

			FileStream fs2 = new FileStream("dispositivoB.txt", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter writer2 = new StreamWriter(fs2);
			foreach (double d in tiempos)
				writer2.Write(d + "\n");
			writer2.Close();
			fs2.Close ();

			MessageDialog mensaje4 = new MessageDialog (this, 
				DialogFlags.DestroyWithParent,
				MessageType.Info, 
				ButtonsType.Close, "Los tiempos de escritura se han volcado en ficheros planos que pueden ser encontrados en la ruta del programa para ser importados por Excel o programas similares...");
			int result4 = mensaje4.Run ();
			mensaje4.Destroy();
		}

	

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			MainWindow.Quit ();
		}

	
	}

	//Biblioteca de metodos estadísticos extensores de las listas en c#
	public static class MyListExtensions
	{
		public static double Mean(this List<double> values)
		{
			return values.Count == 0 ? 0 : values.Mean(0, values.Count);
		}

		public static double Mean(this List<double> values, int start, int end)
		{
			double s = 0;

			for (int i = start; i < end; i++)
			{
				s += values[i];
			}

			return s / (end - start);
		}

		public static double Variance(this List<double> values)
		{
			return values.Variance(values.Mean(), 0, values.Count);
		}

		public static double Variance(this List<double> values, double mean)
		{
			return values.Variance(mean, 0, values.Count);
		}

		public static double Variance(this List<double> values, double mean, int start, int end)
		{
			double variance = 0;

			for (int i = start; i < end; i++)
			{
				variance += Math.Pow((values[i] - mean), 2);
			}

			int n = end - start;
			if (start > 0) n -= 1;

			return variance / (n);
		}

		public static double StandardDeviation(this List<double> values)
		{
			return values.Count == 0 ? 0 : values.StandardDeviation(0, values.Count);
		}

		public static double StandardDeviation(this List<double> values, int start, int end)
		{
			double mean = values.Mean(start, end);
			double variance = values.Variance(mean, start, end);

			return Math.Sqrt(variance);
		}
	}
}

