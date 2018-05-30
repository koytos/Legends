﻿using Legends.Core.Protocol.Enum;
using Legends.Core.Protocol.LoadingScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Legends.Configurations
{
    public class PlayerData
    {
        public long UserId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ChampionName
        {
            get;
            set;
        }
        public int SkinId
        {
            get;
            set;
        }
        public string Team
        {
            get;
            set;
        }
        [IgnoreDataMember]
        public TeamId TeamId
        {
            get
            {
                return (TeamId)Enum.Parse(typeof(TeamId), Team, true);
            }
        }
        [IgnoreDataMember]
        public SummonerSpellId Summoner1Spell
        {
            get
            {
                return (SummonerSpellId)Enum.Parse(typeof(SummonerSpellId), Summoner1, true);
            }
        }
        [IgnoreDataMember]
        public SummonerSpellId Summoner2Spell
        {
            get
            {
                return (SummonerSpellId)Enum.Parse(typeof(SummonerSpellId), Summoner2, true);
            }
        }
        public string Summoner1
        {
            get;
            set;
        }
        public string Summoner2
        {
            get;
            set;
        }
        public string Rank
        {
            get;
            set;
        }
        public int SummonerIcon
        {
            get;
            set;
        }
        public int Ribbon
        {
            get;
            set;
        }
        public PlayerInformations GetPlayerInformations()
        {
            return new PlayerInformations(UserId, 0, (int)Summoner1Spell, (int)Summoner2Spell, 0, (int)TeamId, Name, Rank, SummonerIcon, (short)Ribbon);
        }

    }
}