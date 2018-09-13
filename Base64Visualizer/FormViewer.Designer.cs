namespace Base64Visualizer
{
	partial class FormViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxDecoder = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxDecoder
			// 
			this.textBoxDecoder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDecoder.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxDecoder.Location = new System.Drawing.Point(0, 0);
			this.textBoxDecoder.Multiline = true;
			this.textBoxDecoder.Name = "textBoxDecoder";
			this.textBoxDecoder.Size = new System.Drawing.Size(562, 364);
			this.textBoxDecoder.TabIndex = 0;
			// 
			// FormViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 364);
			this.Controls.Add(this.textBoxDecoder);
			this.Name = "FormViewer";
			this.Text = "Base64 Decoder Visualizer by Dejan Mauer (www.mauer.si)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxDecoder;
	}
}