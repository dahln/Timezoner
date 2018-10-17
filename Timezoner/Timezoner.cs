using System;
using System.Collections.Generic;
using System.Linq;

namespace Timezoner
{
    public class Timezone
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Offset { get; set; }
    }


    /// <summary>
    /// Provides Windows Timezones, including a display name, offset, and Id.  
    /// </summary>
    public class Timezoner
    {
        /// <summary>
        /// Get all timezones
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Timezone> GetTimezones()
        {
            return _data;
        }

        /// <summary>
        /// Get Timezone by Timezone Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Timezone GetTimezoneById(string id)
        {
            return _data.FirstOrDefault(t => t.Id == id);
        }

        /// <summary>
        /// Get Timezone offset by Timezone Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TimeSpan GetOffsetAsTimeSpan(string id)
        {
            string offset = GetTimezoneById(id)?.Offset;
            if (offset != null)
                return TimeSpan.Parse(offset);
            else
                return default(TimeSpan);
        }

        /// <summary>
        /// Get Timezone offset by Timezone
        /// </summary>
        /// <param name="zone"></param>
        /// <returns></returns>
        public TimeSpan GetOffsetAsTimeSpan(Timezone zone)
        {
            string offset = zone?.Offset;
            if (offset != null)
                return TimeSpan.Parse(offset);
            else
                return default(TimeSpan);
        }

        #region data
        private List<Timezone> _data = new List<Timezone>()
        {
            new Timezone
            {
                Id = "Dateline Standard Time",
                Name = "(UTC-12:00) International Date Line West",
                Offset = "-12:00:00"
            },
            new Timezone
            {
                Id = "UTC-11",
                Name = "(UTC-11:00) Coordinated Universal Time-11",
                Offset = "-11:00:00"
            },
            new Timezone
            {
                Id = "Aleutian Standard Time",
                Name = "(UTC-10:00) Aleutian Islands",
                Offset = "-10:00:00"
            },
            new Timezone
            {
                Id = "Hawaiian Standard Time",
                Name = "(UTC-10:00) Hawaii",
                Offset = "-10:00:00"
            },
            new Timezone
            {
                Id = "Marquesas Standard Time",
                Name = "(UTC-09:30) Marquesas Islands",
                Offset = "-09:30:00"
            },
            new Timezone
            {
                Id = "Alaskan Standard Time",
                Name = "(UTC-09:00) Alaska",
                Offset = "-09:00:00"
            },
            new Timezone
            {
                Id = "UTC-09",
                Name = "(UTC-09:00) Coordinated Universal Time-09",
                Offset = "-09:00:00"
            },
            new Timezone
            {
                Id = "Pacific Standard Time (Mexico)",
                Name = "(UTC-08:00) Baja California",
                Offset = "-08:00:00"
            },
            new Timezone
            {
                Id = "UTC-08",
                Name = "(UTC-08:00) Coordinated Universal Time-08",
                Offset = "-08:00:00"
            },
            new Timezone
            {
                Id = "Pacific Standard Time",
                Name = "(UTC-08:00) Pacific Time (US & Canada)",
                Offset = "-08:00:00"
            },
            new Timezone
            {
                Id = "US Mountain Standard Time",
                Name = "(UTC-07:00) Arizona",
                Offset = "-07:00:00"
            },
            new Timezone
            {
                Id = "Mountain Standard Time (Mexico)",
                Name = "(UTC-07:00) Chihuahua, La Paz, Mazatlan",
                Offset = "-07:00:00"
            },
            new Timezone
            {
                Id = "Mountain Standard Time",
                Name = "(UTC-07:00) Mountain Time (US & Canada)",
                Offset = "-07:00:00"
            },
            new Timezone
            {
                Id = "Central America Standard Time",
                Name = "(UTC-06:00) Central America",
                Offset = "-06:00:00"
            },
            new Timezone
            {
                Id = "Central Standard Time",
                Name = "(UTC-06:00) Central Time (US & Canada)",
                Offset = "-06:00:00"
            },
            new Timezone
            {
                Id = "Easter Island Standard Time",
                Name = "(UTC-06:00) Easter Island",
                Offset = "-06:00:00"
            },
            new Timezone
            {
                Id = "Central Standard Time (Mexico)",
                Name = "(UTC-06:00) Guadalajara, Mexico City, Monterrey",
                Offset = "-06:00:00"
            },
            new Timezone
            {
                Id = "Canada Central Standard Time",
                Name = "(UTC-06:00) Saskatchewan",
                Offset = "-06:00:00"
            },
            new Timezone
            {
                Id = "SA Pacific Standard Time",
                Name = "(UTC-05:00) Bogota, Lima, Quito, Rio Branco",
                Offset = "-05:00:00"
            },
            new Timezone
            {
                Id = "Eastern Standard Time (Mexico)",
                Name = "(UTC-05:00) Chetumal",
                Offset = "-05:00:00"
            },
            new Timezone
            {
                Id = "Eastern Standard Time",
                Name = "(UTC-05:00) Eastern Time (US & Canada)",
                Offset = "-05:00:00"
            },
            new Timezone
            {
                Id = "Haiti Standard Time",
                Name = "(UTC-05:00) Haiti",
                Offset = "-05:00:00"
            },
            new Timezone
            {
                Id = "Cuba Standard Time",
                Name = "(UTC-05:00) Havana",
                Offset = "-05:00:00"
            },
            new Timezone
            {
                Id = "US Eastern Standard Time",
                Name = "(UTC-05:00) Indiana (East)",
                Offset = "-05:00:00"
            },
            new Timezone
            {
                Id = "Turks And Caicos Standard Time",
                Name = "(UTC-05:00) Turks and Caicos",
                Offset = "-05:00:00"
            },
            new Timezone
            {
                Id = "Paraguay Standard Time",
                Name = "(UTC-04:00) Asuncion",
                Offset = "-04:00:00"
            },
            new Timezone
            {
                Id = "Atlantic Standard Time",
                Name = "(UTC-04:00) Atlantic Time (Canada)",
                Offset = "-04:00:00"
            },
            new Timezone
            {
                Id = "Venezuela Standard Time",
                Name = "(UTC-04:00) Caracas",
                Offset = "-04:00:00"
            },
            new Timezone
            {
                Id = "Central Brazilian Standard Time",
                Name = "(UTC-04:00) Cuiaba",
                Offset = "-04:00:00"
            },
            new Timezone
            {
                Id = "SA Western Standard Time",
                Name = "(UTC-04:00) Georgetown, La Paz, Manaus, San Juan",
                Offset = "-04:00:00"
            },
            new Timezone
            {
                Id = "Pacific SA Standard Time",
                Name = "(UTC-04:00) Santiago",
                Offset = "-04:00:00"
            },
            new Timezone
            {
                Id = "Newfoundland Standard Time",
                Name = "(UTC-03:30) Newfoundland",
                Offset = "-03:30:00"
            },
            new Timezone
            {
                Id = "Tocantins Standard Time",
                Name = "(UTC-03:00) Araguaina",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "E. South America Standard Time",
                Name = "(UTC-03:00) Brasilia",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "SA Eastern Standard Time",
                Name = "(UTC-03:00) Cayenne, Fortaleza",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "Argentina Standard Time",
                Name = "(UTC-03:00) City of Buenos Aires",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "Greenland Standard Time",
                Name = "(UTC-03:00) Greenland",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "Montevideo Standard Time",
                Name = "(UTC-03:00) Montevideo",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "Magallanes Standard Time",
                Name = "(UTC-03:00) Punta Arenas",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "Saint Pierre Standard Time",
                Name = "(UTC-03:00) Saint Pierre and Miquelon",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "Bahia Standard Time",
                Name = "(UTC-03:00) Salvador",
                Offset = "-03:00:00"
            },
            new Timezone
            {
                Id = "UTC-02",
                Name = "(UTC-02:00) Coordinated Universal Time-02",
                Offset = "-02:00:00"
            },
            new Timezone
            {
                Id = "Mid-Atlantic Standard Time",
                Name = "(UTC-02:00) Mid-Atlantic - Old",
                Offset = "-02:00:00"
            },
            new Timezone
            {
                Id = "Azores Standard Time",
                Name = "(UTC-01:00) Azores",
                Offset = "-01:00:00"
            },
            new Timezone
            {
                Id = "Cape Verde Standard Time",
                Name = "(UTC-01:00) Cabo Verde Is.",
                Offset = "-01:00:00"
            },
            new Timezone
            {
                Id = "UTC",
                Name = "(UTC) Coordinated Universal Time",
                Offset = "00:00:00"
            },
            new Timezone
            {
                Id = "Morocco Standard Time",
                Name = "(UTC+00:00) Casablanca",
                Offset = "00:00:00"
            },
            new Timezone
            {
                Id = "GMT Standard Time",
                Name = "(UTC+00:00) Dublin, Edinburgh, Lisbon, London",
                Offset = "00:00:00"
            },
            new Timezone
            {
                Id = "Greenwich Standard Time",
                Name = "(UTC+00:00) Monrovia, Reykjavik",
                Offset = "00:00:00"
            },
            new Timezone
            {
                Id = "W. Europe Standard Time",
                Name = "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna",
                Offset = "01:00:00"
            },
            new Timezone
            {
                Id = "Central Europe Standard Time",
                Name = "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague",
                Offset = "01:00:00"
            },
            new Timezone
            {
                Id = "Romance Standard Time",
                Name = "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris",
                Offset = "01:00:00"
            },
            new Timezone
            {
                Id = "Sao Tome Standard Time",
                Name = "(UTC+01:00) Sao Tome",
                Offset = "01:00:00"
            },
            new Timezone
            {
                Id = "Central European Standard Time",
                Name = "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb",
                Offset = "01:00:00"
            },
            new Timezone
            {
                Id = "W. Central Africa Standard Time",
                Name = "(UTC+01:00) West Central Africa",
                Offset = "01:00:00"
            },
            new Timezone
            {
                Id = "Jordan Standard Time",
                Name = "(UTC+02:00) Amman",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "GTB Standard Time",
                Name = "(UTC+02:00) Athens, Bucharest",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Middle East Standard Time",
                Name = "(UTC+02:00) Beirut",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Egypt Standard Time",
                Name = "(UTC+02:00) Cairo",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "E. Europe Standard Time",
                Name = "(UTC+02:00) Chisinau",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Syria Standard Time",
                Name = "(UTC+02:00) Damascus",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "West Bank Standard Time",
                Name = "(UTC+02:00) Gaza, Hebron",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "South Africa Standard Time",
                Name = "(UTC+02:00) Harare, Pretoria",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "FLE Standard Time",
                Name = "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Israel Standard Time",
                Name = "(UTC+02:00) Jerusalem",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Kaliningrad Standard Time",
                Name = "(UTC+02:00) Kaliningrad",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Sudan Standard Time",
                Name = "(UTC+02:00) Khartoum",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Libya Standard Time",
                Name = "(UTC+02:00) Tripoli",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Namibia Standard Time",
                Name = "(UTC+02:00) Windhoek",
                Offset = "02:00:00"
            },
            new Timezone
            {
                Id = "Arabic Standard Time",
                Name = "(UTC+03:00) Baghdad",
                Offset = "03:00:00"
            },
            new Timezone
            {
                Id = "Turkey Standard Time",
                Name = "(UTC+03:00) Istanbul",
                Offset = "03:00:00"
            },
            new Timezone
            {
                Id = "Arab Standard Time",
                Name = "(UTC+03:00) Kuwait, Riyadh",
                Offset = "03:00:00"
            },
            new Timezone
            {
                Id = "Belarus Standard Time",
                Name = "(UTC+03:00) Minsk",
                Offset = "03:00:00"
            },
            new Timezone
            {
                Id = "Russian Standard Time",
                Name = "(UTC+03:00) Moscow, St. Petersburg, Volgograd",
                Offset = "03:00:00"
            },
            new Timezone
            {
                Id = "E. Africa Standard Time",
                Name = "(UTC+03:00) Nairobi",
                Offset = "03:00:00"
            },
            new Timezone
            {
                Id = "Iran Standard Time",
                Name = "(UTC+03:30) Tehran",
                Offset = "03:30:00"
            },
            new Timezone
            {
                Id = "Arabian Standard Time",
                Name = "(UTC+04:00) Abu Dhabi, Muscat",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Astrakhan Standard Time",
                Name = "(UTC+04:00) Astrakhan, Ulyanovsk",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Azerbaijan Standard Time",
                Name = "(UTC+04:00) Baku",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Russia Time Zone 3",
                Name = "(UTC+04:00) Izhevsk, Samara",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Mauritius Standard Time",
                Name = "(UTC+04:00) Port Louis",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Saratov Standard Time",
                Name = "(UTC+04:00) Saratov",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Georgian Standard Time",
                Name = "(UTC+04:00) Tbilisi",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Caucasus Standard Time",
                Name = "(UTC+04:00) Yerevan",
                Offset = "04:00:00"
            },
            new Timezone
            {
                Id = "Afghanistan Standard Time",
                Name = "(UTC+04:30) Kabul",
                Offset = "04:30:00"
            },
            new Timezone
            {
                Id = "West Asia Standard Time",
                Name = "(UTC+05:00) Ashgabat, Tashkent",
                Offset = "05:00:00"
            },
            new Timezone
            {
                Id = "Ekaterinburg Standard Time",
                Name = "(UTC+05:00) Ekaterinburg",
                Offset = "05:00:00"
            },
            new Timezone
            {
                Id = "Pakistan Standard Time",
                Name = "(UTC+05:00) Islamabad, Karachi",
                Offset = "05:00:00"
            },
            new Timezone
            {
                Id = "India Standard Time",
                Name = "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi",
                Offset = "05:30:00"
            },
            new Timezone
            {
                Id = "Sri Lanka Standard Time",
                Name = "(UTC+05:30) Sri Jayawardenepura",
                Offset = "05:30:00"
            },
            new Timezone
            {
                Id = "Nepal Standard Time",
                Name = "(UTC+05:45) Kathmandu",
                Offset = "05:45:00"
            },
            new Timezone
            {
                Id = "Central Asia Standard Time",
                Name = "(UTC+06:00) Astana",
                Offset = "06:00:00"
            },
            new Timezone
            {
                Id = "Bangladesh Standard Time",
                Name = "(UTC+06:00) Dhaka",
                Offset = "06:00:00"
            },
            new Timezone
            {
                Id = "Omsk Standard Time",
                Name = "(UTC+06:00) Omsk",
                Offset = "06:00:00"
            },
            new Timezone
            {
                Id = "Myanmar Standard Time",
                Name = "(UTC+06:30) Yangon (Rangoon)",
                Offset = "06:30:00"
            },
            new Timezone
            {
                Id = "SE Asia Standard Time",
                Name = "(UTC+07:00) Bangkok, Hanoi, Jakarta",
                Offset = "07:00:00"
            },
            new Timezone
            {
                Id = "Altai Standard Time",
                Name = "(UTC+07:00) Barnaul, Gorno-Altaysk",
                Offset = "07:00:00"
            },
            new Timezone
            {
                Id = "W. Mongolia Standard Time",
                Name = "(UTC+07:00) Hovd",
                Offset = "07:00:00"
            },
            new Timezone
            {
                Id = "North Asia Standard Time",
                Name = "(UTC+07:00) Krasnoyarsk",
                Offset = "07:00:00"
            },
            new Timezone
            {
                Id = "N. Central Asia Standard Time",
                Name = "(UTC+07:00) Novosibirsk",
                Offset = "07:00:00"
            },
            new Timezone
            {
                Id = "Tomsk Standard Time",
                Name = "(UTC+07:00) Tomsk",
                Offset = "07:00:00"
            },
            new Timezone
            {
                Id = "China Standard Time",
                Name = "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi",
                Offset = "08:00:00"
            },
            new Timezone
            {
                Id = "North Asia East Standard Time",
                Name = "(UTC+08:00) Irkutsk",
                Offset = "08:00:00"
            },
            new Timezone
            {
                Id = "Singapore Standard Time",
                Name = "(UTC+08:00) Kuala Lumpur, Singapore",
                Offset = "08:00:00"
            },
            new Timezone
            {
                Id = "W. Australia Standard Time",
                Name = "(UTC+08:00) Perth",
                Offset = "08:00:00"
            },
            new Timezone
            {
                Id = "Taipei Standard Time",
                Name = "(UTC+08:00) Taipei",
                Offset = "08:00:00"
            },
            new Timezone
            {
                Id = "Ulaanbaatar Standard Time",
                Name = "(UTC+08:00) Ulaanbaatar",
                Offset = "08:00:00"
            },
            new Timezone
            {
                Id = "Aus Central W. Standard Time",
                Name = "(UTC+08:45) Eucla",
                Offset = "08:45:00"
            },
            new Timezone
            {
                Id = "Transbaikal Standard Time",
                Name = "(UTC+09:00) Chita",
                Offset = "09:00:00"
            },
            new Timezone
            {
                Id = "Tokyo Standard Time",
                Name = "(UTC+09:00) Osaka, Sapporo, Tokyo",
                Offset = "09:00:00"
            },
            new Timezone
            {
                Id = "North Korea Standard Time",
                Name = "(UTC+09:00) Pyongyang",
                Offset = "09:00:00"
            },
            new Timezone
            {
                Id = "Korea Standard Time",
                Name = "(UTC+09:00) Seoul",
                Offset = "09:00:00"
            },
            new Timezone
            {
                Id = "Yakutsk Standard Time",
                Name = "(UTC+09:00) Yakutsk",
                Offset = "09:00:00"
            },
            new Timezone
            {
                Id = "Cen. Australia Standard Time",
                Name = "(UTC+09:30) Adelaide",
                Offset = "09:30:00"
            },
            new Timezone
            {
                Id = "AUS Central Standard Time",
                Name = "(UTC+09:30) Darwin",
                Offset = "09:30:00"
            },
            new Timezone
            {
                Id = "E. Australia Standard Time",
                Name = "(UTC+10:00) Brisbane",
                Offset = "10:00:00"
            },
            new Timezone
            {
                Id = "AUS Eastern Standard Time",
                Name = "(UTC+10:00) Canberra, Melbourne, Sydney",
                Offset = "10:00:00"
            },
            new Timezone
            {
                Id = "West Pacific Standard Time",
                Name = "(UTC+10:00) Guam, Port Moresby",
                Offset = "10:00:00"
            },
            new Timezone
            {
                Id = "Tasmania Standard Time",
                Name = "(UTC+10:00) Hobart",
                Offset = "10:00:00"
            },
            new Timezone
            {
                Id = "Vladivostok Standard Time",
                Name = "(UTC+10:00) Vladivostok",
                Offset = "10:00:00"
            },
            new Timezone
            {
                Id = "Lord Howe Standard Time",
                Name = "(UTC+10:30) Lord Howe Island",
                Offset = "10:30:00"
            },
            new Timezone
            {
                Id = "Bougainville Standard Time",
                Name = "(UTC+11:00) Bougainville Island",
                Offset = "11:00:00"
            },
            new Timezone
            {
                Id = "Russia Time Zone 10",
                Name = "(UTC+11:00) Chokurdakh",
                Offset = "11:00:00"
            },
            new Timezone
            {
                Id = "Magadan Standard Time",
                Name = "(UTC+11:00) Magadan",
                Offset = "11:00:00"
            },
            new Timezone
            {
                Id = "Norfolk Standard Time",
                Name = "(UTC+11:00) Norfolk Island",
                Offset = "11:00:00"
            },
            new Timezone
            {
                Id = "Sakhalin Standard Time",
                Name = "(UTC+11:00) Sakhalin",
                Offset = "11:00:00"
            },
            new Timezone
            {
                Id = "Central Pacific Standard Time",
                Name = "(UTC+11:00) Solomon Is., New Caledonia",
                Offset = "11:00:00"
            },
            new Timezone
            {
                Id = "Russia Time Zone 11",
                Name = "(UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky",
                Offset = "12:00:00"
            },
            new Timezone
            {
                Id = "New Zealand Standard Time",
                Name = "(UTC+12:00) Auckland, Wellington",
                Offset = "12:00:00"
            },
            new Timezone
            {
                Id = "UTC+12",
                Name = "(UTC+12:00) Coordinated Universal Time+12",
                Offset = "12:00:00"
            },
            new Timezone
            {
                Id = "Fiji Standard Time",
                Name = "(UTC+12:00) Fiji",
                Offset = "12:00:00"
            },
            new Timezone
            {
                Id = "Kamchatka Standard Time",
                Name = "(UTC+12:00) Petropavlovsk-Kamchatsky - Old",
                Offset = "12:00:00"
            },
            new Timezone
            {
                Id = "Chatham Islands Standard Time",
                Name = "(UTC+12:45) Chatham Islands",
                Offset = "12:45:00"
            },
            new Timezone
            {
                Id = "UTC+13",
                Name = "(UTC+13:00) Coordinated Universal Time+13",
                Offset = "13:00:00"
            },
            new Timezone
            {
                Id = "Tonga Standard Time",
                Name = "(UTC+13:00) Nuku'alofa",
                Offset = "13:00:00"
            },
            new Timezone
            {
                Id = "Samoa Standard Time",
                Name = "(UTC+13:00) Samoa",
                Offset = "13:00:00"
            },
            new Timezone
            {
                Id = "Line Islands Standard Time",
                Name = "(UTC+14:00) Kiritimati Island",
                Offset = "14:00:00"
            }
        };
        #endregion
    }
}
