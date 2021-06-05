using System;
using System.IO;
using System.Windows.Forms;

namespace SubtitleRenamer
{
    public partial class SubtitleRenamer : Form
    {
        ListboxController MovieController;
        ListboxController SubtitleController;

        public SubtitleRenamer()
        {
            InitializeComponent();
            MovieController = new ListboxController(MovieList);
            SubtitleController = new ListboxController(SubtitleList);
        }

        private void button_progress_Click(object sender, EventArgs e)
        {
#if DEBUG
            DateTime dtStart = DateTime.Now;
            DateTime dtEnd;
#endif
            try
            {
                // 파일 올라갔는지 확인
                if (MovieList.Items.Count != 0 && SubtitleList.Items.Count != 0)
                {
                    // 파일 개수 일치 확인
                    if (MovieList.Items.Count == SubtitleList.Items.Count)
                    {
                        progressBar.Value = 0;
                        progressBar.Maximum = MovieList.Items.Count;

                        for (int i = 0; i < MovieController.List.Count; ++i)
                        {
                            int indexExtension = MovieController.List[i].fi.Name.LastIndexOf(".");
                            string fileName = MovieController.List[i].fi.Name.Substring(0, indexExtension) + SubtitleController.List[i].fi.Extension;
                            string path = SubtitleController.List[i].fi.DirectoryName + "\\" + fileName;

                            SubtitleController.List[i].fi.MoveTo(path);
                            SubtitleController.List[i].fi.Refresh();
                            //SubtitleList.Items.RemoveAt(i);
                            //SubtitleList.Items.Insert(i, fileName);
                            progressBar.Value++;
                        }

                        Label_status.Text = "변환 완료";
                    }
                    else
                        Label_status.Text = "양쪽 파일의 개수가 일치해야 합니다";
                }
                else
                    Label_status.Text = "파일이 선택되지 않았습니다";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
#if DEBUG
            dtEnd = DateTime.Now;
            label3.Text = (dtEnd - dtStart).ToString();
#endif
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            if (sender.Equals(MovieList))
            {   //영상파일 리스트의 경우
                MovieController.AddList(droppedFiles);
            }
            else if (sender.Equals(SubtitleList))
            {   //자막파일 리스트의 경우
                SubtitleController.AddList(droppedFiles);
            }
            else
            {
                Label_status.Text = "Error 01: listBox_DragDrop Exception";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if DEBUG
            label3.Visible = true;
#endif
        }

        private void movieSortingChanged(object sender, EventArgs e)
        {
            if (MovieSortingButton.Checked)
                MovieList.Sorted = true;
            else
                MovieList.Sorted = false;
        }

        private void subtitleSortingChanged(object sender, EventArgs e)
        {
            SubtitleController.List.
            if (SubtitleSortingButton.Checked)
                SubtitleList.Sorted = true;
            else
                SubtitleList.Sorted = false;
        }

        private void resetMovieList(object sender, EventArgs e)
        {
            MovieController.Clear();
        }

        private void resetSubtitleList(object sender, EventArgs e)
        {
            SubtitleController.Clear();
        }

        private void ProcessUpDownButton(ListBox list, ListboxController controller, CheckBox SortButton, bool bUp)
        {
            int indexSelected = list.SelectedIndex;
            int indexPrev = indexSelected + ( bUp ? -1 : 1 );

            if (controller.Swap(indexPrev, indexSelected) )
            {
                list.SetSelected(indexPrev, true);
                list.SetSelected(indexSelected, false);
                if (SortButton.Checked == true)
                    SortButton.Checked = false;
            }
        }

        private void movieButtonUp(object sender, EventArgs e)
        {
            ProcessUpDownButton(MovieList, MovieController, MovieSortingButton, true);
        }

        private void movieButtonDown(object sender, EventArgs e)
        {
            ProcessUpDownButton(MovieList, MovieController, MovieSortingButton, false);
        }

        private void subtitleButtonUp(object sender, EventArgs e)
        {
            ProcessUpDownButton(SubtitleList, SubtitleController, SubtitleSortingButton, true);
        }

        private void subtitleButtonDown(object sender, EventArgs e)
        {
            ProcessUpDownButton(SubtitleList, SubtitleController, SubtitleSortingButton, false);
        }
    }
}
