/* Generated by Myra UI Editor at 11/30/2017 10:56:27 PM */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Samples.AllWidgetsSample
{
	partial class AllWidgets
	{
		private void BuildUI()
		{
			_menuItemNew = new MenuItem();
			_menuItemNew.Id = "_menuItemNew";
			_menuItemNew.Text = "&New";
			_menuItemNew.Color = null;

			_menuItemOpen = new MenuItem();
			_menuItemOpen.Id = "_menuItemOpen";
			_menuItemOpen.Text = "&Open";
			_menuItemOpen.Color = null;

			_menuItemSave = new MenuItem();
			_menuItemSave.Id = "_menuItemSave";
			_menuItemSave.Text = "&Save";
			_menuItemSave.Color = null;

			_menuItemSaveAs = new MenuItem();
			_menuItemSaveAs.Id = "_menuItemSaveAs";
			_menuItemSaveAs.Text = "Save &As...";
			_menuItemSaveAs.Color = null;

			var menuSeparator1 = new MenuSeparator();
			menuSeparator1.Id = null;

			_menuItemQuit = new MenuItem();
			_menuItemQuit.Id = "_menuItemQuit";
			_menuItemQuit.Text = "&Quit";
			_menuItemQuit.Color = null;

			var menuItem1 = new MenuItem();
			menuItem1.Id = "";
			menuItem1.Text = "&File";
			menuItem1.Color = null;
			menuItem1.Items.Add(_menuItemNew);
			menuItem1.Items.Add(_menuItemOpen);
			menuItem1.Items.Add(_menuItemSave);
			menuItem1.Items.Add(_menuItemSaveAs);
			menuItem1.Items.Add(menuSeparator1);
			menuItem1.Items.Add(_menuItemQuit);

			_menuItemCopy = new MenuItem();
			_menuItemCopy.Id = "_menuItemCopy";
			_menuItemCopy.Text = "&Copy";
			_menuItemCopy.Color = null;

			_menuItemPaste = new MenuItem();
			_menuItemPaste.Id = "_menuItemPaste";
			_menuItemPaste.Text = "&Paste";
			_menuItemPaste.Color = null;

			var menuSeparator2 = new MenuSeparator();
			menuSeparator2.Id = null;

			_menuItemUndo = new MenuItem();
			_menuItemUndo.Id = "_menuItemUndo";
			_menuItemUndo.Text = "&Undo";
			_menuItemUndo.Color = null;

			_menuItemRedo = new MenuItem();
			_menuItemRedo.Id = "_menuItemRedo";
			_menuItemRedo.Text = "&Redo";
			_menuItemRedo.Color = null;

			var menuItem2 = new MenuItem();
			menuItem2.Id = "";
			menuItem2.Text = "&Edit";
			menuItem2.Color = null;
			menuItem2.Items.Add(_menuItemCopy);
			menuItem2.Items.Add(_menuItemPaste);
			menuItem2.Items.Add(menuSeparator2);
			menuItem2.Items.Add(_menuItemUndo);
			menuItem2.Items.Add(_menuItemRedo);

			_menuItemAbout = new MenuItem();
			_menuItemAbout.Id = "_menuItemAbout";
			_menuItemAbout.Text = "&About";
			_menuItemAbout.Color = null;

			var menuItem3 = new MenuItem();
			menuItem3.Id = "";
			menuItem3.Text = "&Help";
			menuItem3.Color = null;
			menuItem3.Items.Add(_menuItemAbout);

			var horizontalMenu1 = new HorizontalMenu();
			horizontalMenu1.DrawLines = false;
			horizontalMenu1.DrawLinesColor = Color.White;
			horizontalMenu1.Enabled = true;
			horizontalMenu1.Id = null;
			horizontalMenu1.XHint = 0;
			horizontalMenu1.YHint = 0;
			horizontalMenu1.WidthHint = null;
			horizontalMenu1.HeightHint = null;
			horizontalMenu1.PaddingLeft = 0;
			horizontalMenu1.PaddingRight = 0;
			horizontalMenu1.PaddingTop = 0;
			horizontalMenu1.PaddingBottom = 0;
			horizontalMenu1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			horizontalMenu1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			horizontalMenu1.GridPositionX = 0;
			horizontalMenu1.GridPositionY = 0;
			horizontalMenu1.GridSpanX = 1;
			horizontalMenu1.GridSpanY = 1;
			horizontalMenu1.Visible = true;
			horizontalMenu1.ClipToBounds = false;
			horizontalMenu1.CanFocus = false;
			horizontalMenu1.Items.Add(menuItem1);
			horizontalMenu1.Items.Add(menuItem2);
			horizontalMenu1.Items.Add(menuItem3);

			var textBlock1 = new TextBlock();
			textBlock1.VerticalSpacing = 0;
			textBlock1.Text = "Button:";
			textBlock1.Wrap = true;
			textBlock1.TextColor = Color.White;
			textBlock1.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock1.Id = "";
			textBlock1.XHint = 0;
			textBlock1.YHint = 0;
			textBlock1.WidthHint = null;
			textBlock1.HeightHint = null;
			textBlock1.PaddingLeft = 0;
			textBlock1.PaddingRight = 0;
			textBlock1.PaddingTop = 0;
			textBlock1.PaddingBottom = 0;
			textBlock1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock1.GridPositionX = 0;
			textBlock1.GridPositionY = 0;
			textBlock1.GridSpanX = 1;
			textBlock1.GridSpanY = 1;
			textBlock1.Enabled = true;
			textBlock1.Visible = true;
			textBlock1.ClipToBounds = false;
			textBlock1.CanFocus = false;

			_button = new Button();
			_button.Text = "Show Window";
			_button.TextColor = Color.White;
			_button.ImageWidthHint = null;
			_button.ImageHeightHint = null;
			_button.ImageVisible = true;
			_button.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_button.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_button.Toggleable = false;
			_button.Enabled = true;
			_button.Id = "_button";
			_button.XHint = 0;
			_button.YHint = 0;
			_button.WidthHint = null;
			_button.HeightHint = null;
			_button.PaddingLeft = 8;
			_button.PaddingRight = 8;
			_button.PaddingTop = 0;
			_button.PaddingBottom = 0;
			_button.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			_button.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			_button.GridPositionX = 1;
			_button.GridPositionY = 0;
			_button.GridSpanX = 1;
			_button.GridSpanY = 1;
			_button.Visible = true;
			_button.ClipToBounds = false;
			_button.CanFocus = false;

			var checkBox1 = new CheckBox();
			checkBox1.Text = "This is checkbox";
			checkBox1.TextColor = Color.White;
			checkBox1.ImageWidthHint = 10;
			checkBox1.ImageHeightHint = 10;
			checkBox1.ImageVisible = true;
			checkBox1.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			checkBox1.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			checkBox1.Enabled = true;
			checkBox1.Id = null;
			checkBox1.XHint = 0;
			checkBox1.YHint = 0;
			checkBox1.WidthHint = null;
			checkBox1.HeightHint = null;
			checkBox1.PaddingLeft = 0;
			checkBox1.PaddingRight = 0;
			checkBox1.PaddingTop = 0;
			checkBox1.PaddingBottom = 0;
			checkBox1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			checkBox1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			checkBox1.GridPositionX = 0;
			checkBox1.GridPositionY = 1;
			checkBox1.GridSpanX = 2;
			checkBox1.GridSpanY = 1;
			checkBox1.Visible = true;
			checkBox1.ClipToBounds = false;
			checkBox1.CanFocus = false;

			var textBlock2 = new TextBlock();
			textBlock2.VerticalSpacing = 0;
			textBlock2.Text = "Horizontal Slider:";
			textBlock2.Wrap = true;
			textBlock2.TextColor = Color.White;
			textBlock2.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock2.Id = "";
			textBlock2.XHint = 0;
			textBlock2.YHint = 0;
			textBlock2.WidthHint = null;
			textBlock2.HeightHint = null;
			textBlock2.PaddingLeft = 0;
			textBlock2.PaddingRight = 0;
			textBlock2.PaddingTop = 0;
			textBlock2.PaddingBottom = 0;
			textBlock2.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock2.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock2.GridPositionX = 0;
			textBlock2.GridPositionY = 2;
			textBlock2.GridSpanX = 1;
			textBlock2.GridSpanY = 1;
			textBlock2.Enabled = true;
			textBlock2.Visible = true;
			textBlock2.ClipToBounds = false;
			textBlock2.CanFocus = false;

			var horizontalSlider1 = new HorizontalSlider();
			horizontalSlider1.Minimum = 0;
			horizontalSlider1.Maximum = 100;
			horizontalSlider1.Enabled = true;
			horizontalSlider1.Id = null;
			horizontalSlider1.XHint = 0;
			horizontalSlider1.YHint = 0;
			horizontalSlider1.WidthHint = null;
			horizontalSlider1.HeightHint = null;
			horizontalSlider1.PaddingLeft = 0;
			horizontalSlider1.PaddingRight = 0;
			horizontalSlider1.PaddingTop = 0;
			horizontalSlider1.PaddingBottom = 0;
			horizontalSlider1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			horizontalSlider1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			horizontalSlider1.GridPositionX = 1;
			horizontalSlider1.GridPositionY = 2;
			horizontalSlider1.GridSpanX = 1;
			horizontalSlider1.GridSpanY = 1;
			horizontalSlider1.Visible = true;
			horizontalSlider1.ClipToBounds = false;
			horizontalSlider1.CanFocus = false;

			var textBlock3 = new TextBlock();
			textBlock3.VerticalSpacing = 0;
			textBlock3.Text = "Combo Box:";
			textBlock3.Wrap = true;
			textBlock3.TextColor = Color.White;
			textBlock3.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock3.Id = null;
			textBlock3.XHint = 0;
			textBlock3.YHint = 0;
			textBlock3.WidthHint = null;
			textBlock3.HeightHint = null;
			textBlock3.PaddingLeft = 0;
			textBlock3.PaddingRight = 0;
			textBlock3.PaddingTop = 0;
			textBlock3.PaddingBottom = 0;
			textBlock3.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock3.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock3.GridPositionX = 0;
			textBlock3.GridPositionY = 3;
			textBlock3.GridSpanX = 1;
			textBlock3.GridSpanY = 1;
			textBlock3.Enabled = true;
			textBlock3.Visible = true;
			textBlock3.ClipToBounds = false;
			textBlock3.CanFocus = false;

			var listItem1 = new ListItem();
			listItem1.Id = "";
			listItem1.Text = "Red";
			listItem1.Color = Color.Red;

			var listItem2 = new ListItem();
			listItem2.Id = null;
			listItem2.Text = "Green";
			listItem2.Color = Color.Lime;

			var listItem3 = new ListItem();
			listItem3.Id = null;
			listItem3.Text = "Blue";
			listItem3.Color = new Color
			{
				B = 255,
				G = 128,
				R = 0,
				A = 255,
				PackedValue = 4294934528,
			};

			var comboBox1 = new ComboBox();
			comboBox1.SelectedIndex = 0;
			comboBox1.Enabled = true;
			comboBox1.Id = null;
			comboBox1.XHint = 0;
			comboBox1.YHint = 0;
			comboBox1.WidthHint = 200;
			comboBox1.HeightHint = null;
			comboBox1.PaddingLeft = 0;
			comboBox1.PaddingRight = 0;
			comboBox1.PaddingTop = 0;
			comboBox1.PaddingBottom = 0;
			comboBox1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			comboBox1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			comboBox1.GridPositionX = 1;
			comboBox1.GridPositionY = 3;
			comboBox1.GridSpanX = 1;
			comboBox1.GridSpanY = 1;
			comboBox1.Visible = true;
			comboBox1.ClipToBounds = false;
			comboBox1.CanFocus = false;
			comboBox1.Items.Add(listItem1);
			comboBox1.Items.Add(listItem2);
			comboBox1.Items.Add(listItem3);

			var textBlock4 = new TextBlock();
			textBlock4.VerticalSpacing = 0;
			textBlock4.Text = "Text Field:";
			textBlock4.Wrap = true;
			textBlock4.TextColor = Color.White;
			textBlock4.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock4.Id = null;
			textBlock4.XHint = 0;
			textBlock4.YHint = 0;
			textBlock4.WidthHint = null;
			textBlock4.HeightHint = null;
			textBlock4.PaddingLeft = 0;
			textBlock4.PaddingRight = 0;
			textBlock4.PaddingTop = 0;
			textBlock4.PaddingBottom = 0;
			textBlock4.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock4.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock4.GridPositionX = 0;
			textBlock4.GridPositionY = 4;
			textBlock4.GridSpanX = 1;
			textBlock4.GridSpanY = 1;
			textBlock4.Enabled = true;
			textBlock4.Visible = true;
			textBlock4.ClipToBounds = false;
			textBlock4.CanFocus = false;

			var textField1 = new TextField();
			textField1.VerticalSpacing = 0;
			textField1.Text = "";
			textField1.Wrap = true;
			textField1.TextColor = Color.White;
			textField1.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textField1.FocusedTextColor = Color.TransparentBlack;
			textField1.MessageTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textField1.BlinkIntervalInMs = 450;
			textField1.Multiline = false;
			textField1.Id = null;
			textField1.XHint = 0;
			textField1.YHint = 0;
			textField1.WidthHint = null;
			textField1.HeightHint = null;
			textField1.PaddingLeft = 0;
			textField1.PaddingRight = 0;
			textField1.PaddingTop = 0;
			textField1.PaddingBottom = 0;
			textField1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			textField1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textField1.GridPositionX = 1;
			textField1.GridPositionY = 4;
			textField1.GridSpanX = 1;
			textField1.GridSpanY = 1;
			textField1.Enabled = true;
			textField1.Visible = true;
			textField1.ClipToBounds = false;
			textField1.CanFocus = true;

			var textBlock5 = new TextBlock();
			textBlock5.VerticalSpacing = 0;
			textBlock5.Text = "Spin Button:";
			textBlock5.Wrap = true;
			textBlock5.TextColor = Color.White;
			textBlock5.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock5.Id = null;
			textBlock5.XHint = 0;
			textBlock5.YHint = 0;
			textBlock5.WidthHint = null;
			textBlock5.HeightHint = null;
			textBlock5.PaddingLeft = 0;
			textBlock5.PaddingRight = 0;
			textBlock5.PaddingTop = 0;
			textBlock5.PaddingBottom = 0;
			textBlock5.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock5.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock5.GridPositionX = 0;
			textBlock5.GridPositionY = 5;
			textBlock5.GridSpanX = 1;
			textBlock5.GridSpanY = 1;
			textBlock5.Enabled = true;
			textBlock5.Visible = true;
			textBlock5.ClipToBounds = false;
			textBlock5.CanFocus = false;

			var spinButton1 = new SpinButton();
			spinButton1.Nullable = false;
			spinButton1.Maximum = null;
			spinButton1.Minimum = null;
			spinButton1.Value = 0;
			spinButton1.Integer = false;
			spinButton1.DrawLines = false;
			spinButton1.DrawLinesColor = Color.White;
			spinButton1.Enabled = true;
			spinButton1.Id = null;
			spinButton1.XHint = 0;
			spinButton1.YHint = 0;
			spinButton1.WidthHint = 100;
			spinButton1.HeightHint = null;
			spinButton1.PaddingLeft = 0;
			spinButton1.PaddingRight = 0;
			spinButton1.PaddingTop = 0;
			spinButton1.PaddingBottom = 0;
			spinButton1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			spinButton1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			spinButton1.GridPositionX = 1;
			spinButton1.GridPositionY = 5;
			spinButton1.GridSpanX = 1;
			spinButton1.GridSpanY = 1;
			spinButton1.Visible = true;
			spinButton1.ClipToBounds = false;
			spinButton1.CanFocus = false;

			var textBlock6 = new TextBlock();
			textBlock6.VerticalSpacing = 0;
			textBlock6.Text = "List Box:";
			textBlock6.Wrap = true;
			textBlock6.TextColor = Color.White;
			textBlock6.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock6.Id = null;
			textBlock6.XHint = 0;
			textBlock6.YHint = 0;
			textBlock6.WidthHint = null;
			textBlock6.HeightHint = null;
			textBlock6.PaddingLeft = 0;
			textBlock6.PaddingRight = 0;
			textBlock6.PaddingTop = 0;
			textBlock6.PaddingBottom = 0;
			textBlock6.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock6.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock6.GridPositionX = 0;
			textBlock6.GridPositionY = 6;
			textBlock6.GridSpanX = 1;
			textBlock6.GridSpanY = 1;
			textBlock6.Enabled = true;
			textBlock6.Visible = true;
			textBlock6.ClipToBounds = false;
			textBlock6.CanFocus = false;

			var listItem4 = new ListItem();
			listItem4.Id = null;
			listItem4.Text = "Red";
			listItem4.Color = Color.Red;

			var listItem5 = new ListItem();
			listItem5.Id = null;
			listItem5.Text = "Green";
			listItem5.Color = Color.Lime;

			var listItem6 = new ListItem();
			listItem6.Id = null;
			listItem6.Text = "Blue";
			listItem6.Color = Color.Blue;

			var listBox1 = new ListBox();
			listBox1.DrawLines = false;
			listBox1.DrawLinesColor = Color.White;
			listBox1.Enabled = true;
			listBox1.Id = null;
			listBox1.XHint = 0;
			listBox1.YHint = 0;
			listBox1.WidthHint = 200;
			listBox1.HeightHint = null;
			listBox1.PaddingLeft = 0;
			listBox1.PaddingRight = 0;
			listBox1.PaddingTop = 0;
			listBox1.PaddingBottom = 0;
			listBox1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			listBox1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			listBox1.GridPositionX = 1;
			listBox1.GridPositionY = 6;
			listBox1.GridSpanX = 1;
			listBox1.GridSpanY = 1;
			listBox1.Visible = true;
			listBox1.ClipToBounds = false;
			listBox1.CanFocus = false;
			listBox1.Items.Add(listItem4);
			listBox1.Items.Add(listItem5);
			listBox1.Items.Add(listItem6);

			var textBlock7 = new TextBlock();
			textBlock7.VerticalSpacing = 0;
			textBlock7.Text = "Vertical Menu:";
			textBlock7.Wrap = true;
			textBlock7.TextColor = Color.White;
			textBlock7.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock7.Id = null;
			textBlock7.XHint = 0;
			textBlock7.YHint = 0;
			textBlock7.WidthHint = null;
			textBlock7.HeightHint = null;
			textBlock7.PaddingLeft = 0;
			textBlock7.PaddingRight = 0;
			textBlock7.PaddingTop = 0;
			textBlock7.PaddingBottom = 0;
			textBlock7.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock7.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock7.GridPositionX = 0;
			textBlock7.GridPositionY = 7;
			textBlock7.GridSpanX = 1;
			textBlock7.GridSpanY = 1;
			textBlock7.Enabled = true;
			textBlock7.Visible = true;
			textBlock7.ClipToBounds = false;
			textBlock7.CanFocus = false;

			var menuItem4 = new MenuItem();
			menuItem4.Id = "";
			menuItem4.Text = "Start New Game";
			menuItem4.Color = null;

			var menuItem5 = new MenuItem();
			menuItem5.Id = "";
			menuItem5.Text = "Options";
			menuItem5.Color = null;

			var menuItem6 = new MenuItem();
			menuItem6.Id = "";
			menuItem6.Text = "Quit";
			menuItem6.Color = null;

			var verticalMenu1 = new VerticalMenu();
			verticalMenu1.DrawLines = false;
			verticalMenu1.DrawLinesColor = Color.White;
			verticalMenu1.Enabled = true;
			verticalMenu1.Id = null;
			verticalMenu1.XHint = 0;
			verticalMenu1.YHint = 0;
			verticalMenu1.WidthHint = null;
			verticalMenu1.HeightHint = null;
			verticalMenu1.PaddingLeft = 0;
			verticalMenu1.PaddingRight = 0;
			verticalMenu1.PaddingTop = 0;
			verticalMenu1.PaddingBottom = 0;
			verticalMenu1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			verticalMenu1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			verticalMenu1.GridPositionX = 1;
			verticalMenu1.GridPositionY = 7;
			verticalMenu1.GridSpanX = 1;
			verticalMenu1.GridSpanY = 1;
			verticalMenu1.Visible = true;
			verticalMenu1.ClipToBounds = false;
			verticalMenu1.CanFocus = false;
			verticalMenu1.Items.Add(menuItem4);
			verticalMenu1.Items.Add(menuItem5);
			verticalMenu1.Items.Add(menuItem6);

			var textBlock8 = new TextBlock();
			textBlock8.VerticalSpacing = 0;
			textBlock8.Text = "Tree";
			textBlock8.Wrap = true;
			textBlock8.TextColor = Color.White;
			textBlock8.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock8.Id = null;
			textBlock8.XHint = 0;
			textBlock8.YHint = 0;
			textBlock8.WidthHint = null;
			textBlock8.HeightHint = null;
			textBlock8.PaddingLeft = 0;
			textBlock8.PaddingRight = 0;
			textBlock8.PaddingTop = 0;
			textBlock8.PaddingBottom = 0;
			textBlock8.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock8.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock8.GridPositionX = 0;
			textBlock8.GridPositionY = 8;
			textBlock8.GridSpanX = 1;
			textBlock8.GridSpanY = 1;
			textBlock8.Enabled = true;
			textBlock8.Visible = true;
			textBlock8.ClipToBounds = false;
			textBlock8.CanFocus = false;

			_gridRight = new Grid();
			_gridRight.DrawLines = false;
			_gridRight.DrawLinesColor = Color.White;
			_gridRight.ColumnSpacing = 8;
			_gridRight.RowSpacing = 8;
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			_gridRight.TotalRowsPart = null;
			_gridRight.TotalColumnsPart = null;
			_gridRight.Enabled = true;
			_gridRight.Id = "_gridRight";
			_gridRight.XHint = 0;
			_gridRight.YHint = 0;
			_gridRight.WidthHint = null;
			_gridRight.HeightHint = null;
			_gridRight.PaddingLeft = 0;
			_gridRight.PaddingRight = 0;
			_gridRight.PaddingTop = 0;
			_gridRight.PaddingBottom = 0;
			_gridRight.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_gridRight.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_gridRight.GridPositionX = 0;
			_gridRight.GridPositionY = 0;
			_gridRight.GridSpanX = 1;
			_gridRight.GridSpanY = 1;
			_gridRight.Visible = true;
			_gridRight.ClipToBounds = false;
			_gridRight.CanFocus = false;
			_gridRight.Widgets.Add(textBlock1);
			_gridRight.Widgets.Add(_button);
			_gridRight.Widgets.Add(checkBox1);
			_gridRight.Widgets.Add(textBlock2);
			_gridRight.Widgets.Add(horizontalSlider1);
			_gridRight.Widgets.Add(textBlock3);
			_gridRight.Widgets.Add(comboBox1);
			_gridRight.Widgets.Add(textBlock4);
			_gridRight.Widgets.Add(textField1);
			_gridRight.Widgets.Add(textBlock5);
			_gridRight.Widgets.Add(spinButton1);
			_gridRight.Widgets.Add(textBlock6);
			_gridRight.Widgets.Add(listBox1);
			_gridRight.Widgets.Add(textBlock7);
			_gridRight.Widgets.Add(verticalMenu1);
			_gridRight.Widgets.Add(textBlock8);

			var scrollPane1 = new ScrollPane();
			scrollPane1.Enabled = true;
			scrollPane1.Id = null;
			scrollPane1.XHint = 0;
			scrollPane1.YHint = 0;
			scrollPane1.WidthHint = null;
			scrollPane1.HeightHint = null;
			scrollPane1.PaddingLeft = 0;
			scrollPane1.PaddingRight = 0;
			scrollPane1.PaddingTop = 0;
			scrollPane1.PaddingBottom = 0;
			scrollPane1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			scrollPane1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			scrollPane1.GridPositionX = 0;
			scrollPane1.GridPositionY = 0;
			scrollPane1.GridSpanX = 1;
			scrollPane1.GridSpanY = 1;
			scrollPane1.Visible = true;
			scrollPane1.ClipToBounds = true;
			scrollPane1.CanFocus = true;
			scrollPane1.Child = _gridRight;

			var textBlock9 = new TextBlock();
			textBlock9.VerticalSpacing = 0;
			textBlock9.Text = "Vertical Slider:";
			textBlock9.Wrap = true;
			textBlock9.TextColor = Color.White;
			textBlock9.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock9.Id = null;
			textBlock9.XHint = 0;
			textBlock9.YHint = 0;
			textBlock9.WidthHint = null;
			textBlock9.HeightHint = null;
			textBlock9.PaddingLeft = 0;
			textBlock9.PaddingRight = 0;
			textBlock9.PaddingTop = 0;
			textBlock9.PaddingBottom = 0;
			textBlock9.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock9.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock9.GridPositionX = 0;
			textBlock9.GridPositionY = 0;
			textBlock9.GridSpanX = 1;
			textBlock9.GridSpanY = 1;
			textBlock9.Enabled = true;
			textBlock9.Visible = true;
			textBlock9.ClipToBounds = false;
			textBlock9.CanFocus = false;

			var verticalSlider1 = new VerticalSlider();
			verticalSlider1.Minimum = 0;
			verticalSlider1.Maximum = 100;
			verticalSlider1.Enabled = true;
			verticalSlider1.Id = null;
			verticalSlider1.XHint = 0;
			verticalSlider1.YHint = 0;
			verticalSlider1.WidthHint = null;
			verticalSlider1.HeightHint = null;
			verticalSlider1.PaddingLeft = 0;
			verticalSlider1.PaddingRight = 0;
			verticalSlider1.PaddingTop = 0;
			verticalSlider1.PaddingBottom = 0;
			verticalSlider1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			verticalSlider1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			verticalSlider1.GridPositionX = 0;
			verticalSlider1.GridPositionY = 1;
			verticalSlider1.GridSpanX = 1;
			verticalSlider1.GridSpanY = 1;
			verticalSlider1.Visible = true;
			verticalSlider1.ClipToBounds = false;
			verticalSlider1.CanFocus = false;

			var grid1 = new Grid();
			grid1.DrawLines = false;
			grid1.DrawLinesColor = Color.White;
			grid1.ColumnSpacing = 0;
			grid1.RowSpacing = 8;
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
				Value = 1,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
				Value = 1,
			});
			grid1.TotalRowsPart = null;
			grid1.TotalColumnsPart = null;
			grid1.Enabled = true;
			grid1.Id = null;
			grid1.XHint = 0;
			grid1.YHint = 0;
			grid1.WidthHint = null;
			grid1.HeightHint = null;
			grid1.PaddingLeft = 0;
			grid1.PaddingRight = 0;
			grid1.PaddingTop = 0;
			grid1.PaddingBottom = 0;
			grid1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid1.GridPositionX = 0;
			grid1.GridPositionY = 0;
			grid1.GridSpanX = 1;
			grid1.GridSpanY = 1;
			grid1.Visible = true;
			grid1.ClipToBounds = false;
			grid1.CanFocus = false;
			grid1.Widgets.Add(textBlock9);
			grid1.Widgets.Add(verticalSlider1);

			var textBlock10 = new TextBlock();
			textBlock10.VerticalSpacing = 0;
			textBlock10.Text = "Progress Bars:";
			textBlock10.Wrap = true;
			textBlock10.TextColor = Color.White;
			textBlock10.DisabledTextColor = new Color
			{
				B = 170,
				G = 170,
				R = 170,
				A = 255,
				PackedValue = 4289374890,
			};
			textBlock10.Id = null;
			textBlock10.XHint = 0;
			textBlock10.YHint = 0;
			textBlock10.WidthHint = null;
			textBlock10.HeightHint = null;
			textBlock10.PaddingLeft = 0;
			textBlock10.PaddingRight = 0;
			textBlock10.PaddingTop = 0;
			textBlock10.PaddingBottom = 0;
			textBlock10.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Left;
			textBlock10.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			textBlock10.GridPositionX = 0;
			textBlock10.GridPositionY = 0;
			textBlock10.GridSpanX = 1;
			textBlock10.GridSpanY = 1;
			textBlock10.Enabled = true;
			textBlock10.Visible = true;
			textBlock10.ClipToBounds = false;
			textBlock10.CanFocus = false;

			_horizontalProgressBar = new HorizontalProgressBar();
			_horizontalProgressBar.Minimum = 0;
			_horizontalProgressBar.Maximum = 100;
			_horizontalProgressBar.Value = 0;
			_horizontalProgressBar.DrawLines = false;
			_horizontalProgressBar.DrawLinesColor = Color.White;
			_horizontalProgressBar.Enabled = true;
			_horizontalProgressBar.Id = "_horizontalProgressBar";
			_horizontalProgressBar.XHint = 0;
			_horizontalProgressBar.YHint = 0;
			_horizontalProgressBar.WidthHint = null;
			_horizontalProgressBar.HeightHint = null;
			_horizontalProgressBar.PaddingLeft = 0;
			_horizontalProgressBar.PaddingRight = 0;
			_horizontalProgressBar.PaddingTop = 0;
			_horizontalProgressBar.PaddingBottom = 0;
			_horizontalProgressBar.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_horizontalProgressBar.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Top;
			_horizontalProgressBar.GridPositionX = 0;
			_horizontalProgressBar.GridPositionY = 1;
			_horizontalProgressBar.GridSpanX = 1;
			_horizontalProgressBar.GridSpanY = 1;
			_horizontalProgressBar.Visible = true;
			_horizontalProgressBar.ClipToBounds = false;
			_horizontalProgressBar.CanFocus = false;

			_verticalProgressBar = new VerticalProgressBar();
			_verticalProgressBar.Minimum = 0;
			_verticalProgressBar.Maximum = 100;
			_verticalProgressBar.Value = 0;
			_verticalProgressBar.DrawLines = false;
			_verticalProgressBar.DrawLinesColor = Color.White;
			_verticalProgressBar.Enabled = true;
			_verticalProgressBar.Id = "_verticalProgressBar";
			_verticalProgressBar.XHint = 0;
			_verticalProgressBar.YHint = 0;
			_verticalProgressBar.WidthHint = null;
			_verticalProgressBar.HeightHint = null;
			_verticalProgressBar.PaddingLeft = 0;
			_verticalProgressBar.PaddingRight = 0;
			_verticalProgressBar.PaddingTop = 0;
			_verticalProgressBar.PaddingBottom = 0;
			_verticalProgressBar.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_verticalProgressBar.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_verticalProgressBar.GridPositionX = 0;
			_verticalProgressBar.GridPositionY = 2;
			_verticalProgressBar.GridSpanX = 1;
			_verticalProgressBar.GridSpanY = 1;
			_verticalProgressBar.Visible = true;
			_verticalProgressBar.ClipToBounds = false;
			_verticalProgressBar.CanFocus = false;

			var grid2 = new Grid();
			grid2.DrawLines = false;
			grid2.DrawLinesColor = Color.White;
			grid2.ColumnSpacing = 0;
			grid2.RowSpacing = 8;
			grid2.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
				Value = 1,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
				Value = 1,
			});
			grid2.TotalRowsPart = null;
			grid2.TotalColumnsPart = null;
			grid2.Enabled = true;
			grid2.Id = null;
			grid2.XHint = 0;
			grid2.YHint = 0;
			grid2.WidthHint = null;
			grid2.HeightHint = null;
			grid2.PaddingLeft = 0;
			grid2.PaddingRight = 0;
			grid2.PaddingTop = 0;
			grid2.PaddingBottom = 0;
			grid2.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid2.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid2.GridPositionX = 0;
			grid2.GridPositionY = 2;
			grid2.GridSpanX = 1;
			grid2.GridSpanY = 1;
			grid2.Visible = true;
			grid2.ClipToBounds = false;
			grid2.CanFocus = false;
			grid2.Widgets.Add(textBlock10);
			grid2.Widgets.Add(_horizontalProgressBar);
			grid2.Widgets.Add(_verticalProgressBar);

			var verticalSplitPane1 = new VerticalSplitPane();
			verticalSplitPane1.Enabled = true;
			verticalSplitPane1.Id = null;
			verticalSplitPane1.XHint = 0;
			verticalSplitPane1.YHint = 0;
			verticalSplitPane1.WidthHint = null;
			verticalSplitPane1.HeightHint = null;
			verticalSplitPane1.PaddingLeft = 0;
			verticalSplitPane1.PaddingRight = 0;
			verticalSplitPane1.PaddingTop = 0;
			verticalSplitPane1.PaddingBottom = 0;
			verticalSplitPane1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			verticalSplitPane1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			verticalSplitPane1.GridPositionX = 2;
			verticalSplitPane1.GridPositionY = 0;
			verticalSplitPane1.GridSpanX = 1;
			verticalSplitPane1.GridSpanY = 1;
			verticalSplitPane1.Visible = true;
			verticalSplitPane1.ClipToBounds = false;
			verticalSplitPane1.CanFocus = false;
			verticalSplitPane1.Widgets.Add(grid1);
			verticalSplitPane1.Widgets.Add(grid2);

			var horizontalSplitPane1 = new HorizontalSplitPane();
			horizontalSplitPane1.Enabled = true;
			horizontalSplitPane1.Id = null;
			horizontalSplitPane1.XHint = 0;
			horizontalSplitPane1.YHint = 0;
			horizontalSplitPane1.WidthHint = null;
			horizontalSplitPane1.HeightHint = null;
			horizontalSplitPane1.PaddingLeft = 0;
			horizontalSplitPane1.PaddingRight = 0;
			horizontalSplitPane1.PaddingTop = 0;
			horizontalSplitPane1.PaddingBottom = 0;
			horizontalSplitPane1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			horizontalSplitPane1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			horizontalSplitPane1.GridPositionX = 0;
			horizontalSplitPane1.GridPositionY = 1;
			horizontalSplitPane1.GridSpanX = 1;
			horizontalSplitPane1.GridSpanY = 1;
			horizontalSplitPane1.Visible = true;
			horizontalSplitPane1.ClipToBounds = false;
			horizontalSplitPane1.CanFocus = false;
			horizontalSplitPane1.Widgets.Add(scrollPane1);
			horizontalSplitPane1.Widgets.Add(verticalSplitPane1);

			
			DrawLines = false;
			DrawLinesColor = Color.White;
			ColumnSpacing = 0;
			RowSpacing = 8;
			RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Auto,
				Value = 1,
			});
			RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
				Value = 1,
			});
			TotalRowsPart = null;
			TotalColumnsPart = null;
			Enabled = true;
			Id = "Root";
			XHint = 0;
			YHint = 0;
			WidthHint = null;
			HeightHint = null;
			PaddingLeft = 0;
			PaddingRight = 0;
			PaddingTop = 0;
			PaddingBottom = 0;
			HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			GridPositionX = 0;
			GridPositionY = 0;
			GridSpanX = 1;
			GridSpanY = 1;
			Visible = true;
			ClipToBounds = false;
			CanFocus = false;
			Widgets.Add(horizontalMenu1);
			Widgets.Add(horizontalSplitPane1);
		}

		
		public MenuItem _menuItemNew;
		public MenuItem _menuItemOpen;
		public MenuItem _menuItemSave;
		public MenuItem _menuItemSaveAs;
		public MenuItem _menuItemQuit;
		public MenuItem _menuItemCopy;
		public MenuItem _menuItemPaste;
		public MenuItem _menuItemUndo;
		public MenuItem _menuItemRedo;
		public MenuItem _menuItemAbout;
		public Button _button;
		public Grid _gridRight;
		public HorizontalProgressBar _horizontalProgressBar;
		public VerticalProgressBar _verticalProgressBar;
	}
}