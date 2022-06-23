using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication;

namespace ZKDataCollectHub
{
    public partial class MainForm : Form
    {
        object thisUIUpdateLock = new object();

        public MainForm()
        {
            InitializeComponent();
            treeView_Tasks.Nodes[0].ExpandAll();
        }

        private void ui_SysInfoAdd(object str)
        {
            lock (thisUIUpdateLock)
            {
                BeginInvoke(new Action(() =>
                {
                    try
                    {
                        listBox_Infos.Items.Add(DateTime.Now.ToString() + " " + str.ToString());
                        listBox_Infos.SelectedIndex = listBox_Infos.Items.Count - 1;
                        if (listBox_Infos.Items.Count > 3000)
                        {
                            listBox_Infos.Items.RemoveAt(0);
                        }
                    }
                    catch { }
                }));
            }
        }
    }
}
