namespace SubtitleRenamer
{
    partial class SubtitleRenamer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtitleRenamer));
            this.MovieList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubtitleList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieSortingButton = new System.Windows.Forms.CheckBox();
            this.SubtitleSortingButton = new System.Windows.Forms.CheckBox();
            this.button_reset_listbox1 = new System.Windows.Forms.Button();
            this.button_reset_listbox2 = new System.Windows.Forms.Button();
            this.button_progress = new System.Windows.Forms.Button();
            this.Label_status = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_mov_list_up = new System.Windows.Forms.Button();
            this.button_mov_list_down = new System.Windows.Forms.Button();
            this.button_sub_list_up = new System.Windows.Forms.Button();
            this.button_sub_list_down = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieList
            // 
            this.MovieList.AllowDrop = true;
            this.MovieList.FormattingEnabled = true;
            this.MovieList.HorizontalScrollbar = true;
            this.MovieList.ItemHeight = 12;
            this.MovieList.Location = new System.Drawing.Point(14, 25);
            this.MovieList.Name = "MovieList";
            this.MovieList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MovieList.Size = new System.Drawing.Size(328, 256);
            this.MovieList.Sorted = true;
            this.MovieList.TabIndex = 0;
            this.MovieList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.MovieList.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "자막파일";
            // 
            // SubtitleList
            // 
            this.SubtitleList.AllowDrop = true;
            this.SubtitleList.FormattingEnabled = true;
            this.SubtitleList.HorizontalScrollbar = true;
            this.SubtitleList.ItemHeight = 12;
            this.SubtitleList.Location = new System.Drawing.Point(348, 25);
            this.SubtitleList.Name = "SubtitleList";
            this.SubtitleList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SubtitleList.Size = new System.Drawing.Size(330, 256);
            this.SubtitleList.Sorted = true;
            this.SubtitleList.TabIndex = 3;
            this.SubtitleList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.SubtitleList.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "영상파일";
            // 
            // MovieSortingButton
            // 
            this.MovieSortingButton.AutoSize = true;
            this.MovieSortingButton.Checked = true;
            this.MovieSortingButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MovieSortingButton.Location = new System.Drawing.Point(204, 291);
            this.MovieSortingButton.Name = "MovieSortingButton";
            this.MovieSortingButton.Size = new System.Drawing.Size(72, 16);
            this.MovieSortingButton.TabIndex = 7;
            this.MovieSortingButton.Text = "자동정렬";
            this.MovieSortingButton.UseVisualStyleBackColor = true;
            this.MovieSortingButton.CheckedChanged += new System.EventHandler(this.movieSortingChanged);
            // 
            // SubtitleSortingButton
            // 
            this.SubtitleSortingButton.AutoSize = true;
            this.SubtitleSortingButton.Checked = true;
            this.SubtitleSortingButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubtitleSortingButton.Location = new System.Drawing.Point(540, 291);
            this.SubtitleSortingButton.Name = "SubtitleSortingButton";
            this.SubtitleSortingButton.Size = new System.Drawing.Size(72, 16);
            this.SubtitleSortingButton.TabIndex = 8;
            this.SubtitleSortingButton.Text = "자동정렬";
            this.SubtitleSortingButton.UseVisualStyleBackColor = true;
            this.SubtitleSortingButton.CheckedChanged += new System.EventHandler(this.subtitleSortingChanged);
            // 
            // button_reset_listbox1
            // 
            this.button_reset_listbox1.Location = new System.Drawing.Point(282, 287);
            this.button_reset_listbox1.Name = "button_reset_listbox1";
            this.button_reset_listbox1.Size = new System.Drawing.Size(60, 23);
            this.button_reset_listbox1.TabIndex = 9;
            this.button_reset_listbox1.Text = "초기화";
            this.button_reset_listbox1.UseVisualStyleBackColor = true;
            this.button_reset_listbox1.Click += new System.EventHandler(this.resetMovieList);
            // 
            // button_reset_listbox2
            // 
            this.button_reset_listbox2.Location = new System.Drawing.Point(618, 287);
            this.button_reset_listbox2.Name = "button_reset_listbox2";
            this.button_reset_listbox2.Size = new System.Drawing.Size(60, 23);
            this.button_reset_listbox2.TabIndex = 10;
            this.button_reset_listbox2.Text = "초기화";
            this.button_reset_listbox2.UseVisualStyleBackColor = true;
            this.button_reset_listbox2.Click += new System.EventHandler(this.resetSubtitleList);
            // 
            // button_progress
            // 
            this.button_progress.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_progress.Location = new System.Drawing.Point(12, 322);
            this.button_progress.Name = "button_progress";
            this.button_progress.Size = new System.Drawing.Size(75, 23);
            this.button_progress.TabIndex = 13;
            this.button_progress.Text = "변환시작";
            this.button_progress.UseVisualStyleBackColor = true;
            this.button_progress.Click += new System.EventHandler(this.button_progress_Click);
            // 
            // Label_status
            // 
            this.Label_status.AutoSize = true;
            this.Label_status.Location = new System.Drawing.Point(93, 327);
            this.Label_status.Name = "Label_status";
            this.Label_status.Size = new System.Drawing.Size(177, 12);
            this.Label_status.TabIndex = 14;
            this.Label_status.Text = "파일을 드래그 앤 드랍 해주세요";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(512, 322);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(166, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 15;
            // 
            // button_mov_list_up
            // 
            this.button_mov_list_up.Location = new System.Drawing.Point(12, 287);
            this.button_mov_list_up.Name = "button_mov_list_up";
            this.button_mov_list_up.Size = new System.Drawing.Size(23, 23);
            this.button_mov_list_up.TabIndex = 16;
            this.button_mov_list_up.Text = "↑";
            this.button_mov_list_up.UseVisualStyleBackColor = true;
            this.button_mov_list_up.Click += new System.EventHandler(this.movieButtonUp);
            // 
            // button_mov_list_down
            // 
            this.button_mov_list_down.Location = new System.Drawing.Point(41, 287);
            this.button_mov_list_down.Name = "button_mov_list_down";
            this.button_mov_list_down.Size = new System.Drawing.Size(23, 23);
            this.button_mov_list_down.TabIndex = 17;
            this.button_mov_list_down.Text = "↓";
            this.button_mov_list_down.UseVisualStyleBackColor = true;
            this.button_mov_list_down.Click += new System.EventHandler(this.movieButtonDown);
            // 
            // button_sub_list_up
            // 
            this.button_sub_list_up.Location = new System.Drawing.Point(348, 287);
            this.button_sub_list_up.Name = "button_sub_list_up";
            this.button_sub_list_up.Size = new System.Drawing.Size(23, 23);
            this.button_sub_list_up.TabIndex = 18;
            this.button_sub_list_up.Text = "↑";
            this.button_sub_list_up.UseVisualStyleBackColor = true;
            this.button_sub_list_up.Click += new System.EventHandler(this.subtitleButtonUp);
            // 
            // button_sub_list_down
            // 
            this.button_sub_list_down.Location = new System.Drawing.Point(377, 287);
            this.button_sub_list_down.Name = "button_sub_list_down";
            this.button_sub_list_down.Size = new System.Drawing.Size(23, 23);
            this.button_sub_list_down.TabIndex = 19;
            this.button_sub_list_down.Text = "↓";
            this.button_sub_list_down.UseVisualStyleBackColor = true;
            this.button_sub_list_down.Click += new System.EventHandler(this.subtitleButtonDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "Debug";
            this.label3.Visible = false;
            // 
            // SubtitleRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 354);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_sub_list_down);
            this.Controls.Add(this.button_sub_list_up);
            this.Controls.Add(this.button_mov_list_down);
            this.Controls.Add(this.button_mov_list_up);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Label_status);
            this.Controls.Add(this.button_progress);
            this.Controls.Add(this.button_reset_listbox2);
            this.Controls.Add(this.button_reset_listbox1);
            this.Controls.Add(this.SubtitleSortingButton);
            this.Controls.Add(this.MovieSortingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubtitleList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SubtitleRenamer";
            this.Text = "Subtitle Renamer v1.3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SubtitleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MovieSortingButton;
        private System.Windows.Forms.CheckBox SubtitleSortingButton;
        private System.Windows.Forms.Button button_reset_listbox1;
        private System.Windows.Forms.Button button_reset_listbox2;
        private System.Windows.Forms.Button button_progress;
        private System.Windows.Forms.Label Label_status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_mov_list_up;
        private System.Windows.Forms.Button button_mov_list_down;
        private System.Windows.Forms.Button button_sub_list_up;
        private System.Windows.Forms.Button button_sub_list_down;
        private System.Windows.Forms.ListBox MovieList;
        private System.Windows.Forms.Label label3;
    }
}

