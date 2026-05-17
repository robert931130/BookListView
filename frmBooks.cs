using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BookListView
{
    public partial class frmBooks : Form
    {
        private readonly string[] b_name =
        {
            "三國演義", "西遊記", "唐詩三百首", "楚辭",
            "西廂記", "水滸傳", "紅樓夢", "牡丹亭"
        };

        private readonly string[] author =
        {
            "羅貫中", "吳承恩", "孫洙", "劉向",
            "王實甫", "施耐庵", "曹雪芹", "湯顯祖"
        };

        private readonly string[] kind =
        {
            "章回小說", "章回小說", "詩選", "詩歌", "戲曲",
            "章回小說", "章回小說", "戲曲"
        };

        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            LoadBookImages();

            cmbView.Items.Add("大圖示");
            cmbView.Items.Add("詳細資料");
            cmbView.Items.Add("小圖示");
            cmbView.Items.Add("清單");
            cmbView.Items.Add("大圖示加詳細資料");

            lvwBooks.Columns.Add("書名", 100);
            lvwBooks.Columns.Add("作者", 80);
            lvwBooks.Columns.Add("類別", 80);

            lvwBooks.BeginUpdate();
            for (int i = 0; i < b_name.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(b_name[i], i);
                lvi.SubItems.Add(author[i]);
                lvi.SubItems.Add(kind[i]);
                lvwBooks.Items.Add(lvi);
            }
            lvwBooks.EndUpdate();

            cmbView.SelectedIndex = 0;
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbView.SelectedIndex)
            {
                case 0:
                    lvwBooks.View = View.LargeIcon;
                    break;
                case 1:
                    lvwBooks.View = View.Details;
                    break;
                case 2:
                    lvwBooks.View = View.SmallIcon;
                    break;
                case 3:
                    lvwBooks.View = View.List;
                    break;
                case 4:
                    lvwBooks.View = View.Tile;
                    break;
                default:
                    lvwBooks.View = View.LargeIcon;
                    break;
            }
        }

        private void lvwBooks_ItemActivate(object sender, EventArgs e)
        {
            if (lvwBooks.SelectedItems.Count == 0)
            {
                return;
            }

            string strBookname = lvwBooks.SelectedItems[0].Text;
            bool exist = lstBorrow.Items.Contains(strBookname);

            if (!exist)
            {
                DialogResult dr = MessageBox.Show(
                    "確定要借閱嗎?",
                    strBookname,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    lstBorrow.Items.Add(strBookname);
                }
            }
        }

        private void LoadBookImages()
        {
            for (int i = 1; i <= b_name.Length; i++)
            {
                string imagePath = Path.Combine(Application.StartupPath, "Book" + i + ".bmp");
                if (File.Exists(imagePath))
                {
                    Image bookImage = Image.FromFile(imagePath);
                    imgL.Images.Add((Image)bookImage.Clone());
                    imgS.Images.Add((Image)bookImage.Clone());
                    bookImage.Dispose();
                }
            }
        }
    }
}
