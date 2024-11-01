/// <summary>
/// 通过Bitmap保存原图
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button2_Click(object sender, EventArgs e)
{
    //文件夹路径
    string savePath = Directory.GetCurrentDirectory() + "\\bitmap" + DateTime.Now.ToString("yyyy-MM-dd") + "\\";
    //图片完整路径
    string fileName = savePath + "\\2.bmp";


    //判断文件夹是否存在
    if (!Directory.Exists(savePath))
    {
        //如果不存在，创建这个文件夹
        Directory.CreateDirectory(savePath);
    }

    //将当前选中的图片转换为bmp
    Bitmap bmp = new Bitmap(listBox1.SelectedItem.ToString());
    //保存图片
    bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
}

/// <summary>
/// 使用img文件工具保存原图
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button3_Click(object sender, EventArgs e)
{
    //文件夹路径
    string savePath = Directory.GetCurrentDirectory() + "\\imgFileTool" + DateTime.Now.ToString("yyyy-MM-dd") + "\\";
    //图片完整路径
    string fileName = savePath + "\\1.bmp";


    //判断文件夹是否存在
    if (!Directory.Exists(savePath))
    {
        //如果不存在，创建这个文件夹
        Directory.CreateDirectory(savePath);
    }



    //创建工具
    CogImageFileTool fileTool = new CogImageFileTool();
    //输入图片
    //如果是相机拍照 把image换成拍照结果
    fileTool.InputImage = image;
    //写入图片
    fileTool.Operator.Open(fileName, CogImageFileModeConstants.Write);
    //运行
    fileTool.Run();
}

/// <summary>
/// 保存显示的图片
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void button4_Click(object sender, EventArgs e)
{
    //文件夹路径
    string savePath = Directory.GetCurrentDirectory() + "\\result" + DateTime.Now.ToString("yyyy-MM-dd") + "\\";
    //图片完整路径
    string fileName = savePath + "\\1.bmp";


    //判断文件夹是否存在
    if (!Directory.Exists(savePath))
    {
        //如果不存在，创建这个文件夹
        Directory.CreateDirectory(savePath);
    }

    //显示的图片转换为Bitmap
    Bitmap bitmap = cogRecordDisplay1.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image) as Bitmap;
    //保存图片
    bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
}