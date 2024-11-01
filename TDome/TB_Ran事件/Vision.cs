using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Ran事件
{
    internal class Vision
    {

        public CogToolBlock TB {  get; set; }


        private string TB_Path = Directory.GetCurrentDirectory() + "\\vpp\\ToolBlock.vpp";


        public bool LoadVPP()
        {
            TB = CogSerializer.LoadObjectFromFile(TB_Path) as CogToolBlock;

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
