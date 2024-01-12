// **************************************************************************************************
//		FederateSom
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
  public class FederateSom : Racon.ObjectModel.CObjectModel
  {
    #region Declarations
    #region SOM Declaration
    public CHAOS.Som.CSpaceportOC SpaceportOC;
    public CHAOS.Som.CSpaceshipOC SpaceshipOC;
    public CHAOS.Som.CRadioMessageIC RadioMessageIC;
    #endregion
    #endregion //Declarations
    
    #region Constructor
    public FederateSom() : base()
    {
      // Construct SOM
      SpaceportOC = new CHAOS.Som.CSpaceportOC();
      AddToObjectModel(SpaceportOC);
      SpaceshipOC = new CHAOS.Som.CSpaceshipOC();
      AddToObjectModel(SpaceshipOC);
      RadioMessageIC = new CHAOS.Som.CRadioMessageIC();
      AddToObjectModel(RadioMessageIC);
    }
    #endregion //Constructor
  }
}
