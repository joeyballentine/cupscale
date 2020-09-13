using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cupscale.Forms;
using Cupscale.IO;
using ImageMagick;
using Paths = Cupscale.IO.Paths;

namespace Cupscale
{
	internal static class Program
	{
		public static MainForm mainForm;
		public static string lastFilename;
		public static string lastModelName;
		public static FilterType currentFilter = FilterType.Point;

		[STAThread]
		private static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.EnableVisualStyles();
			DialogForm dialogForm = new DialogForm("Initializing...");
			Console.WriteLine("Main()");
			Config.Init();
			Paths.Init();
			ShippedEsrgan.Init();
			EsrganData.CheckModelDir();
			dialogForm.Close();
			Application.Run(new MainForm());
		}



		public static async Task PutTaskDelay()
		{
			await Task.Delay(1);
		}
	}
}
