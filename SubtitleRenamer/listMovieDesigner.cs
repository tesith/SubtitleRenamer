using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitleRenamer
{
    partial class SubtitleRenamer
    {
        private void InitializeComponentEx()
        {
            this.listMovie.AllowDrop = true;
            this.listMovie.FormattingEnabled = true;
            this.listMovie.HorizontalScrollbar = true;
            this.listMovie.ItemHeight = 12;
            this.listMovie.Location = new System.Drawing.Point(12, 25);
            this.listMovie.Name = "listMovie";
            this.listMovie.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listMovie.Size = new System.Drawing.Size(330, 256);
            this.listMovie.Sorted = true;
            this.listMovie.TabIndex = 0;
            this.listMovie.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listMovie.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.Controls.Add(listMovie);
        }
        
   }
}
