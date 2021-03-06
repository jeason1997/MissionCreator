﻿using System;
using System.Collections.Generic;

namespace MissionCreator.SerializableData.Cutscenes
{
    public class SerializableCutscene
    {
        public int PlayAt { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public List<SerializableCamera> Cameras { get; set; }
        public List<SerializableSubtitle> Subtitles { get; set; }
    }
}