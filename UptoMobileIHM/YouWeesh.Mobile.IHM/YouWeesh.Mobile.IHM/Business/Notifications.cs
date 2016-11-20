using System;
namespace YouWeesh.Mobile
{
	public class Notifications
	{
		private String message;
		private String relatedObject;
		private String type;
		// juste pour la maquette
		private String profilePicture;
		private String actionPicture;

		public Notifications()
		{
		}

		#region ACCESSEURS
		public string Message
		{
			get
			{
				return message;
			}

			set
			{
				message = value;
			}
		}

		public string RelatedObject
		{
			get
			{
				return relatedObject;
			}

			set
			{
				relatedObject = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}

			set
			{
				type = value;
			}
		}

		public string ProfilePicture
		{
			get
			{
				return profilePicture;
			}

			set
			{
				profilePicture = value;
			}
		}

		public string ActionPicture
		{
			get
			{
				return actionPicture;
			}

			set
			{
				actionPicture = value;
			}
		}
		#endregion
	}
}
