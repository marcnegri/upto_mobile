﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace YouWeesh.Mobile.Business
{
    public class Users
    {
        #region PROPERTIES
        private String firstName;
        private String lastName;
        private String username;
        private String picture;
		private String listTags; // a modifier juste declare pour la maquette
        #endregion

        #region ACCESSORS
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
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

		public string ListTags
		{
			get
			{
				return listTags;
			}

			set
			{
				listTags = value;
			}
		}
		#endregion

		public Users(){  }
    }
}
