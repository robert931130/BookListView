using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BookListView
{
    partial class frmBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new Container();
            this.lvwBooks = new ListView();
            this.imgL = new ImageList(this.components);
            this.imgS = new ImageList(this.components);
            this.grpBorrow = new GroupBox();
            this.lstBorrow = new ListBox();
            this.pnlTools = new Panel();
            this.grpView = new GroupBox();
            this.cmbView = new ComboBox();
            this.grpBorrow.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.grpView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwBooks
            // 
            this.lvwBooks.Activation = ItemActivation.TwoClick;
            this.lvwBooks.Dock = DockStyle.Fill;
            this.lvwBooks.FullRowSelect = true;
            this.lvwBooks.LargeImageList = this.imgL;
            this.lvwBooks.Location = new Point(0, 72);
            this.lvwBooks.MultiSelect = false;
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new Size(704, 518);
            this.lvwBooks.SmallImageList = this.imgS;
            this.lvwBooks.TabIndex = 1;
            this.lvwBooks.TileSize = new Size(220, 140);
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            this.lvwBooks.ItemActivate += new System.EventHandler(this.lvwBooks_ItemActivate);
            // 
            // imgL
            // 
            this.imgL.ColorDepth = ColorDepth.Depth32Bit;
            this.imgL.ImageSize = new Size(90, 120);
            this.imgL.TransparentColor = Color.Transparent;
            // 
            // imgS
            // 
            this.imgS.ColorDepth = ColorDepth.Depth32Bit;
            this.imgS.ImageSize = new Size(15, 20);
            this.imgS.TransparentColor = Color.Transparent;
            // 
            // grpBorrow
            // 
            this.grpBorrow.Controls.Add(this.lstBorrow);
            this.grpBorrow.Dock = DockStyle.Right;
            this.grpBorrow.Location = new Point(704, 72);
            this.grpBorrow.Name = "grpBorrow";
            this.grpBorrow.Padding = new Padding(10);
            this.grpBorrow.Size = new Size(220, 518);
            this.grpBorrow.TabIndex = 2;
            this.grpBorrow.TabStop = false;
            this.grpBorrow.Text = "借書清單";
            // 
            // lstBorrow
            // 
            this.lstBorrow.Dock = DockStyle.Fill;
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 12;
            this.lstBorrow.Location = new Point(10, 25);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new Size(200, 483);
            this.lstBorrow.TabIndex = 0;
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.grpView);
            this.pnlTools.Dock = DockStyle.Top;
            this.pnlTools.Location = new Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Padding = new Padding(12, 8, 12, 8);
            this.pnlTools.Size = new Size(924, 72);
            this.pnlTools.TabIndex = 0;
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.cmbView);
            this.grpView.Dock = DockStyle.Left;
            this.grpView.Location = new Point(12, 8);
            this.grpView.Name = "grpView";
            this.grpView.Padding = new Padding(10, 8, 10, 10);
            this.grpView.Size = new Size(240, 56);
            this.grpView.TabIndex = 0;
            this.grpView.TabStop = false;
            this.grpView.Text = "檢視方式";
            // 
            // cmbView
            // 
            this.cmbView.Dock = DockStyle.Fill;
            this.cmbView.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbView.FormattingEnabled = true;
            this.cmbView.Location = new Point(10, 23);
            this.cmbView.Name = "cmbView";
            this.cmbView.Size = new Size(220, 20);
            this.cmbView.TabIndex = 0;
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);
            // 
            // frmBooks
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(924, 590);
            this.Controls.Add(this.lvwBooks);
            this.Controls.Add(this.grpBorrow);
            this.Controls.Add(this.pnlTools);
            this.MinimumSize = new Size(760, 480);
            this.Name = "frmBooks";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "圖書管理程式";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.grpBorrow.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.grpView.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private ListView lvwBooks;
        private ImageList imgL;
        private ImageList imgS;
        private GroupBox grpBorrow;
        private ListBox lstBorrow;
        private Panel pnlTools;
        private GroupBox grpView;
        private ComboBox cmbView;
    }
}
