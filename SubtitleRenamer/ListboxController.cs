using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace SubtitleRenamer
{
    public class ListboxController
    {
        public FileInfo[] mFileinfo;

        public ListboxController()
        {
            mFileinfo = new FileInfo[0];
        }

        public void Clear()
        {
            mFileinfo = new FileInfo[0];
        }

        /*
         * 파일 리스트를 추가하는 함수
         * 추가에 성공한 파일 리스트를 String[] 형으로 반환한다.
         */
        public String[] addList(string[] strDroppedFiles)
        {
            String[] retOKstring = new String[strDroppedFiles.Length];
            FileInfo[] newFile = new FileInfo[strDroppedFiles.Length + mFileinfo.Length];

            for (int i = 0; i < mFileinfo.Length; i++)
            {
                newFile[i] = mFileinfo[i];
            }

            for (int i = 0; i < strDroppedFiles.Length; i++)
            {
                newFile[mFileinfo.Length + i] = new FileInfo(strDroppedFiles[i]);
                retOKstring[i] = newFile[mFileinfo.Length + i].Name;
            }
            mFileinfo = newFile;
            return retOKstring;
        }
    }
}
