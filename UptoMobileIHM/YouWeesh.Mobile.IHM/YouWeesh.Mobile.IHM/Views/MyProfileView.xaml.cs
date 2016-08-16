﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YouWeesh.Mobile
{
	public partial class MyProfileView : ContentPage
	{
		public MyProfileView()
		{
			InitializeComponent();
			this.BackgroundColor = Color.FromHex("#ececec");
			lblLocation.TextColor = Color.FromRgb(49, 159, 212);

			rltHeader.Children.Add(stkProfileImg, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (parent.Height * 0.1);
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height * 0.3;
			}));

			rltHeader.Children.Add(lblProfileName, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (parent.Height * 0.4);
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height;
			}));

			rltHeader.Children.Add(stkLocation, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (parent.Height * 0.55);
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 20;
			}));



		}
	}
}
