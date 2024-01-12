using CHAOS.Som;
using Racon.RtiLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAOS
{
    public partial class CSpaceshipFd: Racon.CGenericFederate
    {
        public CSpaceshipHlaObject Spaceship;

        public bool sendMessage(string To, string Message) {
            double timestamp = this.Time;
            // Create a new interaction
            HlaInteraction interaction = new HlaInteraction(Som.RadioMessageIC);
            // Set the parameters
            interaction.AddParameterValue(Som.RadioMessageIC.From, Spaceship.Callsign);
            interaction.AddParameterValue(Som.RadioMessageIC.To, To);
            interaction.AddParameterValue(Som.RadioMessageIC.Message, Message);
            interaction.AddParameterValue(Som.RadioMessageIC.Timestamp, timestamp);

            return SendInteraction(interaction, "1");
        }

        #region Handlers

        // FdAmb_StartRegistrationForObjectClassAdvisedHandler
        public override void FdAmb_StartRegistrationForObjectClassAdvisedHandler(object sender, HlaDeclarationManagementEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_StartRegistrationForObjectClassAdvisedHandler(sender, data);

            #region User Code
            if(data.ObjectClassHandle == Som.SpaceshipOC.Handle)
                RegisterHlaObject(Spaceship);
            #endregion //User Code
        }

        public override void FdAmb_ObjectDiscoveredHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_ObjectDiscoveredHandler(sender, data);

           
            // if object is a ship, add it to list of ships
            if (data.ClassHandle == Som.SpaceshipOC.Handle)
            {
                CSpaceshipHlaObject newShip = new CSpaceshipHlaObject(data.ObjectInstance);
                newShip.Type = Som.SpaceshipOC;
                manager.Ships.Add(newShip);

                //print that spaceship is discovered and its details
                Console.WriteLine($"Spaceship discovered: {newShip.Name} at {newShip.Location.X}, {newShip.Location.Y}, {newShip.Location.Z}" + Environment.NewLine);
            }
            else if (data.ClassHandle == Som.SpaceportOC.Handle)
            {
                CSpaceportHlaObject newPort = new CSpaceportHlaObject(data.ObjectInstance);
                newPort.Type = Som.SpaceportOC;
                manager.Ports.Add(newPort);
                Console.WriteLine($"Spaceport discovered: {newPort.PortName} at {newPort.Location.X}, {newPort.Location.Y}, {newPort.Location.Z}" + Environment.NewLine);
            }
        }

        public override void FdAmb_AttributeValueUpdateRequestedHandler(object sender, HlaObjectEventArgs data)
        {
            // Call the base class handler
            base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

            Console.WriteLine($"hereeeeeeeeeeeeeeeee" + Environment.NewLine);

            #region User Code
            if (data.ObjectInstance.Handle == Spaceship.Handle)
            { 
                var timestamp = Time + Lookahead;
                UpdateShipAttributes(Spaceship, timestamp);
                Console.WriteLine($"Spaceship attributes updated: {Spaceship.Name} at {Spaceship.Location.X}, {Spaceship.Location.Y}, {Spaceship.Location.Z}" + Environment.NewLine);
            }
            #endregion //User Code
        }

        private void UpdateShipAttributes(CSpaceshipHlaObject ship, double timestamp)
        {
            Spaceship.AddAttributeValue(Som.SpaceshipOC.ShipName, Spaceship.ShipName);
            Spaceship.AddAttributeValue(Som.SpaceshipOC.Callsign, Spaceship.Callsign);
            Spaceship.AddAttributeValue(Som.SpaceshipOC.Heading, Spaceship.Heading);
            Spaceship.AddAttributeValue(Som.SpaceshipOC.Class, Spaceship.Class);
            Spaceship.AddAttributeValue(Som.SpaceshipOC.CurrentPayloadWeight, Spaceship.CurrentPayloadWeight);
            Spaceship.AddAttributeValue(Som.SpaceshipOC.Position, Spaceship.Location);


            // Update the attributes in the RTI
            UpdateAttributeValues(ship, timestamp);
        }
        #endregion //Handlers

        public void RegisterShip()
        {
            RegisterHlaObject(Spaceship);
        }

    }
}
