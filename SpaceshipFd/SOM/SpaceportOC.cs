// **************************************************************************************************
//		CSpaceportOC
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Tuesday, 19 December 2023 13:59:53
//		compatible with		: 	RACoN v.0.0.2.5
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// This class is extended from the object model of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using CHAOS.Som;


namespace CHAOS.Som
{
  public class CSpaceportOC : HlaObjectClass
  {
    #region Declarations
    #endregion //Declarations
    
    #region Constructor
    public CSpaceportOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Spaceport";
      ClassPS = PSKind.Subscribe;
      
      // Create Attributes
    }
    #endregion //Constructor
  }
}
