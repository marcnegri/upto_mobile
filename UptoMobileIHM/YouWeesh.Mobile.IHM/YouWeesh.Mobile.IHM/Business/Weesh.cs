using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouWeesh.Mobile.Business
{
    public class Weesh
    {
        public Weesh() { }

        public Weesh(string _label) {
            this.label = _label;
        }

        #region PROPERTIES
        private String label;
        private DateTime creationDate;
        private String location;
        #endregion

        #region ACCESSORS
        public string Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
            }
        }
        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }

            set
            {
                creationDate = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
        #endregion

        /// <summary>
        /// Return weeshBack count
        /// </summary>
        /// <returns>Integer</returns>
        public Int64 GetWeeshBack()
        {
            return 10;
        }
    }
}
