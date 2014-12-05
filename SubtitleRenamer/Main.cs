#undef DEBUG

using System;
using System.IO;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;


//using System.Text.RegularExpressions;   //정규표현식

namespace SubtitleRenamer
{
    public partial class SubtitleRenamer : Form
    {
        
        //bool bool_thread_status = false;
        ListboxController listMovie = new ListboxController();
        ListboxController listSubtitle = new ListboxController();
        
        public SubtitleRenamer()
        {
            InitializeComponent();
        }


        private void button_listupdown(object sender, EventArgs e)
        {
#if DEBUG
           if (sender.Equals(button_mov_list_up))
           {
               int IndexOfSelected = listBox1.SelectedIndex;
               int NextIndex = IndexOfSelected + 1;
               object tmplist = listBox1.SelectedItem;

               /*
               if (IndexOfSelected > -1 && IndexOfSelected != listBox1.Items.Count-1)
               {
                   listBox1.Items.Insert(IndexOfSelected + 1, listBox1.SelectedItem);
                   listBox1.ClearSelected();
                   listBox1.SetSelected(IndexOfSelected + 1, true);
                   listBox1.Items.RemoveAt(IndexOfSelected);
                   Label_status.Text = "변환됨";
               }
               */
           }else if(sender.Equals(button_mov_list_down)){

           }
#endif
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            String[] strParam = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            String[] FileAddedList = new String[strParam.Length];

            if (sender.Equals(listBox1))
            {   //영상파일 리스트의 경우
                FileAddedList = listMovie.AddList(strParam);
                
                for (int i = 0; i < FileAddedList.Length; i++)
                {
                    listBox1.Items.Add(FileAddedList[i]);
                }
            }
            else if (sender.Equals(listBox2))
            {   //자막파일 리스트의 경우
                FileAddedList = listSubtitle.AddList(strParam);

                for (int i = 0; i < FileAddedList.Length; i++)
                {
                    listBox2.Items.Add(FileAddedList[i]);
                }
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

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.Equals(checkBox1))
            {
                if (checkBox1.Checked)
                {
                    listBox1.Sorted = true;
                }
                else
                {
                    listBox1.Sorted = false;
                }
            }
            else if(sender.Equals(checkBox2))
            {
                if (checkBox2.Checked)
                {
                    listBox2.Sorted = true;
                }
                else
                {
                    listBox2.Sorted = false;
                }
            }
            else
            {
                Label_status.Text = "Error 02: checkBox_CheckedChanged Exception";
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (sender.Equals(button_reset_listbox1))
            {
                listBox1.Items.Clear();
                listMovie.Clear();
            }
            else if(sender.Equals(button_reset_listbox2))
            {
                listBox2.Items.Clear();
                listSubtitle.Clear();
            }
            else
            {
                Label_status.Text = "Error 03: button_reset_Click Exception";
            }
        }

        private void button_progress_Click(object sender, EventArgs e)
        {
#if DEBUG
            DateTime dtStart = DateTime.Now;
            DateTime dtEnd;
#endif
            try
            {
                if (listBox1.Items.Count != 0 && listBox2.Items.Count != 0)
                {
                    if (listBox1.Items.Count == listBox2.Items.Count)
                    {
                        listMovie.Sync(listBox1);
                        listSubtitle.Sync(listBox2);
                        progressBar.Maximum = listBox1.Items.Count;
                        
                        for (int i = 0; i < listMovie.mFileinfo.Length; i++)
                        {
                            int index_ext = listMovie.mFileinfo[i].Name.LastIndexOf(".");
                            String FileName_exclude_Extention = listMovie.mFileinfo[i].Name.Substring(0, index_ext);
                            listSubtitle.mFileinfo[i].MoveTo(listSubtitle.mFileinfo[i].DirectoryName + "\\" + FileName_exclude_Extention + listSubtitle.mFileinfo[i].Extension);
                            progressBar.PerformStep();
                        }
                            
                        Label_status.Text = "변환 완료";
                        progressBar.Value = 0;
                    }
                    else
                    {
                        Label_status.Text = "양쪽 파일의 개수가 일치해야 합니다";
                    }
                }
                else
                {
                    Label_status.Text = "파일이 선택되지 않았습니다";
                }
            }catch(Exception err){
                MessageBox.Show(err.ToString());
            }
#if DEBUG
            dtEnd = DateTime.Now;
            label3.Text = (dtEnd - dtStart).ToString();
#endif
        }

    }
}
