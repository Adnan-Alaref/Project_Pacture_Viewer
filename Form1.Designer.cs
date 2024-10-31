
namespace ProjectPactureViewer1
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
            this.components = new System.ComponentModel.Container();
            this.panelOfListBox = new System.Windows.Forms.Panel();
            this.ListBoxOfImages = new System.Windows.Forms.ListBox();
            this.ButtonOfChooseImages = new System.Windows.Forms.Button();
            this.panelOfTextBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelOfButtons = new System.Windows.Forms.Panel();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSlide = new System.Windows.Forms.Button();
            this.buttonSingle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chooseImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelImages = new System.Windows.Forms.Panel();
            this.panelOfListBox.SuspendLayout();
            this.panelOfTextBox.SuspendLayout();
            this.panelOfButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOfListBox
            // 
            this.panelOfListBox.BackColor = System.Drawing.Color.Gray;
            this.panelOfListBox.Controls.Add(this.ListBoxOfImages);
            this.panelOfListBox.Controls.Add(this.ButtonOfChooseImages);
            this.panelOfListBox.Location = new System.Drawing.Point(5, 61);
            this.panelOfListBox.Name = "panelOfListBox";
            this.panelOfListBox.Size = new System.Drawing.Size(207, 672);
            this.panelOfListBox.TabIndex = 0;
            // 
            // ListBoxOfImages
            // 
            this.ListBoxOfImages.BackColor = System.Drawing.Color.Gray;
            this.ListBoxOfImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBoxOfImages.FormattingEnabled = true;
            this.ListBoxOfImages.ItemHeight = 29;
            this.ListBoxOfImages.Location = new System.Drawing.Point(3, 68);
            this.ListBoxOfImages.Name = "ListBoxOfImages";
            this.ListBoxOfImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxOfImages.Size = new System.Drawing.Size(201, 613);
            this.ListBoxOfImages.TabIndex = 1;
            this.toolTip1.SetToolTip(this.ListBoxOfImages, "Include Names Of Selected Pictures..!");
            // 
            // ButtonOfChooseImages
            // 
            this.ButtonOfChooseImages.BackColor = System.Drawing.Color.Navy;
            this.ButtonOfChooseImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOfChooseImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOfChooseImages.Location = new System.Drawing.Point(3, 3);
            this.ButtonOfChooseImages.Name = "ButtonOfChooseImages";
            this.ButtonOfChooseImages.Size = new System.Drawing.Size(201, 59);
            this.ButtonOfChooseImages.TabIndex = 0;
            this.ButtonOfChooseImages.Text = "Choose Images";
            this.toolTip1.SetToolTip(this.ButtonOfChooseImages, "To Select Pictures..!");
            this.ButtonOfChooseImages.UseVisualStyleBackColor = false;
            this.ButtonOfChooseImages.Click += new System.EventHandler(this.ButtonOfChooseImages_Click);
            // 
            // panelOfTextBox
            // 
            this.panelOfTextBox.BackColor = System.Drawing.Color.Gray;
            this.panelOfTextBox.Controls.Add(this.label1);
            this.panelOfTextBox.Location = new System.Drawing.Point(5, 5);
            this.panelOfTextBox.Name = "panelOfTextBox";
            this.panelOfTextBox.Size = new System.Drawing.Size(1524, 50);
            this.panelOfTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "picture viewer";
            // 
            // panelOfButtons
            // 
            this.panelOfButtons.BackColor = System.Drawing.Color.Gray;
            this.panelOfButtons.Controls.Add(this.statusBar1);
            this.panelOfButtons.Controls.Add(this.buttonMulti);
            this.panelOfButtons.Controls.Add(this.button3);
            this.panelOfButtons.Controls.Add(this.buttonSlide);
            this.panelOfButtons.Controls.Add(this.buttonSingle);
            this.panelOfButtons.Location = new System.Drawing.Point(5, 739);
            this.panelOfButtons.Name = "panelOfButtons";
            this.panelOfButtons.Size = new System.Drawing.Size(1524, 52);
            this.panelOfButtons.TabIndex = 3;
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.Location = new System.Drawing.Point(525, 3);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(473, 43);
            this.statusBar1.TabIndex = 4;
            this.statusBar1.Text = "NameOfImage";
            this.toolTip1.SetToolTip(this.statusBar1, "Display Name Of Pictures..! ");
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 2000;
            // 
            // buttonMulti
            // 
            this.buttonMulti.BackColor = System.Drawing.Color.Navy;
            this.buttonMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMulti.Location = new System.Drawing.Point(266, 3);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(202, 43);
            this.buttonMulti.TabIndex = 3;
            this.buttonMulti.Text = "Multi Images";
            this.toolTip1.SetToolTip(this.buttonMulti, "To Show Multi Pictures..!");
            this.buttonMulti.UseVisualStyleBackColor = false;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(1319, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.toolTip1.SetToolTip(this.button3, "To Exit From Program..!");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSlide
            // 
            this.buttonSlide.BackColor = System.Drawing.Color.Navy;
            this.buttonSlide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSlide.Location = new System.Drawing.Point(1058, 3);
            this.buttonSlide.Name = "buttonSlide";
            this.buttonSlide.Size = new System.Drawing.Size(202, 43);
            this.buttonSlide.TabIndex = 1;
            this.buttonSlide.Text = "Slide Show";
            this.toolTip1.SetToolTip(this.buttonSlide, "To Display Pictures In Sequence..!");
            this.buttonSlide.UseVisualStyleBackColor = false;
            this.buttonSlide.Click += new System.EventHandler(this.buttonSlide_Click);
            // 
            // buttonSingle
            // 
            this.buttonSingle.BackColor = System.Drawing.Color.Navy;
            this.buttonSingle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSingle.Location = new System.Drawing.Point(3, 3);
            this.buttonSingle.Name = "buttonSingle";
            this.buttonSingle.Size = new System.Drawing.Size(202, 43);
            this.buttonSingle.TabIndex = 0;
            this.buttonSingle.Text = "Single Image";
            this.toolTip1.SetToolTip(this.buttonSingle, "To Show One Picture..!");
            this.buttonSingle.UseVisualStyleBackColor = false;
            this.buttonSingle.Click += new System.EventHandler(this.buttonSingle_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Navy;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // chooseImagesToolStripMenuItem
            // 
            this.chooseImagesToolStripMenuItem.Name = "chooseImagesToolStripMenuItem";
            this.chooseImagesToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.chooseImagesToolStripMenuItem.Text = "Choose Images";
            this.chooseImagesToolStripMenuItem.Click += new System.EventHandler(this.ButtonOfChooseImages_Click);
            // 
            // singleImageToolStripMenuItem
            // 
            this.singleImageToolStripMenuItem.Name = "singleImageToolStripMenuItem";
            this.singleImageToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.singleImageToolStripMenuItem.Text = "Single Image";
            this.singleImageToolStripMenuItem.Click += new System.EventHandler(this.buttonSingle_Click);
            // 
            // multiImagesToolStripMenuItem
            // 
            this.multiImagesToolStripMenuItem.Name = "multiImagesToolStripMenuItem";
            this.multiImagesToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.multiImagesToolStripMenuItem.Text = "Multi Images";
            this.multiImagesToolStripMenuItem.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // slideShowToolStripMenuItem
            // 
            this.slideShowToolStripMenuItem.Name = "slideShowToolStripMenuItem";
            this.slideShowToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.slideShowToolStripMenuItem.Text = "Slide Show";
            this.slideShowToolStripMenuItem.Click += new System.EventHandler(this.buttonSlide_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 28);
            this.toolStripMenuItem2.Text = "              ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseImagesToolStripMenuItem,
            this.singleImageToolStripMenuItem,
            this.multiImagesToolStripMenuItem,
            this.slideShowToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 200);
            // 
            // panelImages
            // 
            this.panelImages.AutoScroll = true;
            this.panelImages.BackColor = System.Drawing.Color.Gray;
            this.panelImages.BackgroundImage = global::ProjectPactureViewer1.Properties.Resources._88;
            this.panelImages.Location = new System.Drawing.Point(218, 61);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(1311, 672);
            this.panelImages.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1541, 797);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelOfButtons);
            this.Controls.Add(this.panelImages);
            this.Controls.Add(this.panelOfTextBox);
            this.Controls.Add(this.panelOfListBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Location = new System.Drawing.Point(-6, 0);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOfListBox.ResumeLayout(false);
            this.panelOfTextBox.ResumeLayout(false);
            this.panelOfTextBox.PerformLayout();
            this.panelOfButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOfListBox;
        private System.Windows.Forms.Panel panelOfTextBox;
        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.Panel panelOfButtons;
        private System.Windows.Forms.ListBox ListBoxOfImages;
        private System.Windows.Forms.Button ButtonOfChooseImages;
        private System.Windows.Forms.Button buttonSingle;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSlide;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem chooseImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

