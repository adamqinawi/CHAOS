using CHAOS.Som;
using Racon.RtiLayer;
using SpaceportFdApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAOS;

public partial class CSpaceportFd
{

    // our local spaceport object
    public CSpaceportHlaObject Spaceport;

    public override void FdAmb_InteractionReceivedHandler(object sender, HlaInteractionEventArgs data)
    {
        // Call the base class handler
        base.FdAmb_InteractionReceivedHandler(sender, data);

        //if message is for this spaceport
        if(data.GetParameterValue<string>(Som.RadioMessageIC.To) == Spaceport.Callsign)
        {
            //for now, just print to console
            Console.WriteLine($"RadioMessage: From: {data.GetParameterValue<string>(Som.RadioMessageIC.From)} > {data.GetParameterValue<string>(Som.RadioMessageIC.Message)} at {data.GetParameterValue<float>(Som.RadioMessageIC.Timestamp)}" + Environment.NewLine);
        }
    }

    #region Handlers

    public override void FdAmb_AttributeValueUpdateRequestedHandler(object sender, HlaObjectEventArgs data)
    {
        // Call the base class handler
        base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

        #region User Code
        if (data.ObjectInstance.Handle == Spaceport.Handle)
        {
            var timestamp = Time + Lookahead;
            UpdatePortAttributes(Spaceport, timestamp);
        }
        #endregion //User Code
    }

    private void UpdatePortAttributes(CSpaceportHlaObject port, double timestamp)
    {
        port.AddAttributeValue(Som.SpaceportOC.PortName, port.PortName);
        port.AddAttributeValue(Som.SpaceportOC.Callsign, port.Callsign);
        port.AddAttributeValue(Som.SpaceportOC.Location, port.Location);
        port.AddAttributeValue(Som.SpaceportOC.PortType, (uint)port.SpaceportType);


        // Update the attributes in the RTI
        UpdateAttributeValues(port, timestamp);
    }

    // FdAmb_ObjectDiscoveredHandler
    public override void FdAmb_ObjectDiscoveredHandler(object sender, HlaObjectEventArgs data)
    {
        // Call the base class handler
        base.FdAmb_ObjectDiscoveredHandler(sender, data);

        #region User Code
        // if object is a ship, add it to list of ships
        if(data.ClassHandle == Som.SpaceshipOC.Handle)
        {
            CSpaceshipHlaObject newShip = new CSpaceshipHlaObject(data.ObjectInstance);
            newShip.Type = Som.SpaceshipOC;
            manager.Ships.Add(newShip);

            //RequestAttributeValueUpdate(newShip, Som.SpaceshipOC.Attributes);
            RequestAttributeValueUpdate(newShip,null);

            //print that spaceship is discovered and its details
            Console.WriteLine($"Spaceship discovered: {newShip.ShipName} at {newShip.Location.X}, {newShip.Location.Y}, {newShip.Location.Z}" + Environment.NewLine);
        } else if (data.ClassHandle == Som.SpaceportOC.Handle)
        {
            CSpaceportHlaObject newPort = new CSpaceportHlaObject(data.ObjectInstance);
            newPort.Type = Som.SpaceportOC;
            manager.Ports.Add(newPort);
            //RequestAttributeValueUpdate(newPort, Som.SpaceportOC.Attributes);
            RequestAttributeValueUpdate(Som.SpaceportOC, null);

            Console.WriteLine($"Spaceport discovered: {newPort.PortName} at {newPort.Location.X}, {newPort.Location.Y}, {newPort.Location.Z}" + Environment.NewLine);
        }
        #endregion //User Code
    }

    public override void FdAmb_StartRegistrationForObjectClassAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
    {
        // Call the base class handler
        base.FdAmb_StartRegistrationForObjectClassAdvisedHandler(sender, data);

        #region User Code
        if (data.ObjectClassHandle == Som.SpaceportOC.Handle)
            RegisterHlaObject(Spaceport);
            UpdatePortAttributes(Spaceport, Time);
        #endregion //User Code
    }
    #endregion //Handlers

}
