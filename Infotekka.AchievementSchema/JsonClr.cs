using Infotekka.AchievementSchema.Clr2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infotekka.AchievementSchema
{
    public static class JsonClr
    {
        public const string DateFormat = "yyyy-MM-ddTHH:mm:ss";

        #region Statics
        public static string SerializeCredential<T>(T CredentialObject, bool PrettyPrint = true) {
            var options = new JsonSerializerOptions() {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = PrettyPrint,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            return JsonSerializer.Serialize(CredentialObject, options);
        }

        public static T DeserializeCredential<T>(string JsonText) {
            var options = new JsonSerializerOptions() {
                PropertyNameCaseInsensitive = true
            };
            return JsonSerializer.Deserialize<T>(JsonText, options);
        }

        public static Clr2Type ConvertToVerifiableCredential(string JsonText) {
            var clr2 = DeserializeCredential<Clr2Type>(JsonText);
            var cs = clr2.CredentialSubject;
            clr2.CredentialSubject = new CredentialSubjectType() {
                Identifier = cs.Identifier,
                VerifiableCredential = new[] {
                    new AchievementCredentialType() {
                        Issuer = clr2.Issuer,
                        CredentialSubject = cs,
                        ID = Guid.NewGuid().ToString()
                    }
                }
            };

            return clr2;
        }

        public static Clr2Type ConvertToBadge(string JsonText) {
            var clr2 = DeserializeCredential<Clr2Type>(JsonText);
            var cs = clr2.CredentialSubject;
            return new Clr2Type() {
                CredentialSubject = clr2.CredentialSubject.VerifiableCredential[0].CredentialSubject
            };
        }
        #endregion
    }
}
