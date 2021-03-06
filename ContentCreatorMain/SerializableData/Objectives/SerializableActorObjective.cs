﻿using System.Collections.Generic;
using MissionCreator.SerializableData.Waypoints;
using Rage;

namespace MissionCreator.SerializableData.Objectives
{
    public class SerializableActorObjective : SerializableObjective
    {
        public List<SerializableWaypoint> Waypoints { get; set; }

        public uint ModelHash { get; set; }
        public uint WeaponHash { get; set; }
        public int WeaponAmmo { get; set; }
        public int RelationshipGroup { get; set; }
        public int Behaviour { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Accuracy { get; set; }

        public bool ShowHealthBar { get; set; }
        public string Name { get; set; }

        public bool SpawnInVehicle { get; set; }
        public int VehicleSeat { get; set; }

        private Ped _veh;

        public virtual void SetPed(Ped veh)
        {
            _veh = veh;
        }

        public virtual Ped GetPed()
        {
            return _veh;
        }
    }
}