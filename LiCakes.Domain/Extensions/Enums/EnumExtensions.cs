using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LiCakes.Domain.Extensions.Enums
{
  public static class EnumExtensions
  {
    public static string GetDescription(this Enum value)
    {
      Type genericEnumType = value.GetType();
      MemberInfo[] memberInfo = genericEnumType.GetMember(value.ToString());
      if (memberInfo != null && memberInfo.Length > 0)
      {
        var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
        if (attributes != null && attributes.Count() > 0)
        {
          return ((DescriptionAttribute)attributes.ElementAt(0)).Description;
        }
      }

      return value.ToString();
    }
  }
}
