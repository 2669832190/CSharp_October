using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业
{
    internal class Vision
    {

        public CogToolBlock TB { get; set; }

        public string TB_path = Directory.GetCurrentDirectory() + "\\vpp\\ToolBlock.vpp";

        public bool LoadVpp()
        {
            TB = CogSerializer.LoadObjectFromFile(TB_path) as CogToolBlock;

            if(TB == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
