using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_30_TB_Ran_ {
	internal class LoadToolBlock {

		public CogToolBlock ToolBlock { get; set; }

		private string tbPath = Directory.GetCurrentDirectory() + "\\vpp\\ToolBlock.vpp";

		public bool Loadvpp() { 
			ToolBlock = CogSerializer.LoadObjectFromFile(tbPath) as CogToolBlock;
			if ( ToolBlock == null ) {
				return false;
			} else {
				return true;
			}
		}
	}
}
