using BileApi.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BileApi.Extensions
{
    public static class DataExtension
    {
        public static string HappyDate(this DateTime dateTime)
        {
            return "Your date is: " + dateTime.ToString();
        }


        public static List<SqlParameter> GetSqlParameters<T>(this T model) where T : BaseEntity
        {
            
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter
            {
                Value = "item.value",
                ParameterName = "item.PropertyName"
            });

            return parameters;

        }




    }
}
