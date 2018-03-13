using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRMS
{
 class clsShell
 {
  public static bool StartProcess(string pShell)
  {
   System.Diagnostics.Process.Start(pShell);
   return true;
  }
 }

}