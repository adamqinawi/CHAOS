// **************************************************************************************************
//		CSpaceportHlaObject
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
  public class CSpaceportHlaObject : HlaObject
  {
        #region Declarations
        public string PortName;
        public LocationType Location;
        public StationtypeType SpaceportType;
        public string Callsign;
        #endregion //Declarations

        #region Constructor
        public CSpaceportHlaObject(HlaObjectClass _type, string Name, LocationType Location, StationtypeType Type, string Callsign) : base(_type)
        { 
            this.PortName = Name;
            this.Location = Location;
            this.SpaceportType = Type;
            this.Callsign = Callsign;
        }

        public CSpaceportHlaObject(HlaObjectClass _type) : base(_type)
    {
            this.PortName = "Parapoopoo";
            this.Location = new LocationType(1, 1, 1);
            this.SpaceportType = StationtypeType.Orbital;
            this.Callsign = "PPP";
    }

    // Copy constructor - used in callbacks
    public CSpaceportHlaObject(HlaObject _obj) : base(_obj)
    {
        // Copy attributes
        this.PortName = ((CSpaceportHlaObject)_obj).PortName;
        this.Location = ((CSpaceportHlaObject)_obj).Location;
        this.SpaceportType = ((CSpaceportHlaObject)_obj).SpaceportType;
        this.Callsign = ((CSpaceportHlaObject)_obj).Callsign;
    }
    #endregion //Constructor
  }
}
