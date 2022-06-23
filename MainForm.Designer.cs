namespace ZKDataCollectHub
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("连接性");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("项目", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.dataGridView_Items = new System.Windows.Forms.DataGridView();
            this.treeView_Tasks = new System.Windows.Forms.TreeView();
            this.listBox_Infos = new System.Windows.Forms.ListBox();
            this.splitContainer_UPDown = new System.Windows.Forms.SplitContainer();
            this.splitContainer_LeftRight = new System.Windows.Forms.SplitContainer();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer_Main = new System.Windows.Forms.ToolStripContainer();
            this.imageList_All = new System.Windows.Forms.ImageList(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_ConInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_UPDown)).BeginInit();
            this.splitContainer_UPDown.Panel1.SuspendLayout();
            this.splitContainer_UPDown.Panel2.SuspendLayout();
            this.splitContainer_UPDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_LeftRight)).BeginInit();
            this.splitContainer_LeftRight.Panel1.SuspendLayout();
            this.splitContainer_LeftRight.Panel2.SuspendLayout();
            this.splitContainer_LeftRight.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.toolStripContainer_Main.ContentPanel.SuspendLayout();
            this.toolStripContainer_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Items
            // 
            this.dataGridView_Items.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Items.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Items.Name = "dataGridView_Items";
            this.dataGridView_Items.RowTemplate.Height = 23;
            this.dataGridView_Items.Size = new System.Drawing.Size(485, 318);
            this.dataGridView_Items.TabIndex = 0;
            // 
            // treeView_Tasks
            // 
            this.treeView_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Tasks.Location = new System.Drawing.Point(0, 0);
            this.treeView_Tasks.Name = "treeView_Tasks";
            treeNode1.Name = "节点1";
            treeNode1.Text = "连接性";
            treeNode2.Name = "节点0";
            treeNode2.Text = "项目";
            this.treeView_Tasks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView_Tasks.Size = new System.Drawing.Size(243, 318);
            this.treeView_Tasks.TabIndex = 1;
            // 
            // listBox_Infos
            // 
            this.listBox_Infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Infos.FormattingEnabled = true;
            this.listBox_Infos.ItemHeight = 12;
            this.listBox_Infos.Location = new System.Drawing.Point(0, 0);
            this.listBox_Infos.Name = "listBox_Infos";
            this.listBox_Infos.Size = new System.Drawing.Size(732, 175);
            this.listBox_Infos.TabIndex = 2;
            // 
            // splitContainer_UPDown
            // 
            this.splitContainer_UPDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_UPDown.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_UPDown.Name = "splitContainer_UPDown";
            this.splitContainer_UPDown.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_UPDown.Panel1
            // 
            this.splitContainer_UPDown.Panel1.Controls.Add(this.splitContainer_LeftRight);
            // 
            // splitContainer_UPDown.Panel2
            // 
            this.splitContainer_UPDown.Panel2.Controls.Add(this.statusStrip_Main);
            this.splitContainer_UPDown.Panel2.Controls.Add(this.listBox_Infos);
            this.splitContainer_UPDown.Size = new System.Drawing.Size(732, 497);
            this.splitContainer_UPDown.SplitterDistance = 318;
            this.splitContainer_UPDown.TabIndex = 3;
            // 
            // splitContainer_LeftRight
            // 
            this.splitContainer_LeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_LeftRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_LeftRight.Name = "splitContainer_LeftRight";
            // 
            // splitContainer_LeftRight.Panel1
            // 
            this.splitContainer_LeftRight.Panel1.Controls.Add(this.treeView_Tasks);
            // 
            // splitContainer_LeftRight.Panel2
            // 
            this.splitContainer_LeftRight.Panel2.Controls.Add(this.dataGridView_Items);
            this.splitContainer_LeftRight.Size = new System.Drawing.Size(732, 318);
            this.splitContainer_LeftRight.SplitterDistance = 243;
            this.splitContainer_LeftRight.TabIndex = 0;
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 153);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(732, 22);
            this.statusStrip_Main.TabIndex = 3;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(732, 25);
            this.menuStrip_Main.TabIndex = 4;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // toolStripContainer_Main
            // 
            // 
            // toolStripContainer_Main.ContentPanel
            // 
            this.toolStripContainer_Main.ContentPanel.Controls.Add(this.splitContainer_UPDown);
            this.toolStripContainer_Main.ContentPanel.Size = new System.Drawing.Size(732, 497);
            this.toolStripContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer_Main.Location = new System.Drawing.Point(0, 25);
            this.toolStripContainer_Main.Name = "toolStripContainer_Main";
            this.toolStripContainer_Main.Size = new System.Drawing.Size(732, 522);
            this.toolStripContainer_Main.TabIndex = 6;
            this.toolStripContainer_Main.Text = "toolStripContainer1";
            // 
            // imageList_All
            // 
            this.imageList_All.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_All.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_All.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // contextMenuStrip_ConInfo
            // 
            this.contextMenuStrip_ConInfo.Name = "contextMenuStrip_ConInfo";
            this.contextMenuStrip_ConInfo.Size = new System.Drawing.Size(181, 26);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 547);
            this.Controls.Add(this.toolStripContainer_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataCollectHub";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).EndInit();
            this.splitContainer_UPDown.Panel1.ResumeLayout(false);
            this.splitContainer_UPDown.Panel2.ResumeLayout(false);
            this.splitContainer_UPDown.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_UPDown)).EndInit();
            this.splitContainer_UPDown.ResumeLayout(false);
            this.splitContainer_LeftRight.Panel1.ResumeLayout(false);
            this.splitContainer_LeftRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_LeftRight)).EndInit();
            this.splitContainer_LeftRight.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.toolStripContainer_Main.ContentPanel.ResumeLayout(false);
            this.toolStripContainer_Main.ResumeLayout(false);
            this.toolStripContainer_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Items;
        private System.Windows.Forms.TreeView treeView_Tasks;
        private System.Windows.Forms.ListBox listBox_Infos;
        private System.Windows.Forms.SplitContainer splitContainer_UPDown;
        private System.Windows.Forms.SplitContainer splitContainer_LeftRight;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer_Main;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ImageList imageList_All;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ConInfo;
    }
}