using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class clsValidator
{
 public static int CheckInteger(string pEntry)
 {
  int intReturn;
  try { intReturn = int.Parse(pEntry); }
  catch { intReturn = 0; }
  return intReturn;
 }

 public static float CheckFloat(string pEntry)
 {
  float fltReturn;
  if (Convert.IsDBNull(pEntry) || pEntry == "")
   fltReturn = 0;
  else
   fltReturn = float.Parse(pEntry);
  return fltReturn;
 }

 public static double CheckDouble(string pEntry)
 {
  double dblReturn;
  if (Convert.IsDBNull(pEntry) || pEntry == "")
   dblReturn = 0;
  else
   dblReturn = Convert.ToDouble(pEntry);
  return dblReturn;
 }

 public static double CheckDouble(float pEntry)
 {
  double dblReturn;
  if (Convert.IsDBNull(pEntry))
   dblReturn = 0;
  else
   dblReturn = Convert.ToDouble(pEntry);
  return dblReturn;
 }

 public static DateTime CheckDate(string pDateTime)
 {
  if (Convert.IsDBNull(pDateTime) || pDateTime == "")
   return clsDateTime.SystemMinDate;
  else
   return Convert.ToDateTime(pDateTime);
 }

 public static string CheckDateString(string pDateTime)
 {
  if (Convert.IsDBNull(pDateTime) || pDateTime == "")
   return "";
  else
   return DateTime.Parse(pDateTime).ToString("MMMM dd, yyyy");
 }

 public static string CheckDateString(string pDateTime, string pFormat)
 {
  if (Convert.IsDBNull(pDateTime) || pDateTime == "")
   return "";
  else
   return DateTime.Parse(pDateTime).ToString(pFormat);
 }

 public static string CheckTimeString(string pDateTime)
 {
  if (Convert.IsDBNull(pDateTime) || pDateTime == "")
   return "";
  else
   return DateTime.Parse(pDateTime).ToString("hh:mm tt");
 }

 public static string ZeroToDash(int pEntry)
 {
  if (pEntry == 0)
   return "-";
  else
   return pEntry.ToString("#,###,###");
 }

 public static string ZeroToDash(double pEntry)
 {
  if (pEntry == 0)
   return "-";
  else
   return Math.Round(pEntry, 2).ToString("#,###,###");
 }

 public static string ZeroToDash(float pEntry)
 {
  if (pEntry == 0)
   return "-";
  else
   return Math.Round(pEntry, 2).ToString("#,###,###");
 }

 public static string CheckMinDate(DateTime pDate)
 {
  if (pDate == clsDateTime.SystemMinDate)
   return "";
  else
   return pDate.ToString("MMMM dd, yyyy");
 }

 public static string CheckMinDateTime(DateTime pDateTime)
 {
  if (pDateTime == clsDateTime.SystemMinDate)
   return "";
  else
   return pDateTime.ToString("MMMM dd, yyyy hh:mm tt");
 }

 public static string ToYesNo(string pYesNoNum)
 {
  return (pYesNoNum == "0" ? "No" : "Yes");
 }

 public static string ToYesNoNum(string pYesNoNum)
 {
  return (pYesNoNum == "Yes" ? "1" : "0");
 }

}
