#region namespace imports
using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro3D;
using Cognex.VisionPro.ColorMatch;
#endregion

public class CogToolBlockAdvancedScript : CogToolBlockAdvancedScriptBase
{
  #region Private Member Variables
  private Cognex.VisionPro.ToolBlock.CogToolBlock mToolBlock;
  private CogGraphicLabel label1 = new CogGraphicLabel();
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

    //拿到工具
    CogColorMatchTool match1 = mToolBlock.Tools["CogColorMatchTool1"] as CogColorMatchTool;
    CogColorMatchTool match2 = mToolBlock.Tools["CogColorMatchTool2"] as CogColorMatchTool;
    CogColorMatchTool match3 = mToolBlock.Tools["CogColorMatchTool3"] as CogColorMatchTool;
    CogColorMatchTool match4 = mToolBlock.Tools["CogColorMatchTool4"] as CogColorMatchTool;
    CogColorMatchTool match5 = mToolBlock.Tools["CogColorMatchTool5"] as CogColorMatchTool;
    CogColorMatchTool match6 = mToolBlock.Tools["CogColorMatchTool6"] as CogColorMatchTool;
    CogColorMatchTool match7 = mToolBlock.Tools["CogColorMatchTool7"] as CogColorMatchTool;

    // Run each tool using the RunTool function
    foreach(ICogTool tool in mToolBlock.Tools)
      mToolBlock.RunTool(tool, ref message, ref result);
    
    string match1ColorName = getColorName(match1.Result.ResultOfBestMatch.Color.Name);
    string match2ColorName = getColorName(match2.Result.ResultOfBestMatch.Color.Name);
    string match3ColorName = getColorName(match3.Result.ResultOfBestMatch.Color.Name);
    string match4ColorName = getColorName(match4.Result.ResultOfBestMatch.Color.Name);
    string match5ColorName = getColorName(match5.Result.ResultOfBestMatch.Color.Name);
    string match6ColorName = getColorName(match6.Result.ResultOfBestMatch.Color.Name);
    string match7ColorName = getColorName(match7.Result.ResultOfBestMatch.Color.Name);
    
    
    label1.SetXYText(800, 100,"线序颜色:"+match1ColorName+ match2ColorName + match3ColorName + match4ColorName + match5ColorName + match6ColorName + match7ColorName);

    return false;
  }
  
  private string getColorName(string enColorName)
  {
    
    //获取最匹配的颜色的名字
    switch(enColorName)
    {
      case "black":
        return "黑色";
      case "red":
        return "红色";
      case "blue":
        return "蓝色";
      case "green":
        return "绿色";
      case "yellow":
        return "黄色";
      case "white":
        return "白色";
      case "null":
        return "没有";
    }
    return "";
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
    mToolBlock.AddGraphicToRunRecord(label1, lastRecord, "CogColorMatchTool1.InputImage", "script");
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


