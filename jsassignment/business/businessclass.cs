using datalayer;
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class businessclass

    {
        DataAccess data = new DataAccess();
        public void AddDemo(demoentity d)
        {
            data.AddDemo(d);
        }
    }
}
