// **************************************************************************************************
//		Data Types
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
/// This file includes the enumerated and fixed record data types.
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
  #region Enumerated Datatypes
  public enum ShipclassType {  Hauler = 0, Frigate = 1, Passenger = 2 };
  public enum StationtypeType {  Orbital = 0, Planetary = 1, Interstellar = 2 };
  #endregion
  
  #region Fixed Record Datatypes
  public struct LocationType
  {
    public long X; // Datatype defined in SOM: HLAinteger64Time
    public long Y; // Datatype defined in SOM: HLAinteger64Time
    public long Z; // Datatype defined in SOM: HLAinteger64Time
  
    public LocationType(long x, long y, long z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
  #endregion
  #region Variant Record Datatypes
  #endregion
  
}
