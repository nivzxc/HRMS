using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

public enum pDateFormat { Year, Month, Day, Hour, Minute, Second }

public static class clsDateTime
{

 public static DateTime GetDateOnly(DateTime pDateTime)
 {
  return new DateTime(pDateTime.Year, pDateTime.Month, pDateTime.Day, 0, 0, 0);
 }

 public static DateTime SystemMinDate
 {
  get
  {
   return SqlDateTime.MinValue.Value;
  }
 }

 public static string TimeToDash(DateTime pTime)
 {
  if (Convert.IsDBNull(pTime) || pTime == clsDateTime.SystemMinDate)
   return "--:--";
  else
   return pTime.ToString("hh:mm:ss tt");
 }

 public static string DateTimeToDash(DateTime pDateTime)
 {
  if (Convert.IsDBNull(pDateTime) || pDateTime == clsDateTime.SystemMinDate)
   return "--:--";
  else
   return pDateTime.ToString("MMM dd, yyyy hh:mm:ss tt");
 }

 public static string DateTimeToDash(DateTime pDateTime,string pFormat)
 {
  if (Convert.IsDBNull(pDateTime) || pDateTime == clsDateTime.SystemMinDate)
   return "--:--";
  else
   return pDateTime.ToString(pFormat);
 }

 public static float DateDiff(pDateFormat pDateFormat, DateTime pDateTime1, DateTime pDateTime2)
 {
  float fltReturn = 0;
  float fltDays = (float)(pDateTime2 - pDateTime1).Days;
  float fltHours = (float)(pDateTime2 - pDateTime1).Hours;
  float fltMinutes = (float)(pDateTime2 - pDateTime1).Minutes;
  if (pDateFormat == pDateFormat.Hour)
  {
   fltMinutes = fltMinutes / 60;
   fltDays = fltDays * 24;
   fltReturn = (float)Math.Round(fltDays + fltHours + fltMinutes, 2);
  }
  else if(pDateFormat == pDateFormat.Minute)
  {
   fltReturn = fltMinutes;
  }
  return fltReturn;
 }

    // ADDED by calvin cavite DATE: 4/10/2018
    // USE FOR OVERTIME SUMMERY REPORT
 public static float convert_min(string units)
 {
        float fltReturn = 0;
        float hrs = (float)(Math.Truncate(float.Parse(units)));
        float mins =0;
        float actual_time = 0;

        mins = float.Parse(units) - (hrs);
        mins = (mins * 60)/100 ;
        actual_time = hrs + mins;
        fltReturn = (float)Math.Round(actual_time,2);

        return fltReturn;
 }
 public static DateTime CombineDateTime(DateTime pDate, DateTime pTime)
 {
  return new DateTime(pDate.Year, pDate.Month, pDate.Day, pTime.Hour, pTime.Minute, pTime.Second);
 }

 public static DateTime CombineDateTime(DateTime pDate, string pTime)
 {
  DateTime dteDate = clsValidator.CheckDate(pDate.ToString("MM/dd/yyyy") + " " + pTime);
  return new DateTime(dteDate.Year, dteDate.Month, dteDate.Day, dteDate.Hour, dteDate.Minute, dteDate.Second);
 }

 public static DateTime ChangeTimeToStart(DateTime pDate)
 {
  return new DateTime(pDate.Year, pDate.Month, pDate.Day, 0, 0, 0);
 }

 public static DateTime ChangeTimeToEnd(DateTime pDate)
 {
  return new DateTime(pDate.Year, pDate.Month, pDate.Day, 23, 59, 59);
 }

 public static DateTime RemoveSeconds(DateTime pDateTime)
 {
  return new DateTime(pDateTime.Year, pDateTime.Month, pDateTime.Day, pDateTime.Hour, pDateTime.Minute, 0);
 }

}