﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDevices
{
    public class MediaDeviceServiceHints : MediaDeviceService
    {
        internal MediaDeviceServiceHints(MediaDevice device, string serviceId) : base(device, serviceId)
        {

        }

        protected override void Update()
        {
            // no properties
        }

        
        
    }
}
