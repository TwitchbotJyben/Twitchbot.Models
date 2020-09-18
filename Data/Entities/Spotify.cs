using System;
using System.Collections.Generic;
using Twitchbot.Models.Definitions;

namespace Twitchbot.Models.Data.Entities
{
    public partial class Spotify : IHaveIdentifier
    {
        public Spotify()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Token { get; set; }

        public string RefreshToken { get; set; }

        public int UserId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Users Users { get; set; }

        #endregion

    }
}