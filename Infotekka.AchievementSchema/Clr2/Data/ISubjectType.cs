namespace Infotekka.AchievementSchema.Clr2.Data
{
    public interface ISubjectType
    {
        string ID { get; set; }

        string[] TypeName { get; set; }

        IdentityObjectType[] Identifier { get; set; }

        AchievementType Achievement { get; set; }
    }
}
