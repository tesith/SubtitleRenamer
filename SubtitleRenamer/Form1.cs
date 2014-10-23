using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;   //정규표현식

namespace SubtitleRenamer
{
    public partial class Form1 : Form
    {
        bool bool_thread_status = false;

        FileInfo[] fileinfo1 = new FileInfo[0];
        String[] strDroppedFiles1 = new String[0];

        FileInfo[] fileinfo2 = new FileInfo[0];
        String[] strDroppedFiles2 = new String[0];


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            strDroppedFiles1 = (String[])e.Data.GetData(DataFormats.FileDrop, false);
            FileInfo[] newFile = new FileInfo[strDroppedFiles1.Length + fileinfo1.Length];
            
            for (int i = 0; i < fileinfo1.Length; i++)
            {
                newFile[i] = fileinfo1[i];
            }

            for (int i = 0; i < strDroppedFiles1.Length; i++)
            {
                newFile[fileinfo1.Length + i] = new FileInfo(strDroppedFiles1[i]);
                listBox1.Items.Add(newFile[fileinfo1.Length + i].Name);
            }
            fileinfo1 = newFile;
            /*
            if (fileinfo1.Length == 1)
            {
                int index_of_num = fileinfo1[0].Name.IndexOf("[0-9]");
                index_of_num = Regex.Match(fileinfo1[0].Name, @"\d\d").Index;
                //Label_index.Text = index_of_num.ToString();
            }
            */
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
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
            strDroppedFiles1 = new String[0];
            fileinfo1 = new FileInfo[0];
        }

        private void button_reset_listbox2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            strDroppedFiles2 = new String[0];
            fileinfo2 = new FileInfo[0];
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

                        for (int realCount = 0; realCount < fileinfo1.Length; realCount++)
                        {
                            bool esc = false;
                            for (int i = 0; i < fileinfo1.Length && esc == false; i++)
                            {
                                if (listBox1.SelectedItem.ToString() == fileinfo1[i].Name)
                                {
                                    for (int j = 0; j < fileinfo2.Length && esc == false; j++)
                                    {
                                        if (listBox2.SelectedItem.ToString() == fileinfo2[j].Name)
                                        {
                                            int index_ext = fileinfo1[i].Name.LastIndexOf(".");
                                            String substr = fileinfo1[i].Name.Substring(0, index_ext);
                                            fileinfo2[j].MoveTo(fileinfo2[j].DirectoryName + "\\" + substr + fileinfo2[j].Extension);
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
