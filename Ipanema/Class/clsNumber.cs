using System;

public static class clsNumber
{

 public static string FormatFloat(float pFloat)
 {
  if (pFloat == 0)
   return "-";
  else
   return pFloat.ToString("###,##0.00");
 }

}