using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;

namespace FrameWork4
{
    public class ConexionLogin 
    {
        static ConexionLogin()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        internal static Tuple<int, string> validarLogin(string usuario, string password)
        {
            int res = 0;
            string sessID="";
            DbCommand comm = Database.CreateCommand("Portal_ValidateUsers");
            comm.Parameters.Add(Database.CreateParameter(comm, "@email", DbType.String, usuario));
            comm.Parameters.Add(Database.CreateParameter(comm, "@password", DbType.String, password));
            DataTable dt = Database.ExecuteSelectCommand(comm);
            if (dt.Rows.Count > 0)
            {
                res = (int)dt.Rows[0]["res"];
                sessID =dt.Rows[0]["sessionID"].ToString();
            }
            return Tuple.Create(res, sessID);
             
        }


    }
}
