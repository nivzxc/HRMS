using System;

namespace HRMS
{
 public static class clsMessageBox
 {

  public static string MessageBoxText
  { get { return "HRMS System"; } }

  public static string MessageBoxValidationError
  { get { return "The system cannot save your entry.\nPlease correct the following validation error(s):\n\n"; } }

  public static string MessageBoxErrorAdd
  { get { return "An error occured while adding your data.\n\nPlease contact your system administrator."; } }

  public static string MessageBoxErrorUpdate
  { get { return "An error occured while editing your data.\n\nPlease contact your system administrator."; } }

  public static string MessageBoxSuccessAddAskNew
  { get { return "Your data was successfully added.\n\nWould you like to add new record?"; } }

  public static string MessageBoxDeleteAsk
  { get { return "Are you sure to delete this record?"; } }

  public static string MessageBoxUpdateAsk
  { get { return "Are you sure to overwrite this record?"; } }

  public static string MessageBoxInternalError
  { get { return "An internal system error has occured.\n\nPlease contact your system administrator."; } }

 }
}