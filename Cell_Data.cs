using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maptest
{
    class Cell_Data
    {
 
        private Boolean land;
        /// <summary>
        /// 陸の判定用(TRUE:陸,FALSE:海)。
        /// </summary>
        public Boolean Land
        {
            get { return land; }
            set { land = value; }

        }


        private string country;
        /// <summary>
        /// 国名
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }

        }


        private string city;
        /// <summary>
        /// 都市名
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }

        }
    }
}
