using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 产品检测.Class {
	internal class LoadVpp {

		//声明工具
		public CogAcqFifoTool Cam { get; set; }
		public CogToolBlock ToolBlock { get; set; }
		//配置地址
		string path = Directory.GetCurrentDirectory() + "\\vpp\\CamSet.vpp";
		string tbPath = Directory.GetCurrentDirectory() + "\\vpp\\ToolBlockSet.vpp";

		/// <summary>
		/// 加载配置
		/// </summary>
		/// <returns></returns>
		public bool LoadVPP() {
			//更新配置
			Cam = CogSerializer.LoadObjectFromFile(path) as CogAcqFifoTool;
			ToolBlock = CogSerializer.LoadObjectFromFile(tbPath) as CogToolBlock;
			if ( Cam == null || ToolBlock == null ) {
				return false;
			} else {
				return true;
			}
		}
		/// <summary>
		/// 关闭相机
		/// </summary>
		public void CloseCam() {
			if ( Cam != null ) {
				Cam.Dispose();
			}
		}
	}
}
