using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDepartment.Models;

namespace HRDepartment.HelperVio
{
    public class StatusEnumConvert
    {
        public static string GetEnumerator(StatusEnum value)
        {
            return Enum.GetName(typeof(StatusEnum), value);
        }
    }
}
