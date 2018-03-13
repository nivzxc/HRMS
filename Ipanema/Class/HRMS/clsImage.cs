using System;
using System.Text;
using System.IO;
using System.Drawing;

public static class clsImage
{

 public static Image GetImage(object pImage)
 {
  Image imgReturn;
  byte[] bytImage;
  try
  {
   bytImage = (byte[])pImage;
  }
  catch
  {
   bytImage = ReadFile(System.Windows.Forms.Application.StartupPath + @"\Support\default.jpg");
  }

  using (MemoryStream ms = new MemoryStream(bytImage, 0, bytImage.Length))
  {
   ms.Write(bytImage, 0, bytImage.Length);
   imgReturn = Image.FromStream(ms, true);
  }
  return imgReturn;
 }

 public static byte[] ReadFile(string pPath)
 {
  //Initialize byte array with a null value initially.
  byte[] data = null;

  //Use FileInfo object to get file size.
  FileInfo fInfo = new FileInfo(pPath);
  long numBytes = fInfo.Length;

  //Open FileStream to read file
  FileStream fStream = new FileStream(pPath, FileMode.Open, FileAccess.Read);

  //Use BinaryReader to read file stream into byte array.
  BinaryReader br = new BinaryReader(fStream);

  //When you use BinaryReader, you need to supply number of bytes to read from file.
  //In this case we want to read entire file. So supplying total number of bytes.
  data = br.ReadBytes((int)numBytes);
  return data;
 }

}
