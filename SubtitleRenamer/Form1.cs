using System;
//using System.IO;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;


//using System.Text.RegularExpressions;   //정규표현식

namespace SubtitleRenamer
{
    public partial class Form1 : Form
    {
        //bool bool_thread_status = false;
        ListboxController listMovie = new ListboxController();
        ListboxController listSubtitle = new ListboxController();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            String[] strParam = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            String[] strAddedList = new String[strParam.Length];
            switch (sender.Equals(listBox1))
            {
                case true:      //영상파일 리스트의 경우
                    strAddedList = listMovie.addList(strParam);
                    for (int i = 0; i < strAddedList.Length; i++)
                    {
                        listBox1.Items.Add(strAddedList[i]);
                    }
                    break;
                case false:     //자막파일 리스트의 경우
                    strAddedList = listSubtitle.addList(strParam);

                    for (int i = 0; i < strAddedList.Length; i++)
                    {
                        listBox2.Items.Add(strAddedList[i]);
                    }
                    break;
            }
        }
        /*
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            String[] strParam = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            String[] strAddedList = new String[strParam.Length];
            strAddedList = listSubtitle.addList(strParam);

            for (int i = 0; i < strAddedList.Length; i++)
            {
                listBox2.Items.Add(strAddedList[i]);
            }

            /*
            strDroppedFiles2 = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            FileInfo[] newFile = new FileInfo[strDroppedFiles2.Length+fileinfo2.Length];

            for (int i = 0; i < fileinfo2.Length; i++)
            {
                newFile[i] = fileinfo2[i];
            }

            for (int i = 0; i < strDroppedFiles2.Length; i++)
            {
                newFile[fileinfo2.Length + i] = new FileInfo(strDroppedFiles2[i]);
                listBox2.Items.Add(newFile[fileinfo2.Length + i].Name);
            }
            fileinfo2 = newFile;
            
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                listBox1.Sorted = true;
            }else{
                listBox1.Sorted = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
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

        private void button_reset_listbox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listMovie.Clear();
        }

        private void button_reset_listbox2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listSubtitle.Clear();
        }

        private void button_progress_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (listBox1.Items.Count != 0 && listBox2.Items.Count != 0)
                {
                    if (listBox1.Items.Count == listBox2.Items.Count)
                    {
                        progressBar.Maximum = listBox1.Items.Count;
                        listBox1.SetSelected(0, true);
                        listBox2.SetSelected(0, true);

                        for (int realCount = 0; realCount < listMovie.mFileinfo.Length; realCount++)
                        {
                            bool esc = false;
                            for (int i = 0; i < listMovie.mFileinfo.Length && esc == false; i++)
                            {
                                if (listBox1.SelectedItem.ToString() == listMovie.mFileinfo[i].Name)
                                {
                                    for (int j = 0; j < listSubtitle.mFileinfo.Length && esc == false; j++)
                                    {
                                        if (listBox2.SelectedItem.ToString() == listSubtitle.mFileinfo[j].Name)
                                        {
                                            int index_ext = listMovie.mFileinfo[i].Name.LastIndexOf(".");
                                            String substr = listMovie.mFileinfo[i].Name.Substring(0, index_ext);
                                            listSubtitle.mFileinfo[j].MoveTo(listSubtitle.mFileinfo[j].DirectoryName + "\\" + substr + listSubtitle.mFileinfo[j].Extension);
                                            esc = true;
                                            progressBar.PerformStep();
                                        }
                                    }
                                }
                            }
                            if (!(listBox1.Items.Count == listBox1.SelectedIndex + 1))
                            {
                                listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                                listBox1.SetSelected(listBox1.SelectedIndex, false);
                                listBox2.SetSelected(listBox2.SelectedIndex + 1, true);
                                listBox2.SetSelected(listBox2.SelectedIndex, false);
                            }
                        }
                        listBox1.SetSelected(listBox1.SelectedIndex, false);
                        listBox2.SetSelected(listBox2.SelectedIndex, false);
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
                Label_status.Text = err.ToString();
            }
        }
    }
}
