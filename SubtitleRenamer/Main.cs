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
            MovieController = new ListboxController();
            SubtitleController = new ListboxController();
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
                        MovieController.Sync(MovieList);
                        SubtitleController.Sync(SubtitleList);
                        progressBar.Maximum = MovieList.Items.Count;

                        for (int i = 0; i < MovieController.mFiles.Length; ++i)
                        {
                            int indexExtension = MovieController.mFiles[i].Name.LastIndexOf(".");
                            string fileName = MovieController.mFiles[i].Name.Substring(0, indexExtension) + SubtitleController.mFiles[i].Extension;
                            string path = SubtitleController.mFiles[i].DirectoryName + "\\" + fileName;

                            SubtitleController.mFiles[i].MoveTo(path);
                            SubtitleList.Items.RemoveAt(i);
                            SubtitleList.Items.Insert(i, fileName);
                            progressBar.PerformStep();
                        }

                        Label_status.Text = "변환 완료";
                        progressBar.Value = 0;
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
            string[] AddedList;

            if (sender.Equals(MovieList))
            {   //영상파일 리스트의 경우
                AddedList = MovieController.AddList(droppedFiles);

                foreach (var movie in AddedList)
                    MovieList.Items.Add(movie);
            }
            else if (sender.Equals(SubtitleList))
            {   //자막파일 리스트의 경우
                AddedList = SubtitleController.AddList(droppedFiles);

                foreach (var subtitle in AddedList)
                    SubtitleList.Items.Add(subtitle);
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
            if (SubtitleSortingButton.Checked)
                SubtitleList.Sorted = true;
            else
                SubtitleList.Sorted = false;
        }

        private void resetMovieList(object sender, EventArgs e)
        {
            SubtitleList.Items.Clear();
            SubtitleController.Clear();
        }

        private void resetSubtitleList(object sender, EventArgs e)
        {
            SubtitleList.Items.Clear();
            SubtitleController.Clear();
        }

        private void movieButtonUp(object sender, EventArgs e)
        {
            if (MovieList.SelectedIndex < 1)
                return;
            if (MovieSortingButton.Checked == true)
                MovieSortingButton.Checked = false;

            string tmp = (string)MovieList.SelectedItem;
            int indexSelected = MovieList.SelectedIndex;
            int indexPrev = indexSelected - 1;

            MovieList.Items.RemoveAt(indexSelected);
            MovieList.Items.Insert(indexPrev, tmp);
            MovieList.SetSelected(indexPrev, true);
        }

        private void movieButtonDown(object sender, EventArgs e)
        {
            if (MovieList.SelectedIndex >= MovieList.Items.Count - 1)
                return;
            if (MovieSortingButton.Checked == true)
                MovieSortingButton.Checked = false;

            string tmp = (string)MovieList.SelectedItem;
            int indexSelected = MovieList.SelectedIndex;
            int indexNext = indexSelected + 1;

            MovieList.Items.RemoveAt(indexSelected);
            MovieList.Items.Insert(indexNext, tmp);
            MovieList.SetSelected(indexNext, true);
        }

        private void subtitleButtonUp(object sender, EventArgs e)
        {
            if (SubtitleList.SelectedIndex < 1)
                return;
            if (SubtitleSortingButton.Checked == true)
                SubtitleSortingButton.Checked = false;

            string tmp = (string)SubtitleList.SelectedItem;
            int indexSelected = SubtitleList.SelectedIndex;
            int indexPrev = indexSelected - 1;

            SubtitleList.Items.RemoveAt(indexSelected);
            SubtitleList.Items.Insert(indexPrev, tmp);
            SubtitleList.SetSelected(indexPrev, true);
        }

        private void subtitleButtonDown(object sender, EventArgs e)
        {
            if (SubtitleList.SelectedIndex >= SubtitleList.Items.Count - 1)
                return;
            if (SubtitleSortingButton.Checked == true)
                SubtitleSortingButton.Checked = false;

            string tmp = (string)SubtitleList.SelectedItem;
            int indexSelected = SubtitleList.SelectedIndex;
            int indexNext = indexSelected + 1;

            SubtitleList.Items.RemoveAt(indexSelected);
            SubtitleList.Items.Insert(indexNext, tmp);
            SubtitleList.SetSelected(indexNext, true);
        }
    }
}
