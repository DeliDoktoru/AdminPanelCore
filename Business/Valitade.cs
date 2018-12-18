using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AdminPanelCore.Business
{
    public static class Validate
    {
        
        
        public static bool CheckEmptyData(Object a) {
            PropertyInfo[] properties = a.GetType().GetProperties();
            foreach (var x in properties)
            {
                if (x.GetValue(a)==null || x.GetValue(a).ToString() == "")
                {
                    return false;
                        
                }
            }
            return true;

        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                
                return new EmailAddressAttribute().IsValid(email);
            }
            catch
            {
                return false;
            }
        }
        public static bool checkUniqEmail(string email)
        {
            try
            {

                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool equalPassCheck(string pass,string pass1)
        {
            
            if(pass==pass1)
                return true;
            else
                return false;
            
        }
        



    }
}
