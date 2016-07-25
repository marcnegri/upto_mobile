using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouWeesh.Mobile.Business
{
    public class Element
    {
        #region PROPERTIES
        private String title;
        private String startDatetime;
        private String endDatetime;
        private String description;
        private List<Users> participants;
        private Users creator;
		private String creationDate;
        private String location;
        private String picture;
		private Boolean isEvent;
        #endregion

        #region ACCESSORS
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

		public string CreationDate
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

		public Boolean IsEvent
		{
			get
			{
				return isEvent;
			}

			set
			{
				isEvent = value;

			}
		}


		#endregion
	}
}
