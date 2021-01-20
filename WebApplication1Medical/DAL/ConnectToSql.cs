using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObjectBloodTest.ObjectBloodTest;

namespace DAL
{
    public class ConnectToSql
    {
        public List<P_getTable_Result> ReadDataFromTheTableDAL()
        {
            var context = new MedicalEntities();
            List<P_getTable_Result> list = context.P_getTable().Select(e => e).ToList();
            context.SaveChanges();
            return list;
        }

        public void SendDataToSQL(ObjectCalculate Value)
        {
            var context = new MedicalEntities();
            context.insertData(Value.Platelet, Value.Albumin);
            context.SaveChanges();
        }

    }
}
