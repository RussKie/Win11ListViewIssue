using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win11ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 1_000; i++)
            {
                var item = new ListViewItem($"BugReporter/Properties/xlf/Resources{i:0000}.cs.xlf", listView1.Groups[0]);
                listView1.Items.Add(item);
                item.ToolTipText = $"BugReporter/Properties/xlf/Resources{i:0000}.cs.xlf";
            }
        }

    }
}
