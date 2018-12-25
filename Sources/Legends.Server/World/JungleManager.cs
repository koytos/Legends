﻿using Legends.Core.DesignPattern;
using Legends.Core.Time;
using Legends.Protocol.GameClient.Enum;
using Legends.Records;
using Legends.World.Entities.AI;
using Legends.World.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Legends.World
{
    public class JungleManager : Singleton<JungleManager>
    {
        private Dictionary<string, UpdateTimer> RespawnTimers = new Dictionary<string, UpdateTimer>();

        [InDevelopment(InDevelopmentState.TODO, "its a monster group...")]
        public void SpawnCamp(string monsterName, Game game, Vector2 position)
        {
            AIMonster monster = new AIMonster(game.NetIdProvider.PopNextNetId(), AIUnitRecord.GetAIUnitRecord(monsterName), 0);
            monster.Position = position;
            monster.SpawnPosition = position;
            monster.DefineGame(game);
            game.AddUnitToTeam(monster, TeamId.NEUTRAL);
            game.Map.AddUnit(monster);
            monster.Initialize();
            monster.Create();
        }
    }
}
