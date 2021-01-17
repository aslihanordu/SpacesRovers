using System;
using Xunit;
using SpacesRovers;
using SpacesRovers.Abstraction;
using SpacesRovers.Models;
using System.Collections.Generic;
using System.IO;

namespace SpaceRovers.UnitTests
{
    public class SpaceRoverComponentTests
    {
        List<IRover> roverList = new List<IRover>();

        [Fact]
        public void GetPlateauTest()
        {
            using (var sr = new StringReader("5 5"))
            {
                Console.SetIn(sr);
                var roverCommand = new RoverCommand();
                var res = roverCommand.GetPlateau();
                Assert.True(res);
            }
        }
        [Fact]
        public void DirectionsTest()
        {
            var roverCommand = new RoverCommand();
            var res = roverCommand.Directions("N");
            Assert.Equal(Direction.N, res);
        }
        [Fact]
        public void GetMoveListTest()
        {
            List<string> moveList = new List<string>();
            moveList.Add("L");
            moveList.Add("M");
            moveList.Add("L");
            moveList.Add("M");
            moveList.Add("L");
            moveList.Add("M");
            moveList.Add("L");
            moveList.Add("M");
            moveList.Add("M");
            var roverCommand = new RoverCommand();
            IRover rover = new Rover();
            rover.Position.coordinates.X = 1;
            rover.Position.coordinates.Y = 2;
            rover.Position.direction = Direction.N;
            var res = roverCommand.GetMoveList("LMLMLMLMM", rover);
            Assert.Equal(moveList, res);
        }
        [Fact]
        public void GetPositionsRoverTest()
        {
            using (var sr = new StringReader("1 2 N" + Environment.NewLine + "LMLMLMLMM"))
            {
                Console.SetIn(sr);
                var roverCommand = new RoverCommand();
                var res = roverCommand.GetPositionsRover();
                Assert.True(res);
            }
        }
        [Fact]
        public void GetOutputTest()
        {
            var roverCommand = new RoverCommand();
            var res = roverCommand.GetOutput();
            Assert.Equal("output was written to the console", res);
        }
    }
}
