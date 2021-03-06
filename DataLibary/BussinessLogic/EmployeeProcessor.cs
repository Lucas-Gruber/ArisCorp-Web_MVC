using DataLibary.DataAccess;
using DataLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibary.BussinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int Id, int employeeId, string member_name, string bio_title, string bio_content, string member_picture)
        {
            EmployeeModel data = new EmployeeModel
            {
                Id = Id,
                EmployeeID = employeeId,
                Member_Name = member_name,
                Bio_Title = bio_title,
                Bio_Content = bio_content,
                Member_Picture = member_picture
            };

            string sql = @"insert into dbo.Employee (Id, EmployeeID, Member_Name, Bio_Title, Bio_Content, Member_Picture
                            values (@Id, @EmployeeID, @Member_Name, @Bio_Title, @Bio_Content, @Member_Picture);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, Member_Name, Bio_Title, Bio_Content, Member_Picture
                           from dbo.Employees;";


            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
