using EmpManagement.Enity;
using System;
using System.Data.SqlClient;

namespace EmpManagement
{
    public class Utils
    {
        public static String NO_OPTION = "--No Option--";
        public static String ID_EMPLOYEE_DEFAULT = "ID";

        /*
            Connection to SQL Server
         */
        public static SqlConnection connectionSqlServer = new SqlConnection(@"Data Source=LAPTOP-6E8C1ESV\SQLEXPRESS;Initial Catalog=MyEmployeeDb;Integrated Security=True");

        public static String getQueryInsertEmp(String code, String name, String address, String position,
            String gender, String date_of_birth, String phone, String education)
        {
            return "insert into Employee (code, name, address, position, gender, date_of_birth, phone, education, create_by) " +
                "values ('" + code + "','" + name + "','" + address + "','" + position + "','" + gender + "','" +
                date_of_birth + "','" + phone + "','" + education + "','" + Session.sessionUsername + "')";
        }

        public static String getQueryUpdateEmpById(String id, String code, String name, String address, String position,
            String gender, String date_of_birth, String phone, String education)
        {
            return "update Employee set code = '" + code + "', name = '" + name + "', address = '" + address +
                "', position = '" + position + "', gender = '" + gender + "', date_of_birth = '" + date_of_birth +
                "', phone = '" + phone + "', education = '" + education + "' where id = " + id;
        }

        public static String getQueryGetAllEmp()
        {
            return "select ROW_NUMBER() OVER(ORDER BY id ASC) AS 'Order Number' ,id as 'Id', code as 'Code', name as 'Full Name', address as 'Address'" +
                ", position as 'Position', gender as 'Gender', date_of_birth as 'Date Of Birth', phone as 'Phone'" +
                ", education as 'Education' from Employee where active != 0 and create_by = '" + Session.sessionUsername + "'";
        }


        public static String getQueryInactiveEmp(String id)
        {
            return "update Employee set active = 0 where id = " + id;
        }

        public static String getQueryCheckExistCodeEmp(String code, String id)
        {
            return "select count(*) from Employee where code = '" + code + "' and active != 0 and id != '" + id +"' and create_by = '" + Session.sessionUsername + "'";
        }

        public static String getQuerySearchEmp(String code, String name, String address, String position, String gender)
        {
            String query = "select ROW_NUMBER() OVER(ORDER BY id ASC) AS 'Order Number' ,id as 'Id', code as 'Code', name as 'Full Name', address as 'Address'" +
                ", position as 'Position', gender as 'Gender', date_of_birth as 'Date Of Birth', phone as 'Phone'" +
                ", education as 'Education' from Employee where active != 0 and create_by = '" + Session.sessionUsername + "'";
            if (code != "")
            {
                query += " and code like '%" + code + "%'";
            }
            if (name != "")
            {
                query += " and name like '%" + name + "%'";
            }
            if (address != "")
            {
                query += " and address like '%" + address + "%'";
            }
            if (position != "")
            {
                query += " and position like '" + position + "'";
            }
            if (gender != "")
            {
                query += " and gender like '" + gender + "'";
            }
            return query;
        }

        public static String getQueryCheckExistUsernameAccount(String username)
        {
            return "select count(*) from Account where username = '" + username + "'"; 
        }

        public static String getQueryInsertAccount(String username, String password)
        {
            return "insert into Account (username, password) values ('" + username + "', '" + password + "')";
        }


        public static String getQueryAccountByUsername(String username)
        {
            return "select * from Account where username = '"  + username + "'";
        }

        public static String getQueryPasswordByCurrentUser()
        {
            return "select * from Account where username = '" + Session.sessionUsername + "'";
        }

        public static String getQueryUpdatePasswordByCurrentUser(String newPassword)
        {
            return "update Account set password = '" + newPassword + "' where username = '" + Session.sessionUsername + "'";
        }
    }
}
