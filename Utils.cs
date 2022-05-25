using System;

namespace EmpManagement
{
    public class Utils
    {
        public static String NO_OPTION = "--No Option--";

        public static String getQueryInsertEmp(String code, String name, String address, String position,
            String gender, String date_of_birth, String phone, String education)
        {
            return "insert into Employee (code, name, address, position, gender, date_of_birth, phone, education) " +
                "values ('" + code + "','" + name + "','" + address + "','" + position + "','" + gender + "','" + 
                date_of_birth + "','" + phone + "','" + education + "')";
        }

        public static String getQueryGetAllEmp()
        {
            return "select id as 'Id', code as 'Code', name as 'Full Name', address as 'Address'" +
                ", position as 'Position', gender as 'Gender', date_of_birth as 'Date Of Birth', phone as 'Phone'" +
                ", education as 'Education' from Employee where active != 0";
        }


        public static String getQueryInactiveEmp(String code)
        {
            return "update Employee set active = 0 where code = " + code;
        }
    }
}
