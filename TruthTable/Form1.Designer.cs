namespace TruthTable
{
    partial class TruthTable
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruthTable));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenToDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileTabPageClose = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTabAllClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileApplicationClose = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMEPDialog = new System.Windows.Forms.OpenFileDialog();
            this.mepSelector = new System.Windows.Forms.TabControl();
            this.Start = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExampleLabelHeader = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExampleVariable = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolDeleteNode = new System.Windows.Forms.ToolStripButton();
            this.toolAddNode = new System.Windows.Forms.ToolStripDropDownButton();
            this.addLimflash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip.SuspendLayout();
            this.mepSelector.SuspendLayout();
            this.Start.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(641, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenToDialog,
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.fileTabPageClose,
            this.fileTabAllClose,
            this.toolStripSeparator2,
            this.fileApplicationClose,
            this.deleteProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileOpenToDialog
            // 
            this.fileOpenToDialog.BackColor = System.Drawing.SystemColors.Control;
            this.fileOpenToDialog.Name = "fileOpenToDialog";
            this.fileOpenToDialog.Size = new System.Drawing.Size(156, 22);
            this.fileOpenToDialog.Text = "Open";
            this.fileOpenToDialog.Click += new System.EventHandler(this.fileOpenToDialog_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem1.Text = "MEP File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // fileTabPageClose
            // 
            this.fileTabPageClose.BackColor = System.Drawing.SystemColors.Control;
            this.fileTabPageClose.Name = "fileTabPageClose";
            this.fileTabPageClose.Size = new System.Drawing.Size(156, 22);
            this.fileTabPageClose.Text = "Close";
            this.fileTabPageClose.Click += new System.EventHandler(this.fileTabPageClose_Click);
            // 
            // fileTabAllClose
            // 
            this.fileTabAllClose.BackColor = System.Drawing.SystemColors.Control;
            this.fileTabAllClose.Name = "fileTabAllClose";
            this.fileTabAllClose.Size = new System.Drawing.Size(156, 22);
            this.fileTabAllClose.Text = "Close All";
            this.fileTabAllClose.Click += new System.EventHandler(this.fileTabAllClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // fileApplicationClose
            // 
            this.fileApplicationClose.BackColor = System.Drawing.SystemColors.Control;
            this.fileApplicationClose.Name = "fileApplicationClose";
            this.fileApplicationClose.Size = new System.Drawing.Size(156, 22);
            this.fileApplicationClose.Text = "Exit";
            this.fileApplicationClose.Click += new System.EventHandler(this.fileApplicationClose_click);
            // 
            // deleteProgramToolStripMenuItem
            // 
            this.deleteProgramToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.deleteProgramToolStripMenuItem.Name = "deleteProgramToolStripMenuItem";
            this.deleteProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteProgramToolStripMenuItem.Text = "Delete Program";
            this.deleteProgramToolStripMenuItem.Click += new System.EventHandler(this.deleteProgramToolStripMenuItem_Click);
            // 
            // OpenMEPDialog
            // 
            this.OpenMEPDialog.FileName = ".mep";
            // 
            // mepSelector
            // 
            this.mepSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mepSelector.Controls.Add(this.Start);
            this.mepSelector.Location = new System.Drawing.Point(0, 36);
            this.mepSelector.Name = "mepSelector";
            this.mepSelector.SelectedIndex = 0;
            this.mepSelector.Size = new System.Drawing.Size(641, 583);
            this.mepSelector.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Gainsboro;
            this.Start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Start.Controls.Add(this.panel1);
            this.Start.Controls.Add(this.treeView1);
            this.Start.Controls.Add(this.toolStrip1);
            this.Start.Location = new System.Drawing.Point(4, 22);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(3);
            this.Start.Size = new System.Drawing.Size(633, 557);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(211, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 525);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ExampleLabelHeader);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.ExampleVariable);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 137);
            this.panel2.TabIndex = 3;
            // 
            // ExampleLabelHeader
            // 
            this.ExampleLabelHeader.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleLabelHeader.Location = new System.Drawing.Point(61, 2);
            this.ExampleLabelHeader.Name = "ExampleLabelHeader";
            this.ExampleLabelHeader.Size = new System.Drawing.Size(218, 35);
            this.ExampleLabelHeader.TabIndex = 0;
            this.ExampleLabelHeader.Text = "Node Info";
            this.ExampleLabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExampleLabelHeader.Click += new System.EventHandler(this.ExampleLabelHeader_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 2;
            // 
            // ExampleVariable
            // 
            this.ExampleVariable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExampleVariable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExampleVariable.Location = new System.Drawing.Point(3, 50);
            this.ExampleVariable.Name = "ExampleVariable";
            this.ExampleVariable.Size = new System.Drawing.Size(137, 20);
            this.ExampleVariable.TabIndex = 1;
            this.ExampleVariable.Text = "Start Frame:";
            this.ExampleVariable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExampleVariable.Click += new System.EventHandler(this.ExampleVariable_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView1.Location = new System.Drawing.Point(-1, 31);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(216, 525);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDeleteNode,
            this.toolAddNode,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolDeleteNode
            // 
            this.toolDeleteNode.BackColor = System.Drawing.Color.Transparent;
            this.toolDeleteNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDeleteNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteNode.Name = "toolDeleteNode";
            this.toolDeleteNode.Size = new System.Drawing.Size(44, 22);
            this.toolDeleteNode.Text = "Delete";
            this.toolDeleteNode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolDeleteNode.Click += new System.EventHandler(this.toolDeleteNode_Click);
            // 
            // toolAddNode
            // 
            this.toolAddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAddNode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLimflash});
            this.toolAddNode.Image = ((System.Drawing.Image)(resources.GetObject("toolAddNode.Image")));
            this.toolAddNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddNode.Name = "toolAddNode";
            this.toolAddNode.Size = new System.Drawing.Size(54, 22);
            this.toolAddNode.Text = "Create";
            // 
            // addLimflash
            // 
            this.addLimflash.Name = "addLimflash";
            this.addLimflash.Size = new System.Drawing.Size(121, 22);
            this.addLimflash.Text = "LimFlash";
            this.addLimflash.Click += new System.EventHandler(this.addLimFlash_click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Search";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton2.Text = "Copy";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton3.Text = "Paste";
            // 
            // TruthTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(641, 620);
            this.Controls.Add(this.mepSelector);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TruthTable";
            this.Text = "Magic";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mepSelector.ResumeLayout(false);
            this.Start.ResumeLayout(false);
            this.Start.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToDialog;
        private System.Windows.Forms.OpenFileDialog OpenMEPDialog;
        private System.Windows.Forms.TabControl mepSelector;
        private System.Windows.Forms.TabPage Start;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileTabPageClose;
        private System.Windows.Forms.ToolStripMenuItem fileTabAllClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileApplicationClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolDeleteNode;
        private System.Windows.Forms.ToolStripDropDownButton toolAddNode;
        private System.Windows.Forms.ToolStripMenuItem addLimflash;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem deleteProgramToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExampleVariable;
        private System.Windows.Forms.Label ExampleLabelHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

