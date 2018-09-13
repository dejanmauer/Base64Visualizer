using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Base64Visualizer;

[assembly: DebuggerVisualizer(typeof(Base64Viewer), Target = typeof(string), Description = "Base64 visualizer")]
public class Base64Viewer : DialogDebuggerVisualizer
{
	protected override void Show(IDialogVisualizerService svc, IVisualizerObjectProvider Provider)
	{
		string inputString = (string)Provider.GetObject();

		using (FormViewer form=new FormViewer())
		{
			byte[] bytes = Convert.FromBase64String(inputString);
			form.DecodedText = System.Text.Encoding.UTF8.GetString(bytes);
			svc.ShowDialog(form);
		}
	}
}

