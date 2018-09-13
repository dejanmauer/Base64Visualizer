using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Visualizer
{
	public partial class FormViewer : Form
	{

		public string DecodedText
		{
			get
			{
				return textBoxDecoder.Text;
			}
			set
			{
				textBoxDecoder.Text = value;
			}
		}
		public FormViewer()
		{
			InitializeComponent();
		}
	}
}
