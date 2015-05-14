using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WWTRemoteControl
{
    public partial class NodeListEditor : Form
    {
        public NodeListEditor()
        {
            InitializeComponent();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (nodeList.SelectedIndex > -1)
            {
                nodeList.Items.RemoveAt(nodeList.SelectedIndex);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (MacAddress.Text.Length == 12)
            {
                nodeList.Items.Add(MacAddress.Text);
            }
        }

        private void NodeListEditor_Load(object sender, EventArgs e)
        {
            string[] wakeList = Properties.Settings.Default.WolList.Split(new char[] { ',' });
            foreach (string node in wakeList)
            {
                if (!string.IsNullOrEmpty(node))
                {
                    nodeList.Items.Add(node);
                }
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            bool first = true;
            string nodeListText="";
            foreach (object item in nodeList.Items)
            {
                if (!first)
                {
                    nodeListText += ",";
                }
                first = false;
                nodeListText += item.ToString();
            }
            Properties.Settings.Default.WolList = nodeListText;
        }
    }
}
