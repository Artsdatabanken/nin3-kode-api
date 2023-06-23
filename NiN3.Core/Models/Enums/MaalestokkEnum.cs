﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NiN3.Core.Models.Enums
{
    public enum MaalestokkEnum
    {
        [Description("kartleggingsenhet tilpasset 1:5000")]
        M005,
        [Description("kartleggingsenhet tilpasset 1:10 000")]
        M010,
        [Description("kartleggingsenhet tilpasset 1:20 000")]
        M020,
        [Description("kartleggingsenhet tilpasset 1:50 000")]
        M050,
        [Description("kartleggingsenhet tilpasset 1:100 000")]
        M100
    }
}
