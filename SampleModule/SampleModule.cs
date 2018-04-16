﻿using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModule
{
    public class SampleModule : IModule
    {
        private IRegionManager _regionManager;
        public SampleModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.SampleView));
        }
    }
}
