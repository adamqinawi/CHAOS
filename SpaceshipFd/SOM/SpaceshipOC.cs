// **************************************************************************************************
//		CSpaceshipOC
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


namespace CHAOS.Som
{
  public class CSpaceshipOC : HlaObjectClass
  {
        #region Declarations
        public HlaAttribute ShipName;
        public HlaAttribute Position;
        public HlaAttribute Callsign;
        public HlaAttribute Heading;
        public HlaAttribute Class;
        public HlaAttribute CurrentPayloadWeight;
    #endregion //Declarations
    
    #region Constructor
    public CSpaceshipOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Spaceship";
      ClassPS = PSKind.PublishSubscribe;

            // Create Attributes
            ShipName = new HlaAttribute("Name", PSKind.PublishSubscribe);
            Attributes.Add(ShipName);
            Position = new HlaAttribute("Location", PSKind.PublishSubscribe);
            Attributes.Add(Position);
            Callsign = new HlaAttribute("Callsign", PSKind.PublishSubscribe);
            Attributes.Add(Callsign);
            Heading = new HlaAttribute("Heading", PSKind.PublishSubscribe);
            Attributes.Add(Heading);
            Class = new HlaAttribute("Class", PSKind.PublishSubscribe);
            Attributes.Add(Class);
            CurrentPayloadWeight = new HlaAttribute("CurrentPayloadWeight", PSKind.PublishSubscribe);
            Attributes.Add(CurrentPayloadWeight);
    }
    #endregion //Constructor
  }
}
