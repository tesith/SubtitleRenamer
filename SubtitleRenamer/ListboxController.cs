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
        public FileInfo[] m_aFileinfo;

        public ListboxController()
        {
            m_aFileinfo = new FileInfo[0];
        }

        public void Clear()
        {
            m_aFileinfo = new FileInfo[0];
        }

        /*
        * 파일 리스트를 추가하는 함수
        * 추가에 성공한 파일 리스트를 FileInfo[] 형으로 반환한다.
        */
        public String[] AddList(string[] strDroppedFiles)
        {
            String[] strReturn = new String[strDroppedFiles.Length];
            FileInfo[] tmpFile = new FileInfo[strDroppedFiles.Length + m_aFileinfo.Length];

            for (int i = 0; i < m_aFileinfo.Length; i++)
            {
                tmpFile[i] = m_aFileinfo[i];
            }

            for (int i = 0; i < strDroppedFiles.Length; i++)
            {
                tmpFile[m_aFileinfo.Length + i] = new FileInfo(strDroppedFiles[i]);
                strReturn[i] = tmpFile[m_aFileinfo.Length + i].Name;
            }
            

            m_aFileinfo = tmpFile;
            return strReturn;
        }

        public void Sync(ListBox obj)
        {
            FileInfo[] tmpFile;
            tmpFile = m_aFileinfo;
            
            m_aFileinfo = new FileInfo[obj.Items.Count];
            for(int i = 0; i < obj.Items.Count; i++){
                int index = obj.FindString(tmpFile[i].Name);
                m_aFileinfo[index] = tmpFile[i];
            }

            
            
            /*
             * 시간잡아먹는 주범
             */

            /*
            for (int i = 0; i < obj.Items.Count; i++)
            {
                if (obj.Items[i].ToString() == tmpFile[i].Name)
                {
                    mFileinfo[i] = tmpFile.Dequeue();
                }
            }
            */
        }
    }

}
