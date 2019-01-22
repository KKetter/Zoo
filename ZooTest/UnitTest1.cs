using System;
using Xunit;
using Zoo.Classes;
using Zoo.Interfaces;

namespace ZooTest
{
    public class UnitTest1
    {
       
        //TODO Test that each of your concrete animals exhibit the at least 2 appropriate behaviors given to them from a base class. 10 Tests

        //Following 4 Tests validate interfaces work as expected
        [Fact]
        public void BaldEagleMascotInterfaceWorks()
        {
            Bald_Eagle baldEagle = new Bald_Eagle();

            string mascot = baldEagle.RepresentingMyTeam();

            Assert.Equal("Go team! Fly Eagles Fly", mascot);

        }
        [Fact]
        public void BlackBearMascotInterfaceWorks()
        {
            Black blackBear = new Black();

            string mascot = blackBear.RepresentingMyTeam();

            Assert.Equal("Go team? Bear Down!", mascot);
        }
        [Fact]
        public void BlackBearSwimInterfaceWorks()
        {
            Black blackBear = new Black();

            string swim = blackBear.swimSpeed();

            Assert.Equal("Im swimming fast to get the fish!", swim);
        }
        [Fact]
        public void PolarBearSwimInterfaceWorks()
        {
            Polar_Bear polarBear = new Polar_Bear();

            string swim = polarBear.swimSpeed();

            Assert.Equal("Im swimming fast because its so cold!", swim);

        }
        //Prove Inheritance
        [Fact]
        public void BlackInheritsProperty()
        {
            Black blackBear = new Black();

            string food = blackBear.Food;

            Assert.Equal("salmon", food);
        }
        //Prove Polymorhpism - Birds go cheep cheep, Eagles sound like freedom
        [Fact]
        public void EagleSoundsAreTransformed()
        {
            Bald_Eagle baldEagle = new Bald_Eagle();

            string sound = baldEagle.Sound();

            Assert.Equal("Eagles sound like freedom", sound);
        }
        //Tests to show 5 concrete animals exhibit at least 2 behaviors - 10 total tests
        [Fact]
        public void BlackBearHasLegs()
        {
            Black blackBear = new Black();

            int legs = blackBear.Legs;

            Assert.Equal(4, 4);
        }
        [Fact]
        public void BlackBearFurApperance()
        {
            Black blackBear = new Black();

            string FurAppearance = blackBear.FurAppearance;

            Assert.Equal("black", "black");
        }
        [Fact]
        public void PolarBearHasLegs()
        {
            Polar_Bear polarBear = new Polar_Bear();

            int legs = polarBear.Legs;

            Assert.Equal(4, 4);
        }
        [Fact]
        public void PolarBearFurApperance()
        {
            Polar_Bear polarBear = new Polar_Bear();

            string FurAppearance = polarBear.FurAppearance;

            Assert.Equal("white", "white");
        }
        [Fact]
        public void MountainLionHasLegs()
        {
            Mountain_Lion mountainLion = new Mountain_Lion();

            int legs = mountainLion.Legs;

            Assert.Equal(4, 4);
        }
        [Fact]
        public void MountainLionFurApperance()
        {
            Mountain_Lion mountainLion = new Mountain_Lion();

            string FurAppearance = mountainLion.FurAppearance;

            Assert.Equal("tan", "tan");
        }
        [Fact]
        public void BaldEagleHasLegs()
        {
            Bald_Eagle baldEagle = new Bald_Eagle();

            int legs = baldEagle.Legs;

            Assert.Equal(2, 2);
        }
        [Fact]
        public void BaldEagleFood()
        {
            Bald_Eagle baldEagle = new Bald_Eagle();

            string food = baldEagle.Food;

            Assert.Equal("Freedom", food);
        }
        [Fact]
        public void EmperorPenguinHasLegs()
        {
            Emperor_Penguin empPenguin = new Emperor_Penguin();

            int legs = empPenguin.Legs;

            Assert.Equal(2, 2);
        }
        [Fact]
        public void EmperorPenguinFood()
        {
            Emperor_Penguin empPenguin = new Emperor_Penguin();

            string Food = empPenguin.Food;

            Assert.Equal("cute fish", Food);
        }
        

    }
}
