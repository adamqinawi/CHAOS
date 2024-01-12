// **************************************************************************************************
//		CSpaceshipHlaObject
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
/// This is a wrapper class for local data structures. This class is extended from the object model of RACoN API
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
  public class CSpaceshipHlaObject : HlaObject
  {
        #region Declarations
        // TODO: Declare your local object structure here
        public LocationType Location;
        public string ShipName;
        public string Callsign;
        public string Heading;
        public ShipclassType Class;
        public float CurrentPayloadWeight;
    #endregion //Declarations
    
    #region Constructor

        public CSpaceshipHlaObject(HlaObjectClass _type, LocationType location, string name, string callsign, string heading, ShipclassType Class, float currentPayloadWeight): base(_type)
        {
            Type = _type;
            Location = location;
            ShipName = name;
            Callsign = callsign;
            Heading = heading;
            this.Class = Class;
            CurrentPayloadWeight = currentPayloadWeight;
        }

        public CSpaceshipHlaObject(HlaObjectClass _type) : base(_type)
    {
      // TODO: Instantiate local data here
      // var Data = new Your_LocalData_Type();
    }
    // Copy constructor - used in callbacks
    public CSpaceshipHlaObject(HlaObject _obj) : base(_obj)
    {
      // TODO: Instantiate local data here
      // var Data = new Your_LocalData_Type();
    }
    #endregion //Constructor
  }
}
