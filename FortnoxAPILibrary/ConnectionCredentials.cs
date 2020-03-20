﻿using System.Net;

namespace FortnoxAPILibrary
{
	/// <remarks/>
	public static class ConnectionCredentials
	{
		/// <remarks/>
		public static string AccessToken { get; set; }

		/// <remarks/>
		public static string ClientSecret { get; set; }

        /// <remarks/>
        // ReSharper disable once InconsistentNaming
        public static string FortnoxAPIServer = "https://api.fortnox.se/3";

        /// <summary>
        /// Security protocol to be used in connection
        /// </summary>
        public static SecurityProtocolType SecurityProtocol = ServicePointManager.SecurityProtocol;
	}
}
