// **************************************************************************************************
//		CSpaceportFd
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Tuesday, 19 December 2023 14:58:29
//		compatible with		: 	RACoN v.0.0.2.5
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// The application specific federate that is extended from the Generic Federate Class of RACoN API. This file is intended for manual code operations.
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using CHAOS.Som;

namespace CHAOS
{
  public partial class CSpaceportFd : Racon.CGenericFederate
  {
    #region Manually Added Code
    
    // Local Data
    private CSimulationManager manager;
    
    #region Constructor
    public CSpaceportFd(CSimulationManager parent) : this()
    {
      manager = parent; // Set simulation manager
                        // Create regions manually
    }
    #endregion //Constructor
    
    #endregion //Manually Added Code

  }
}
