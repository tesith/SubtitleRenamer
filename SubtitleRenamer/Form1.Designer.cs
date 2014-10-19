namespace SubtitleRenamer
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_search_listbox1 = new System.Windows.Forms.Button();
            this.button_search_listbox2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button_reset_listbox1 = new System.Windows.Forms.Button();
            this.button_reset_listbox2 = new System.Windows.Forms.Button();
            this.button_up_listbox1 = new System.Windows.Forms.Button();
            this.button_up_listbox2 = new System.Windows.Forms.Button();
            this.button_progress = new System.Windows.Forms.Button();
            this.Label_status = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_index = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(330, 256);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "자막파일 (영상파일이 여러개면 개수 같아야함)";
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(348, 25);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(330, 256);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 3;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "영상파일 (1개 = 기준, 여러개 = 각각 매핑)";
            // 
            // button_search_listbox1
            // 
            this.button_search_listbox1.Location = new System.Drawing.Point(12, 287);
            this.button_search_listbox1.Name = "button_search_listbox1";
            this.button_search_listbox1.Size = new System.Drawing.Size(75, 23);
            this.button_search_listbox1.TabIndex = 5;
            this.button_search_listbox1.Text = "찾아보기...";
            this.button_search_listbox1.UseVisualStyleBackColor = true;
            // 
            // button_search_listbox2
            // 
            this.button_search_listbox2.Location = new System.Drawing.Point(348, 287);
            this.button_search_listbox2.Name = "button_search_listbox2";
            this.button_search_listbox2.Size = new System.Drawing.Size(75, 23);
            this.button_search_listbox2.TabIndex = 6;
            this.button_search_listbox2.Text = "찾아보기...";
            this.button_search_listbox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(203, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "자동정렬";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(540, 291);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "자동정렬";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button_reset_listbox1
            // 
            this.button_reset_listbox1.Location = new System.Drawing.Point(281, 287);
            this.button_reset_listbox1.Name = "button_reset_listbox1";
            this.button_reset_listbox1.Size = new System.Drawing.Size(60, 23);
            this.button_reset_listbox1.TabIndex = 9;
            this.button_reset_listbox1.Text = "초기화";
            this.button_reset_listbox1.UseVisualStyleBackColor = true;
            this.button_reset_listbox1.Click += new System.EventHandler(this.button_reset_listbox1_Click);
            // 
            // button_reset_listbox2
            // 
            this.button_reset_listbox2.Location = new System.Drawing.Point(618, 287);
            this.button_reset_listbox2.Name = "button_reset_listbox2";
            this.button_reset_listbox2.Size = new System.Drawing.Size(60, 23);
            this.button_reset_listbox2.TabIndex = 10;
            this.button_reset_listbox2.Text = "초기화";
            this.button_reset_listbox2.UseVisualStyleBackColor = true;
            this.button_reset_listbox2.Click += new System.EventHandler(this.button_reset_listbox2_Click);
            // 
            // button_up_listbox1
            // 
            this.button_up_listbox1.Location = new System.Drawing.Point(93, 287);
            this.button_up_listbox1.Name = "button_up_listbox1";
            this.button_up_listbox1.Size = new System.Drawing.Size(23, 23);
            this.button_up_listbox1.TabIndex = 11;
            this.button_up_listbox1.Text = "↑";
            this.button_up_listbox1.UseVisualStyleBackColor = true;
            // 
            // button_up_listbox2
            // 
            this.button_up_listbox2.Location = new System.Drawing.Point(429, 287);
            this.button_up_listbox2.Name = "button_up_listbox2";
            this.button_up_listbox2.Size = new System.Drawing.Size(23, 23);
            this.button_up_listbox2.TabIndex = 12;
            this.button_up_listbox2.Text = "↑";
            this.button_up_listbox2.UseVisualStyleBackColor = true;
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
            this.Label_status.Location = new System.Drawing.Point(98, 322);
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
            this.progressBar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Index of number : ";
            // 
            // Label_index
            // 
            this.Label_index.AutoSize = true;
            this.Label_index.Location = new System.Drawing.Point(127, 358);
            this.Label_index.Name = "Label_index";
            this.Label_index.Size = new System.Drawing.Size(29, 12);
            this.Label_index.TabIndex = 17;
            this.Label_index.Text = "대기";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 382);
            this.Controls.Add(this.Label_index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Label_status);
            this.Controls.Add(this.button_progress);
            this.Controls.Add(this.button_up_listbox2);
            this.Controls.Add(this.button_up_listbox1);
            this.Controls.Add(this.button_reset_listbox2);
            this.Controls.Add(this.button_reset_listbox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button_search_listbox2);
            this.Controls.Add(this.button_search_listbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Subtitle Renamer v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_search_listbox1;
        private System.Windows.Forms.Button button_search_listbox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button_reset_listbox1;
        private System.Windows.Forms.Button button_reset_listbox2;
        private System.Windows.Forms.Button button_up_listbox1;
        private System.Windows.Forms.Button button_up_listbox2;
        private System.Windows.Forms.Button button_progress;
        private System.Windows.Forms.Label Label_status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_index;
    }
}

