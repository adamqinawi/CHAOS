// **************************************************************************************************
//		CSimulationManager
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
/// The Simulation Manager manages the (multiple) federation execution(s) and the (multiple instances of) joined federate(s).
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
  public partial class CSimulationManager
  {
    #region Declarations
    // Communication layer related structures
    public CSpaceshipFd federate; //Application-specific federate 
    // Local data structures
    // TODO: user-defined data structures are declared here
    #endregion //Declarations
    
    #region Constructor
    public CSimulationManager()
    {
      // Initialize the application-specific federate
      federate = new CSpaceshipFd(this);
      // Initialize the federation execution
      federate.FederationExecution.Name = "CHAOS";
      federate.FederationExecution.FederateType = "NewFederate";
      federate.FederationExecution.ConnectionSettings = "rti://127.0.0.1";
      // Handle RTI type variation
      initialize();
    }
    #endregion //Constructor
    
    #region Methods
    // Handles naming variation according to HLA specification
    private void initialize()
    {
      switch (federate.RTILibrary)
      {
        case RTILibraryType.HLA13_DMSO: case RTILibraryType.HLA13_Portico: case RTILibraryType.HLA13_OpenRti:
                federate.Som.SpaceportOC.Name = "objectRoot.Spaceport";
                federate.Som.SpaceportOC.PrivilegeToDelete.Name = "privilegeToDelete";
                federate.Som.RadioMessageIC.Name = "interactionRoot.RadioMessage";
                federate.FederationExecution.FDD = @".\CHAOSFOM.fed";
        break;
        case RTILibraryType.HLA1516e_Portico: case RTILibraryType.HLA1516e_OpenRti:
                federate.Som.SpaceportOC.Name = "HLAobjectRoot.Spaceport";
                federate.Som.SpaceportOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                federate.Som.RadioMessageIC.Name = "HLAinteractionRoot.RadioMessage";
                federate.FederationExecution.FDD = @".\CHAOSFOM.xml";
        break;
      }
    }
    #endregion //Methods
  }
}
