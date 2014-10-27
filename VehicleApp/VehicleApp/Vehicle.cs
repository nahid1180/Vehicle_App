using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        
        private string name;
        private string regNo;
        private double speed;

        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

       public double min = 0;
        public double GetMinSpeed()
         {
            // double min = 0;
            
            if (min==0)
            {
                min =speed ;
            }
            else if(min>=speed)
            {
                min = speed;
            }
           
            return min;
        }
        double max = 0;
        public double GetMaxSpeed()
        {
            
            if (speed > max)
            {
                max = speed;
            }

            return max;

        }
        double total = 0;
        double count = 0;
        public double GetAverage()
        {
            //double temporarySpeed = speed;
            count++;
             total+= speed;
            return total/count;
        }

    }
}
