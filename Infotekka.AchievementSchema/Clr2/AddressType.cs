namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0#org.1edtech.clr.v2p0.address.class
    /// </summary>
    public class AddressType
    {
        public string[] TypeName { get; set; } = new[] { "Address" };

        public string AddressCountry { get; set; }

        /// <summary>
        /// 2 digit country code
        /// </summary>
        public string AddressCountryCode { get; set; }

        public string AddressRegion { get; set; }

        public string AddressLocality { get; set; }

        public string SreetAddress { get; set; }

        public string PostOfficeBoxNumber { get; set; }

        public string PostalCode { get; set; }
    }
}
