/* Generated by MyraPad at 12/28/2023 9:39:31 PM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using AssetManagementBase;

#if STRIDE
using Stride.Core.Mathematics;
#elif PLATFORM_AGNOSTIC
using System.Drawing;
using System.Numerics;
using Color = FontStashSharp.FSColor;
#else
// MonoGame/FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endif

namespace Myra.Graphics2D.UI.ColorPicker
{
	partial class ColorPickerPanel: VerticalStackPanel
	{
		private void BuildUI()
		{
			_colorWheel = new Image();
			_colorWheel.Id = "_colorWheel";

			_hsPicker = new Image();
			_hsPicker.Border = new SolidBrush("#000000");
			_hsPicker.BorderThickness = new Thickness(1);
			_hsPicker.Padding = new Thickness(4);
			_hsPicker.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_hsPicker.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_hsPicker.Enabled = false;
			_hsPicker.Background = new SolidBrush("#FFFFFFFF");
			_hsPicker.Id = "_hsPicker";

			var panel1 = new Panel();
			panel1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			panel1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			panel1.Widgets.Add(_colorWheel);
			panel1.Widgets.Add(_hsPicker);

			_vPicker = new VerticalSlider();
			_vPicker.Id = "_vPicker";

			_colorBackground = new Image();
			_colorBackground.Width = 40;
			_colorBackground.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_colorBackground.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_colorBackground.Background = new SolidBrush("#FFFFFFFF");
			_colorBackground.Id = "_colorBackground";
			Grid.SetColumnSpan(_colorBackground, 3);

			_colorDisplay = new Image();
			_colorDisplay.Width = 40;
			_colorDisplay.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_colorDisplay.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_colorDisplay.Id = "_colorDisplay";
			Grid.SetColumnSpan(_colorDisplay, 3);

			var label1 = new Label();
			label1.Text = "RGB";
			Grid.SetRow(label1, 1);

			_inputRGB = new TextBox();
			_inputRGB.Id = "_inputRGB";
			Grid.SetColumn(_inputRGB, 1);
			Grid.SetRow(_inputRGB, 1);
			Grid.SetColumnSpan(_inputRGB, 2);

			var label2 = new Label();
			label2.Text = "HSV";
			Grid.SetRow(label2, 2);

			_inputHSV = new TextBox();
			_inputHSV.Id = "_inputHSV";
			Grid.SetColumn(_inputHSV, 1);
			Grid.SetRow(_inputHSV, 2);
			Grid.SetColumnSpan(_inputHSV, 2);

			var label3 = new Label();
			label3.Text = "HEX";
			Grid.SetRow(label3, 3);

			_inputHEX = new TextBox();
			_inputHEX.Id = "_inputHEX";
			Grid.SetColumn(_inputHEX, 1);
			Grid.SetRow(_inputHEX, 3);
			Grid.SetColumnSpan(_inputHEX, 2);

//			var label4 = new Label();
//			label4.Text = "Alpha";
//			Grid.SetRow(label4, 4);

//			_inputAlpha = new TextBox();
//			_inputAlpha.Id = "_inputAlpha";
//			Grid.SetColumn(_inputAlpha, 2);
//			Grid.SetRow(_inputAlpha, 4);

//			_sliderAlpha = new HorizontalSlider();
//			_sliderAlpha.Maximum = 255;
//			_sliderAlpha.Id = "_sliderAlpha";
//			Grid.SetColumn(_sliderAlpha, 1);
//			Grid.SetRow(_sliderAlpha, 4);

			var label5 = new Label();
			label5.Text = "Save Color";

			_saveColor = new Button();
			_saveColor.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Right;
			_saveColor.Id = "_saveColor";
			Grid.SetRow(_saveColor, 5);
			Grid.SetColumnSpan(_saveColor, 3);
			_saveColor.Content = label5;

			var grid1 = new Grid();
			grid1.ColumnSpacing = 8;
			grid1.RowSpacing = 6;
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Pixels,
				Value = 60,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Pixels,
				Value = 40,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			StackPanel.SetProportionType(grid1, Myra.Graphics2D.UI.ProportionType.Fill);
			grid1.Widgets.Add(_colorBackground);
			grid1.Widgets.Add(_colorDisplay);
			grid1.Widgets.Add(label1);
			grid1.Widgets.Add(_inputRGB);
			grid1.Widgets.Add(label2);
			grid1.Widgets.Add(_inputHSV);
			grid1.Widgets.Add(label3);
			grid1.Widgets.Add(_inputHEX);
			//grid1.Widgets.Add(label4);
			//grid1.Widgets.Add(_inputAlpha);
			//grid1.Widgets.Add(_sliderAlpha);
			grid1.Widgets.Add(_saveColor);

			var horizontalStackPanel1 = new HorizontalStackPanel();
			horizontalStackPanel1.Spacing = 8;
			horizontalStackPanel1.Widgets.Add(panel1);
			horizontalStackPanel1.Widgets.Add(_vPicker);
			horizontalStackPanel1.Widgets.Add(grid1);

			_userColors = new Grid();
			_userColors.ColumnSpacing = 8;
			_userColors.RowSpacing = 8;
			_userColors.GridSelectionMode = Myra.Graphics2D.UI.GridSelectionMode.Cell;
			_userColors.Padding = new Thickness(4);
			_userColors.Id = "_userColors";

			
			Spacing = 8;
			Widgets.Add(horizontalStackPanel1);
			Widgets.Add(_userColors);
		}

		
		public Image _colorWheel;
		public Image _hsPicker;
		public VerticalSlider _vPicker;
		public Image _colorBackground;
		public Image _colorDisplay;
		public TextBox _inputRGB;
		public TextBox _inputHSV;
		public TextBox _inputHEX;
		public TextBox _inputAlpha;
		public HorizontalSlider _sliderAlpha;
		public Button _saveColor;
		public Grid _userColors;
	}
}
