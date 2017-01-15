namespace APUSH_Master
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.rtList = new System.Windows.Forms.RichTextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.rtConsole = new System.Windows.Forms.RichTextBox();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.webpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClear = new System.Windows.Forms.Button();
			this.statusBar.SuspendLayout();
			this.mainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(12, 27);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(110, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Choose List";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.Location = new System.Drawing.Point(355, 27);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(110, 23);
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "Start!";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// rtList
			// 
			this.rtList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtList.Location = new System.Drawing.Point(12, 56);
			this.rtList.Name = "rtList";
			this.rtList.ReadOnly = true;
			this.rtList.Size = new System.Drawing.Size(453, 213);
			this.rtList.TabIndex = 3;
			this.rtList.Text = "";
			this.rtList.TextChanged += new System.EventHandler(this.rtList_TextChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(128, 27);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(107, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add Words";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// rtConsole
			// 
			this.rtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtConsole.Location = new System.Drawing.Point(12, 275);
			this.rtConsole.Name = "rtConsole";
			this.rtConsole.ReadOnly = true;
			this.rtConsole.Size = new System.Drawing.Size(453, 62);
			this.rtConsole.TabIndex = 4;
			this.rtConsole.Text = "";
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
			this.statusBar.Location = new System.Drawing.Point(0, 340);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(477, 22);
			this.statusBar.TabIndex = 7;
			this.statusBar.Text = "HELLO THERE";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.startToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(477, 24);
			this.mainMenu.TabIndex = 8;
			this.mainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.restartToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webpageToolStripMenuItem,
            this.textDocumentToolStripMenuItem});
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveAsToolStripMenuItem.Text = "Save As..";
			// 
			// webpageToolStripMenuItem
			// 
			this.webpageToolStripMenuItem.Name = "webpageToolStripMenuItem";
			this.webpageToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.webpageToolStripMenuItem.Text = "Webpage";
			this.webpageToolStripMenuItem.Click += new System.EventHandler(this.webpageToolStripMenuItem_Click);
			// 
			// textDocumentToolStripMenuItem
			// 
			this.textDocumentToolStripMenuItem.Name = "textDocumentToolStripMenuItem";
			this.textDocumentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.textDocumentToolStripMenuItem.Text = "Text Document";
			this.textDocumentToolStripMenuItem.Click += new System.EventHandler(this.textDocumentToolStripMenuItem_Click);
			// 
			// restartToolStripMenuItem
			// 
			this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
			this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.restartToolStripMenuItem.Text = "Restart";
			this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemsToolStripMenuItem,
            this.openListToolStripMenuItem,
            this.clearDisplayToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// openListToolStripMenuItem
			// 
			this.openListToolStripMenuItem.Name = "openListToolStripMenuItem";
			this.openListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openListToolStripMenuItem.Text = "Open from file";
			this.openListToolStripMenuItem.Click += new System.EventHandler(this.openListToolStripMenuItem_Click);
			// 
			// addItemsToolStripMenuItem
			// 
			this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
			this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.addItemsToolStripMenuItem.Text = "Add Items";
			this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.addItemsToolStripMenuItem_Click);
			// 
			// clearDisplayToolStripMenuItem
			// 
			this.clearDisplayToolStripMenuItem.Name = "clearDisplayToolStripMenuItem";
			this.clearDisplayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clearDisplayToolStripMenuItem.Text = "Clear Display";
			this.clearDisplayToolStripMenuItem.Click += new System.EventHandler(this.clearDisplayToolStripMenuItem_Click);
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.startToolStripMenuItem.Text = "Start!";
			this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(242, 27);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(107, 23);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 362);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.mainMenu);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.rtList);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.rtConsole);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(493, 400);
			this.Name = "Form1";
			this.Text = "APUSH Master";
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.RichTextBox rtList;
		private System.Windows.Forms.Button btnAdd;
		public System.Windows.Forms.RichTextBox rtConsole;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem webpageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem textDocumentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearDisplayToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
		public System.Windows.Forms.StatusStrip statusBar;
		public System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.Button btnClear;
	}
}

