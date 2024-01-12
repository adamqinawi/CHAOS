//***************************************************************************************//		CSpaceportOC
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
using System.Runtime.CompilerServices;
using System.Security.Claims;


namespace CHAOS.Som
{
  public class CSpaceportOC : HlaObjectClass
  {
    #region Declarations
        public HlaAttribute PortName;
        public HlaAttribute Location;
        public HlaAttribute Callsign;
        public HlaAttribute PortType;
    #endregion //Declarations
    
    #region Constructor
    public CSpaceportOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Spaceport";
      ClassPS = PSKind.PublishSubscribe;

        // Create Attributes
        PortName = new HlaAttribute("Name", PSKind.PublishSubscribe);
        Attributes.Add(PortName);
        Location = new HlaAttribute("Location", PSKind.PublishSubscribe);
        Attributes.Add(Location);
        Callsign = new HlaAttribute("Callsign", PSKind.PublishSubscribe);
        Attributes.Add(Callsign);
        PortType = new HlaAttribute("Type", PSKind.PublishSubscribe);
        Attributes.Add(PortType);
        }
    #endregion //Constructor
  }
}
