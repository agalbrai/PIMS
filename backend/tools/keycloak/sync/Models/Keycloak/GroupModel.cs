using System;
using System.Collections.Generic;

namespace Pims.Tools.Keycloak.Sync.Models.Keycloak
{
    /// <summary>
    /// GroupModel class, provides a model to represent a keycloak group.
    /// </summary>
    public class GroupModel
    {
        #region Properties
        public Guid id { get; set; }

        public string name { get; set; }

        public string path { get; set; }

        public string description { get; set; }

        public bool composite { get; set; }

        public bool clientRole { get; set; }

        public string containerId { get; set; }

        public string[] realmRoles { get; set; }

        public Dictionary<string, string[]> clientRoles { get; set; }

        public string[] subGroups { get; set; }

        public Dictionary<string, string[]> attributes { get; set; }
        #endregion
    }
}