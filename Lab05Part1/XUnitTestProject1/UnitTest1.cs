using System;
using Xunit;
using Lab05Part1;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        #region Test Behavior/ inheritance/ and override.
        /// <summary>
        /// These test show proof of behavior, inheritance and override. The message for eat and
        /// sleep are the override messages that you see here. These also prove that they are all animals.
        /// I wouldn't be able to override the message from animal if Cobra wasn't an animal.
        /// </summary>
        [Fact]
        public void TestBehaviorsForSnake()
        {
            Snake Cobra = new Snake();
            Assert.Equal("Yes, I Eat, I'm a carnivore", Cobra.Eat());
            Assert.Equal("Yes, I Sleep but with my eyes open", Cobra.Sleep());
        }


        [Fact]
        public void TestBehaviorsGorilla()
        {
            Gorilla Silverback = new Gorilla();
            Assert.Equal("Yes, I Eat", Silverback.Eat());
            Assert.Equal("Yes, I Sleep", Silverback.Sleep());

        }


        [Fact]
        public void TestBehaviorsLion()
        {
            Lion Barbary = new Lion();
            Assert.Equal("Yes, I Eat, I'm a carnivore", Barbary.Eat());
            Assert.Equal("Yes, I Sleep a lot about 20 hours a day", Barbary.Sleep());

        }

        [Fact]
        public void TestBehaviorsDinosaur()
        {
            Dinosaur Trex = new Dinosaur();
            Assert.Equal("Yes, I eat lizards, turtles, egss, sometimes other dinosaurs", Trex.Eat());
            Assert.Equal("Yes, I Sleep but no one knows how", Trex.Sleep());

        }



        [Fact]
        public void TestBehaviorsGoldFish()
        {
            Goldfish Lionhead = new Goldfish();
            Assert.Equal("Yes, I Eat, I eat a wide variety of things", Lionhead.Eat());
            Assert.Equal("Yes, I Sleep, with my eyes open anytime of the day", Lionhead.Sleep());

        }

        #endregion


        #region Test Interface
        /// <summary>
        /// These tests test interface for the animals that have them
        /// </summary>
        [Fact]
        
        public void TestInterfaceForGorilla()
        {
            Gorilla Silverback = new Gorilla();
            Assert.Equal("I mainly stick to a vegeterian diet, eating stems, bamboo shoots and fruits.", Silverback.HuntOtherAnimals());

        }

        [Fact]
        public void TestInterfacesForSnake()
        {
            Snake Cobra = new Snake();
            Assert.Equal("Duh, I eat other animals I'm a snake.", Cobra.HuntOtherAnimals());
            Assert.Equal("Is this a joke, I'm a snake of course I can't run.", Cobra.AbleToRun());

        }

        [Fact]
        public void TestInterfaceForGoldfish()
        {
            Goldfish Lionhead = new Goldfish();
            Assert.Equal("Technically I can't run.", Lionhead.AbleToRun());

        }
        #endregion


    }
}
