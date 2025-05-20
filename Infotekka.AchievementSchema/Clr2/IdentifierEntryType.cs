using System;
using System.Collections.Generic;
using System.Text;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0#org.1edtech.clr.v2p0.identifierentry.class
    /// </summary>
    public class IdentifierEntryType
    {
        public string TypeName { get; } = "IdentifierEntry";

        public string Identifier { get; set; }

        /// <summary>
        /// <see cref="IdentityObjectType.IdentifierTypes"/>
        /// </summary>
        public string IdentifierType { get; set; }
    }
}
