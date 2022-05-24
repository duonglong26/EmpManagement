using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement
{
    public class Utils
    {
        public static String NO_OPTION = "--No Option--";

        public static String getQueryInsertEmp(String code, String name, String address, String position,
            String gender, String date_of_birth, String phone, String education)
        {
            return "insert into Employee (code, name, address, position, gender, date_of_birth, phone, education) values ('" +
                code + "','" + name + "','" + address + "','" + position + "','" + gender + "','" + 
                date_of_birth + "','" + phone + "','" + education + "')";
        }

    }
}
