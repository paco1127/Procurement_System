using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal static class Stat_Employee
    {
        private static string _id;
        private static string _nickname;
        private static string _email;
        private static string _restaurantid;
        private static string _DeptID;
        private static int _brID;
        private static string _userpic;

        
        public static string Id { 
            get { return _id; }
            set { _id = value; }
        }

        public static string Name
        {
            get { return _nickname; }
            set { _nickname = value; }
        }

        public static string Email
        { 
            get { return _email; }
            set { _email = value; }
        }
        public static string Restaurantid
        {
            get { return _restaurantid; }
            set { _restaurantid = value; }
        }
        public static string DeptID
        {
            get { return _DeptID; }
            set { _DeptID = value; }
        }
        public static int BrID
        {
            get { return _brID; }
            set { _brID = value; }
        }

        public static string Userpic
        { 
            get { return _userpic; }
            set { _userpic = value; }
        }

    }
}
