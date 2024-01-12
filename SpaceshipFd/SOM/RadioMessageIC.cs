// **************************************************************************************************
//		CRadioMessageIC
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
  public class CRadioMessageIC : HlaInteractionClass
  {
    #region Declarations
    public HlaParameter Message;
    public HlaParameter From;
    public HlaParameter Timestamp;
        public HlaParameter To;
    #endregion //Declarations
    
    #region Constructor
    public CRadioMessageIC() : base()
    {
      // Initialize Class Properties
      Name = "HLAinteractionRoot.RadioMessage";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Parameters
      // Message
      Message = new HlaParameter("Message");
      Parameters.Add(Message);
      // From
      From = new HlaParameter("From");
      Parameters.Add(From);
      // Timestamp
      Timestamp = new HlaParameter("Timestamp");
      Parameters.Add(Timestamp);
      // To
      To = new HlaParameter("To");
      Parameters.Add(To);
    }
    #endregion //Constructor
  }
}
