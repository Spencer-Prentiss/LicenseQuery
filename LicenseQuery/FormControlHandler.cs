using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace LicenseQuery
{
	public static class FormControlHandler
	{
		public static void Update(Control control)
		{
			control.Invalidate();
			control.Update();
		}

		public static void Update(List<Control> controls)
		{
			foreach (Control control in controls)
			{
				control.Invalidate();
				control.Update();
			}
		}

		public static void ChangeForeColor(Control control, Color color)
		{
			control.ForeColor = color;
			Update(control);
		}

		public static void ChangeBackColor(Control control, Color color)
		{
			control.BackColor = color;
			Update(control);
		}

		public static void ChangeForeAndBackColor(Control control, Color foreColor, Color backColor)
		{
			control.BackColor = backColor;
			control.ForeColor = foreColor;
			Update(control);
		}

		public static void Enable(Control control)
		{
			control.Enabled = true;
			Update(control);
		}

		public static void Enable(List<Control> controls)
		{
			foreach (Control control in controls)
				control.Enabled = true;

			Update(controls);
		}

		public static void Disable(Control control)
		{
			control.Enabled = false;
			Update(control);
		}

		public static void Disable(List<Control> controls)
		{
			foreach (Control control in controls)
				control.Enabled = false;

			Update(controls);
		}

		public static void ToggleEnabled(Control control)
		{
			control.Enabled = !control.Enabled;
			Update(control);
		}

		public static void ToggleEnabled(List<Control> controls)
		{
			foreach (Control control in controls)
				control.Enabled = !control.Enabled;

			Update(controls);
		}

		public static void ChangeText(Control control, string text)
		{
			control.Text = text;
			Update(control);
		}

		public static void ChangeTextAndForeColor(Control control, string text, Color color)
		{
			control.Text = text;
			control.ForeColor = color;
			Update(control);
		}

		public static void SetProgressValue(ProgressBar bar, int value)
		{
			bar.Value = value;
			Update(bar);
		}

		public static void SetProgressMax(ProgressBar bar, int max)
		{
			bar.Maximum = max;
			Update(bar);
		}

		public static void SetProgressValueAndMax(ProgressBar bar, int value, int max)
		{
			bar.Value = value;
			bar.Maximum = max;
			Update(bar);
		}
	}
}
