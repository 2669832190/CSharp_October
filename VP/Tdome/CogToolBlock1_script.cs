#region namespace imports
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro3D;
using Cognex.VisionPro.Blob;
using Cognex.VisionPro.Caliper;
#endregion

public class CogToolBlockAdvancedScript : CogToolBlockAdvancedScriptBase
{
  #region Private Member Variables
  private Cognex.VisionPro.ToolBlock.CogToolBlock mToolBlock;
  private CogGraphicCollection col = new CogGraphicCollection();
  #endregion

  /// <summary>
  /// Called when the parent tool is run.
  /// Add code here to customize or replace the normal run behavior.
  /// </summary>
  /// <param name="message">Sets the Message in the tool's RunStatus.</param>
  /// <param name="result">Sets the Result in the tool's RunStatus</param>
  /// <returns>True if the tool should run normally,
  ///          False if GroupRun customizes run behavior</returns>
  public override bool GroupRun(ref string message, ref CogToolResultConstants result)
  {
    // To let the execution stop in this script when a debugger is attached, uncomment the following lines.
    // #if DEBUG
    // if (System.Diagnostics.Debugger.IsAttached) System.Diagnostics.Debugger.Break();
    // #endif
    
    //先清空集合
    col.Clear();

    //找工具
    CogBlobTool blob1 = mToolBlock.Tools["CogBlobTool1"] as CogBlobTool;
    CogCaliperTool cali1 = mToolBlock.Tools["CogCaliperTool1"] as CogCaliperTool;

    // Run each tool using the RunTool function
    foreach(ICogTool tool in mToolBlock.Tools)
      mToolBlock.RunTool(tool, ref message, ref result);
    
    //遍历斑点工具的结果
    for(int i = 0;i < blob1.Results.GetBlobs().Count;i++)
    {
      //修改卡尺工具的位置 为 斑点结果的中心位置
      cali1.Region.CenterX = blob1.Results.GetBlobs()[i].CenterOfMassX;
      cali1.Region.CenterY = blob1.Results.GetBlobs()[i].CenterOfMassY;
      //运行
      cali1.Run();
      //判断卡尺工具的结果数量
      if(cali1.Results.Count > 0)
      {
        //说明是合格产品
        CogGraphicLabel label1 = new CogGraphicLabel();
        label1.SetXYText(cali1.Region.CenterX, cali1.Region.CenterY, "OK");
        label1.Color = CogColorConstants.Green;
        label1.Font = new Font("宋体", 20);
        col.Add(label1);
      }
      else
      {
        //是不合格产品
        CogGraphicLabel label1 = new CogGraphicLabel();
        label1.SetXYText(cali1.Region.CenterX, cali1.Region.CenterY, "NG");
        label1.Color = CogColorConstants.Red;
        label1.Font = new Font("宋体", 20);
        col.Add(label1);
      }
    }

    return false;
  }

  #region When the Current Run Record is Created
  /// <summary>
  /// Called when the current record may have changed and is being reconstructed
  /// </summary>
  /// <param name="currentRecord">
  /// The new currentRecord is available to be initialized or customized.</param>
  public override void ModifyCurrentRunRecord(Cognex.VisionPro.ICogRecord currentRecord)
  {
  }
  #endregion

  #region When the Last Run Record is Created
  /// <summary>
  /// Called when the last run record may have changed and is being reconstructed
  /// </summary>
  /// <param name="lastRecord">
  /// The new last run record is available to be initialized or customized.</param>
  public override void ModifyLastRunRecord(Cognex.VisionPro.ICogRecord lastRecord)
  {
    foreach(ICogGraphic g in col)
    {
      mToolBlock.AddGraphicToRunRecord(g, lastRecord, "CogBlobTool1.InputImage", "scrpit");
    }
  }
  #endregion

  #region When the Script is Initialized
  /// <summary>
  /// Perform any initialization required by your script here
  /// </summary>
  /// <param name="host">The host tool</param>
  public override void Initialize(Cognex.VisionPro.ToolGroup.CogToolGroup host)
  {
    // DO NOT REMOVE - Call the base class implementation first - DO NOT REMOVE
    base.Initialize(host);


    // Store a local copy of the script host
    this.mToolBlock = ((Cognex.VisionPro.ToolBlock.CogToolBlock)(host));
  }
  #endregion

}


