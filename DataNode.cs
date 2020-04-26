using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace searchStr
{
    public class DataNode : TreeNode
    {
        public bool isFile;
        private string data;
        public bool isLoaded;
        public DataNode(string nodeName) : base(nodeName)
        {
            this.ImageIndex = 1;
            this.SelectedImageIndex = 1;
            this.isLoaded = false;
            this.isFile = false;
        }
        public void setData(string input)
        {
            data = input;
        }
        public string getData()
        {
            return data;
        }
    }
}
