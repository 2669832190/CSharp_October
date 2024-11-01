using Cognex.VisionPro;
using Cognex.VisionPro.Implementation;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace _10_30作业 {
	internal class LoadVPP {
		public CogToolBlock toolBlock { get; set; }

		private string Path = Directory.GetCurrentDirectory() + "\\vpp\\ToolBlock.vpp";

		/// <summary>
		/// 加载工具盒配置
		/// </summary>
		/// <returns>返回是否成功加载</returns>
		public bool LoadToolBlock() { 
			toolBlock = CogSerializer.LoadObjectFromFile(Path) as CogToolBlock;
			if ( toolBlock == null ) {
				return false;
			} else { 
				return true;
			}
		}



	}
}
