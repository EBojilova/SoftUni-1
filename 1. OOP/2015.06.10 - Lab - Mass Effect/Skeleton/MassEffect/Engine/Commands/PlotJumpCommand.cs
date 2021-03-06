﻿namespace MassEffect.Engine.Commands
{
    using MassEffect.GameObjects.Locations;
    using MassEffect.Interfaces;
    using System;
    using System.Linq;
    using MassEffect.Exceptions;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            string destinationName = commandArgs[2];

            IStarship ship = (IStarship)GameEngine.Starships.Select(s => s.Name == shipName);
            this.ValidateAlive(ship);

            var previousLocation = ship.Location;
            StarSystem destination = (StarSystem)Enum.Parse(typeof(StarSystem), destinationName);

            if (previousLocation.Name == destination.Name)
            {
                throw new ShipException(string.Format(Messages.ShipAlreadyInStarSystem, destinationName));
            }

            GameEngine.Galaxy.TravelTo(ship, destination);
            Console.WriteLine(Messages.ShipTraveled, shipName, previousLocation.Name, destinationName);
        }
    }
}
