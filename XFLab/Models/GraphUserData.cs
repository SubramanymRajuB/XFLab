using System;
using System.Runtime.Serialization;

namespace XFLab.Models
{
    [DataContract]
    public class GraphUserData
    {
        string _displayName;
        [DataMember(Name = "displayName")]
        public string DisplayName
        {
            get => FormatUserName(_displayName);
            set
            {
                _displayName = value;
            }
        }

        [DataMember(Name = "givenName")]
        public string GivenName { get; set; }

        [DataMember(Name = "onPremisesSamAccountName")]
        public string OnPremisesSamAccountName { get; set; }

        [DataMember(Name = "employeeId")]
        public string EmployeeID { get; set; }

        [DataMember(Name = "mail")]
        public string Email { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        // Format Display Name ex: FirstName LastName
        public string FormatUserName(string userName)
        {
            string name = userName;
            if (userName.Contains(","))
            {
                string[] names = userName.Split(',');

                name = $"{names[1].Trim()} {names[0].Trim()}";
            }
            return name;
        }
    }
}
