﻿using Rage;

namespace MissionCreator.SerializableData.Objectives
{
    public class SerializableMarker : SerializableObjective
    {
        public Vector3 Scale { get; set; }
        public Vector3 Color { get; set; }
        public int Alpha { get; set; }
        public int Type { get; set; }
    }
}