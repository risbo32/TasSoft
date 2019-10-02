using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTas.data
{
    public class MyDataComponent : Component
    {
        private imsdbDataSetTableAdapters.departmentTableAdapter departmentTableAdapter1;

        public imsdbDataSet.departmentDataTable departments = new imsdbDataSet.departmentDataTable();
        private void InitializeComponent()
        {
            this.departmentTableAdapter1 = new SoftwareTas.imsdbDataSetTableAdapters.departmentTableAdapter();
            // 
            // departmentTableAdapter1
            // 
            this.departmentTableAdapter1.ClearBeforeFill = true;
            this.departmentTableAdapter1.Fill(departments);
        }


        public Departement GetDepartementFromDatabase()
        {
            imsdbDataSet.departmentRow row = departments.Where(x => x.masterid == 0).First();
            Departement rootDept = null;

          

            if (row != null)
            {
            rootDept = new Departement
                {
                Name= row.deptname
                };
            }

            foreach (imsdbDataSet.departmentRow dptRow in departments.Rows)
            {
                
            }

            return rootDept;
        }
    }
}
