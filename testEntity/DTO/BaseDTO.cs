using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using entityConverter.CustomAttribute;

namespace entityConverter.testEntity.DTO
{
    public class BaseDTO<T> where T : new()
    {
        public T getModel()
        {
            Type[] signature = new List<Type>().ToArray();
            object[] arg = new List<object>().ToArray();
            T convertedType = (T)typeof(T).GetConstructor(signature).Invoke(arg);

            foreach (PropertyInfo prop in GetType().GetProperties())
            {
                var attrs = prop.GetCustomAttributes(true).ToList();
                typeof(T).GetProperty(((ProperyEntityAttribute)attrs[0]).Name).SetValue(convertedType, prop.GetValue(this));
            }

            return convertedType;
        }
    }
}
