﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WowDotNetAPI.Utilities
{
    public static class GuildUtil
    {
        public const string basePath = "/api/wow/guild/";
        public const string rewardsPath = "/api/wow/data/guild/rewards";
        public const string perksPath = "/api/wow/data/guild/perks";

        public static string buildOptionalQuery(GuildOptions realmOptions)
        {
            string query = "?fields=";
            List<string> tmp = new List<string>();

            if ((realmOptions & GuildOptions.GetMembers) == GuildOptions.GetMembers)
                tmp.Add("members");

            if ((realmOptions & GuildOptions.GetAchievements) == GuildOptions.GetAchievements)
                tmp.Add("achievements");

            query += string.Join(",", tmp);

            return query;
        }

    }
}
