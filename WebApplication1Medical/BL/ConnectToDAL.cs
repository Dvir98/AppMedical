using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectBloodTest.ObjectBloodTest;

namespace BL
{
    public class ConnectToDAL
    {
        ConnectToSql ConnectDAL = new ConnectToSql();
        public List<P_getTable_Result> getMedicalsFromBL()
        {
            return ConnectDAL.ReadDataFromTheTableDAL();
        }

        public double Calculate(ObjectCalculate Value)
        {
            ConnectDAL.SendDataToSQL(Value);
            switch (Value.symbol)
            {
                case "+":
                    return Value.Platelet + Value.Albumin;
                case "-":
                    return Value.Platelet - Value.Albumin;
                case "/":
                    return Value.Platelet / Value.Albumin;
                case "*":
                    return Value.Platelet * Value.Albumin;

            }
            return 0;
        }
    }
}
