using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;



namespace SubtitleRenamer
{
    static class FileInfoExtension
    {
        public static IEnumerable<int> CustomOrderBy(this BindingList<FileInfo> list, Func<FileInfo, int> f)
        {
            foreach (FileInfo elem in list)
                yield return f(elem);
        }
    }

    public class ListboxController
    {
        public class CustomFileInfo
        {
            public FileInfo fi;
            public string VisibleName
            {
                get
                {
                    return fi.Name;
                }
            }

            public CustomFileInfo(FileInfo f)
            {
                fi = f;
            }

        }

        

        public BindingList<CustomFileInfo> List { get; set; } = new BindingList<CustomFileInfo>();
        
        public ListboxController(ListBox listbox)
        {
            listbox.DataSource = List;
        }

        public void Clear()
        {
            List.Clear();
        }
        
        public void AddList(string[] droppedFiles)
        {
            for( int i=0; i < droppedFiles.Length; ++i)
            {
                List.Add(new CustomFileInfo( new FileInfo(droppedFiles[i])));
            }
        }

        public bool Swap(int index1, int index2)
        {
            if (index1 < 0 || index1 >= List.Count) return false;
            if (index2 < 0 || index2 >= List.Count) return false;

            CustomFileInfo cfi = List[index1];
            List[index1] = List[index2];
            List[index2] = cfi;
            return true;
        }

        public void Sort()
        {
            IEnumerable<string> l = List.Select(cfi => { return cfi.VisibleName; })
                                        .OrderBy((string a,string b) => { return a.CompareTo(b); });
            l.OrderBy((string a, string b) => { return a.CompareTo(b); });
            IEnumerable<int> result = List.CustomOrderBy(n => n * 2);
            List.CustomOrderBy(() => { });
        }
    }
}
