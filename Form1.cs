using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WinForms = System.Windows.Forms;

// System.Windows.Forms
//[assembly: DebuggerDisplay(@"\{ExecutablePath = {ExecutablePath}}", Target = typeof(WinForms::Application))]
//[assembly: DebuggerDisplay(@"\{Text = {Text}}", Target = typeof(WinForms::Button))]
//[assembly: DebuggerDisplay(@"\{Text = {Text} CheckState = {CheckState}}", Target = typeof(WinForms::CheckBox))]
//[assembly: DebuggerDisplay(@"\{SelectedItem = {Text}}", Target = typeof(WinForms::CheckedListBox))]
//[assembly: DebuggerDisplay(@"\{Text = {Text}}", Target = typeof(WinForms::DataGrid))]
//[assembly: DebuggerDisplay(@"\{Type = {Type} Column = {Column} Row = {Row}}", Target = typeof(WinForms::DataGrid.HitTestInfo))]
//[assembly: DebuggerDisplay(@"\{HeaderText = {HeaderText}}", Target = typeof(WinForms::DataGridColumnStyle))]
//[assembly: DebuggerDisplay(@"\{Text = {Text}}", Target = typeof(WinForms::DataGridTextBox))]
//[assembly: DebuggerDisplay(@"\{HeaderText = {HeaderText}}", Target = typeof(WinForms::DataGridTextBoxColumn))]
//[assembly: DebuggerDisplay(@"\{Font = {Font} Color = {Color}}", Target = typeof(WinForms::FontDialog))]
//[assembly: DebuggerDisplay(@"\{Value = {Value} Min = {Minimum} Max = {Maximum}}", Target = typeof(WinForms::HScrollBar))]
//[assembly: DebuggerDisplay(@"\{InvalidRect = {InvalidRect}}", Target = typeof(WinForms::InvalidateEventArgs))]
//[assembly: DebuggerDisplay(@"\{Index = {Index}}", Target = typeof(WinForms::ItemChangedEventArgs))]
//[assembly: DebuggerDisplay(@"\{Index = {Index} NewValue = {NewValue} CurrentValue = {CurrentValue}}", Target = typeof(WinForms::ItemCheckEventArgs))]
//[assembly: DebuggerDisplay(@"\{KeyData = {KeyData}}", Target = typeof(WinForms::KeyEventArgs))]
//[assembly: DebuggerDisplay(@"\{KeyChar = {KeyChar}}", Target = typeof(WinForms::KeyPressEventArgs))]
//[assembly: DebuggerDisplay(@"\{LinkText = {LinkText}}", Target = typeof(WinForms::LinkClickedEventArgs))]
//[assembly: DebuggerDisplay(@"\{SelectedItem = {Text}}", Target = typeof(WinForms::ListBox))]
//[assembly: DebuggerDisplay(@"\{Text = {Text}}", Target = typeof(WinForms::ListViewItem))]
//[assembly: DebuggerDisplay(@"\{X = {X} Y = {Y} Button = {Button}}", Target = typeof(WinForms::MouseEventArgs))]
//[assembly: DebuggerDisplay(@"\{Value = {Value} Min = {Minimum} Max = {Maximum}}", Target = typeof(WinForms::NumericUpDown))]
//[assembly: DebuggerDisplay(@"\{ClipRectangle = {ClipRectangle}}", Target = typeof(WinForms::PaintEventArgs))]
//[assembly: DebuggerDisplay(@"\{Value = {Value} Min = {Minimum} Max = {Maximum}}", Target = typeof(WinForms::ProgressBar))]
//[assembly: DebuggerDisplay(@"\{Text = {Text} Checked = {Checked}}", Target = typeof(WinForms::RadioButton))]
//[assembly: DebuggerDisplay(@"\{Text = {Text}}", Target = typeof(WinForms::RichTextBox))]
//[assembly: DebuggerDisplay(@"\{Bounds = {Bounds} WorkingArea = {WorkingArea} Primary = {Primary} DeviceName = {DeviceName}}", Target = typeof(WinForms::Screen))]
//[assembly: DebuggerDisplay(@"\{Start = {Start} End = {End}}", Target = typeof(WinForms::SelectionRange))]
//[assembly: DebuggerDisplay(@"\{SplitPosition = {SplitPosition} MinExtra = {MinExtra} MinSize = {MinSize}}", Target = typeof(WinForms::Splitter))]
//[assembly: DebuggerDisplay(@"\{SplitX = {SplitX} SplitY = {SplitY}}", Target = typeof(WinForms::SplitterEventArgs))]
//[assembly: DebuggerDisplay(@"\{Text = {Text}}", Target = typeof(WinForms::TextBox))]
//[assembly: DebuggerDisplay(@"\{Interval = {Interval}}", Target = typeof(WinForms::Timer))]
//[assembly: DebuggerDisplay(@"\{Value = {Value} Min = {Minimum} Max = {Maximum}}", Target = typeof(WinForms::TrackBar))]
//[assembly: DebuggerDisplay(@"\{Text = {Text}}", Target = typeof(WinForms::TreeNode))]
//[assembly: DebuggerDisplay(@"\{Value = {Value} Min = {Minimum} Max = {Maximum}}", Target = typeof(WinForms::VScrollBar))]

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var startupPath = Application.StartupPath;
            var button = new Button { Text = "Boo!" };
            var checkBox = new CheckBox { Text = "Boo!", Checked = true };

            var checkedListBox = new CheckedListBox { Text = "Boo!" };
            checkedListBox.Items.Add("item1", false);
            checkedListBox.Items.Add("item2", true);
            checkedListBox.SelectedIndex = 1;

            var dataGrid = new DataGrid { Text = "Boo!" };
            var hitTest = dataGrid.HitTest(0, 0);
            var dataGridBoolColumn = new DataGridBoolColumn { HeaderText = "Boo!" }; // DataGridColumnStyle

            var dataGridTextBox = new DataGridTextBox { Text = "Boo!" };
            var dataGridTextBoxColumn = new DataGridTextBoxColumn { HeaderText = "Boo!" };
            var fontDialog = new FontDialog { Font = SystemFonts.CaptionFont, Color = Color.Red };
            var hScrollBar = new HScrollBar { Value = 23, Minimum = 5, Maximum = 28 };
            var invalidateEventArgs = new InvalidateEventArgs(new Rectangle(1, 2,3,4));

            // var itemChangedEventArgs = new ItemChangedEventArgs(10);
            var itemChangedEventArgs = Activator.CreateInstance(typeof(ItemChangedEventArgs), BindingFlags.NonPublic | BindingFlags.CreateInstance | BindingFlags.Instance, null, new object[] { 10 }, CultureInfo.CurrentCulture);

            var itemCheckEventArgs = new ItemCheckEventArgs(12, CheckState.Indeterminate, CheckState.Checked);
            var keyEventArgs = new WinForms.KeyEventArgs(Keys.Enter | Keys.Delete | Keys.A);
            var keyPressEventArgs = new KeyPressEventArgs('Z');
            var linkClickedEventArgs = new LinkClickedEventArgs("Boo!");

            var listBox = new ListBox { Text = "Boo!" };
            listBox.Items.Add("item1");
            listBox.Items.Add("item2");
            listBox.SelectedIndex = 1;

            var listViewItem = new ListViewItem { Text = "Boo!" };
            var mouseEventArgs = new WinForms.MouseEventArgs(MouseButtons.XButton1 | MouseButtons.Right, 3, 23, 45, 83);
            var numericUpDown = new NumericUpDown { Value = 23, Minimum = 5, Maximum = 28 };
            var paintEventArgs = new PaintEventArgs(CreateGraphics(), new Rectangle(1, 2, 3, 4));
            var progressBar = new ProgressBar { Value = 23, Minimum = 5, Maximum = 28 };
            var radioButton = new RadioButton { Text = "Boo!", Checked = true };
            var richTextBox = new RichTextBox { Text = "Boo!" };
            var screen = Screen.PrimaryScreen;
            var selectionRange = new SelectionRange(new DateTime(2019, 6, 19), new DateTime(2019, 7, 19));
            var splitter = new Splitter { SplitPosition = 23, MinExtra = 5, MinSize = 28 };
            var splitterEventArgs = new SplitterEventArgs(23, 1, 5, 28);
            var textBox = new TextBox { Text = "Boo!" };
            var timer = new Timer { Interval = 123 };
            var trackBar = new TrackBar { Minimum = 5, Maximum = 28, Value = 23 };
            var treeNode = new TreeNode { Text = "Boo!" };
            var vScrollBar = new VScrollBar { Value = 23, Minimum = 5, Maximum = 28 };


            Debugger.Break();

            Environment.Exit(0);
        }

    }
}
