using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouWeesh.Mobile.Business
{
    public class Events
    {
		#region PROPERTIES
		private int id;
        private String title;
        private String startDatetime;
        private String endDatetime;
        private String description;
        private List<Users> participants;
        private Users creator;
        private String location;
        private String picture;
        #endregion

        #region ACCESSORS

		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        public string StartDatetime
        {
            get
            {
                return startDatetime;
            }

            set
            {
                startDatetime = value;
            }
        }
        public string EndDatetime
        {
            get
            {
                return endDatetime;
            }

            set
            {
                endDatetime = value;
            }
        }
        public List<Users> Participants
        {
            get
            {
                return participants;
            }

            set
            {
                participants = value;
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
        public string Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }
        public Users Creator
        {
            get
            {
                return creator;
            }

            set
            {
                creator = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        #endregion
    }
}
