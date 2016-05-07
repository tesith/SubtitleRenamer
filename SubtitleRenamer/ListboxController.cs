using System;
using System.IO;
using System.Windows.Forms;

namespace SubtitleRenamer
{
    public class ListboxController
    {
        public FileInfo[] mFiles { get; set; } = new FileInfo[0];
        
        public void Clear()
        {
            mFiles = new FileInfo[0];
        }

        
        public string[] AddList(string[] droppedFiles)
        {
            var returns = new string[droppedFiles.Length];
            FileInfo[] tmpFiles = new FileInfo[droppedFiles.Length + mFiles.Length];

            for (int i = 0; i < mFiles.Length; i++)
            {
                tmpFiles[i] = mFiles[i];
            }

            for (int i = 0; i < droppedFiles.Length; i++)
            {
                tmpFiles[mFiles.Length + i] = new FileInfo(droppedFiles[i]);
                returns[i] = tmpFiles[mFiles.Length + i].Name;
            }

            mFiles = tmpFiles;
            return returns;
        }
        

        public void Sync(ListBox listBox)
        {
            FileInfo[] tmpFiles = mFiles;
            mFiles = new FileInfo[listBox.Items.Count];

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                int index = listBox.FindString(tmpFiles[i].Name);
                mFiles[index] = tmpFiles[i];
            }
        }
    }
}
