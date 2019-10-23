using System;
using Xunit;
using Lab05Part1;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
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



    }
}
