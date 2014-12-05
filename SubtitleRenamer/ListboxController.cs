using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

using System.IO;
using System.Windows.Forms;

namespace SubtitleRenamer
{
    public class ListboxController : ListBox
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
         * 추가에 성공한 파일 리스트를 FileInfo[] 형으로 반환한다.
         */
        public String[] AddList(string[] strDroppedFiles)
        {
            String[] strReturn = new String[strDroppedFiles.Length];
            FileInfo[] tmpFile = new FileInfo[strDroppedFiles.Length + mFileinfo.Length];

            for (int i = 0; i < mFileinfo.Length; i++)
            {
                tmpFile[i] = mFileinfo[i];
            }

            for (int i = 0; i < strDroppedFiles.Length; i++)
            {
                tmpFile[mFileinfo.Length + i] = new FileInfo(strDroppedFiles[i]);
                strReturn[i] = tmpFile[mFileinfo.Length + i].Name;
            }

            mFileinfo = tmpFile;
            return strReturn;
        }

        public void Sync(ListBox obj)
        {
            FileInfo[] tmpFile;
            tmpFile = mFileinfo;

            mFileinfo = new FileInfo[obj.Items.Count];

            /*
             * 시간잡아먹는 주범
             */
            for(int i = 0 ; i < obj.Items.Count ; i++){
                for (int j = 0; j < obj.Items.Count; j++)
                {
                    if (obj.Items[i].ToString() == tmpFile[j].Name)
                    {
                        mFileinfo[i] = tmpFile[j];
                    }
                }
            }
        }
    }



}
