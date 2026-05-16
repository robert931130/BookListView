namespace BookListView;

partial class frmBooks
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lvwBooks = new ListView();
        imgL = new ImageList(components);
        imgS = new ImageList(components);
        grpBorrow = new GroupBox();
        lstBorrow = new ListBox();
        pnlTools = new Panel();
        grpView = new GroupBox();
        cmbView = new ComboBox();
        grpBorrow.SuspendLayout();
        pnlTools.SuspendLayout();
        grpView.SuspendLayout();
        SuspendLayout();
        // 
        // lvwBooks
        // 
        lvwBooks.Activation = ItemActivation.TwoClick;
        lvwBooks.Dock = DockStyle.Fill;
        lvwBooks.FullRowSelect = true;
        lvwBooks.LargeImageList = imgL;
        lvwBooks.Location = new Point(0, 72);
        lvwBooks.MultiSelect = false;
        lvwBooks.Name = "lvwBooks";
        lvwBooks.Size = new Size(704, 518);
        lvwBooks.SmallImageList = imgS;
        lvwBooks.TabIndex = 1;
        lvwBooks.TileSize = new Size(220, 140);
        lvwBooks.UseCompatibleStateImageBehavior = false;
        lvwBooks.ItemActivate += lvwBooks_ItemActivate;
        // 
        // imgL
        // 
        imgL.ColorDepth = ColorDepth.Depth32Bit;
        imgL.ImageSize = new Size(90, 120);
        imgL.TransparentColor = Color.Transparent;
        // 
        // imgS
        // 
        imgS.ColorDepth = ColorDepth.Depth32Bit;
        imgS.ImageSize = new Size(15, 20);
        imgS.TransparentColor = Color.Transparent;
        // 
        // grpBorrow
        // 
        grpBorrow.Controls.Add(lstBorrow);
        grpBorrow.Dock = DockStyle.Right;
        grpBorrow.Location = new Point(704, 72);
        grpBorrow.Name = "grpBorrow";
        grpBorrow.Padding = new Padding(10);
        grpBorrow.Size = new Size(220, 518);
        grpBorrow.TabIndex = 2;
        grpBorrow.TabStop = false;
        grpBorrow.Text = "借書清單";
        // 
        // lstBorrow
        // 
        lstBorrow.Dock = DockStyle.Fill;
        lstBorrow.FormattingEnabled = true;
        lstBorrow.ItemHeight = 19;
        lstBorrow.Location = new Point(10, 26);
        lstBorrow.Name = "lstBorrow";
        lstBorrow.Size = new Size(200, 482);
        lstBorrow.TabIndex = 0;
        // 
        // pnlTools
        // 
        pnlTools.Controls.Add(grpView);
        pnlTools.Dock = DockStyle.Top;
        pnlTools.Location = new Point(0, 0);
        pnlTools.Name = "pnlTools";
        pnlTools.Padding = new Padding(12, 8, 12, 8);
        pnlTools.Size = new Size(924, 72);
        pnlTools.TabIndex = 0;
        // 
        // grpView
        // 
        grpView.Controls.Add(cmbView);
        grpView.Dock = DockStyle.Left;
        grpView.Location = new Point(12, 8);
        grpView.Name = "grpView";
        grpView.Padding = new Padding(10, 8, 10, 10);
        grpView.Size = new Size(240, 56);
        grpView.TabIndex = 0;
        grpView.TabStop = false;
        grpView.Text = "檢視方式";
        // 
        // cmbView
        // 
        cmbView.Dock = DockStyle.Fill;
        cmbView.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbView.FormattingEnabled = true;
        cmbView.Location = new Point(10, 24);
        cmbView.Name = "cmbView";
        cmbView.Size = new Size(220, 27);
        cmbView.TabIndex = 0;
        cmbView.SelectedIndexChanged += cmbView_SelectedIndexChanged;
        // 
        // frmBooks
        // 
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(924, 590);
        Controls.Add(lvwBooks);
        Controls.Add(grpBorrow);
        Controls.Add(pnlTools);
        MinimumSize = new Size(760, 480);
        Name = "frmBooks";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "圖書管理程式";
        Load += frmBooks_Load;
        grpBorrow.ResumeLayout(false);
        pnlTools.ResumeLayout(false);
        grpView.ResumeLayout(false);
        ResumeLayout(false);
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
