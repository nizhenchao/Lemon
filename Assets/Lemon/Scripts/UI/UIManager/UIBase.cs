﻿using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Lemon.UI
{
    public partial class UIBase : BaseMonoUIClass
    {
        public virtual bool IsCanEnter() { return true; }

        public virtual void OnEnter() { }

        public virtual void OnPause() { }

        public virtual void OnResume() { }

        public virtual void OnExit() { }

    }
}
