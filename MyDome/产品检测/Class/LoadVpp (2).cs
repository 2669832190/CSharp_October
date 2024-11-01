using Cognex.VisionPro.ToolBlock;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.VisionPro.Implementation;
using Cognex.VisionPro;

namespace _10_30_TB工具盒_ {
	internal class LoadVpp {
		//声明工具
		public CogAcqFifoTool AcqFifo { get; set; }
		public CogToolBlock ToolBlock { get; set; }
		//配置地址
		string acqPath = Directory.GetCurrentDirectory() + "\\vpp\\AcqFifo.vpp";
		string tbPath = Directory.GetCurrentDirectory() + "\\vpp\\TB.vpp";

		/// <summary>
		/// 加载配置
		/// </summary>
		/// <returns></returns>
		public bool LoadVPP() { 
			//更新配置
			AcqFifo = CogSerializer.LoadObjectFromFile(acqPath) as CogAcqFifoTool;
			ToolBlock = CogSerializer.LoadObjectFromFile(tbPath) as CogToolBlock;
			AcqFifo.Operator.OwnedExposureParams.Exposure = 200;
			if ( AcqFifo == null || ToolBlock == null ) {
				return false;
			} else { 
				return true;
			}
		}
		/// <summary>
		/// 关闭相机
		/// </summary>
		public void CloseCam() {
			if ( AcqFifo != null ) { 
				AcqFifo.Dispose();
			}
		}
	}
}
