using System;
using System.Data;
using System.Linq;
using NQuery;

namespace Northwind
{
    public class NorthwindDb
    {
        public static string GetData()
        {
            var result = "";
            var dataSet = new DataSet();
            dataSet.ReadXml(@"C:\demos\northwind.xml");

            var dataContext = new DataContext();
            dataContext.AddTablesAndRelations(dataSet);

            var sql = @"
                SELECT  e.FirstName + ' ' + e.LastName
                FROM    Employees e
                WHERE   e.Birthdate.AddYears(65) < GETDATE()
            ";

            var query = new Query(sql, dataContext);
            var results = query.ExecuteDataTable();
            var values = results.Rows.Cast<DataRow>().Select(r => (string)r[0]);
            result = string.Join(Environment.NewLine, values);

            return result;
        }
    }
}
