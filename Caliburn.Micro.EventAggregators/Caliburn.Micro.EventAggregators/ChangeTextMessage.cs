﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.EventAggregators
{
    public class ChangeTextMessage
    {
        public string Text
        {
            get;
            private set;
        }

        public ChangeTextMessage(string text)
        {
            Text = text;
        }
    }
}
