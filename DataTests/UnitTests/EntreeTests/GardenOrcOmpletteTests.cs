/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var goc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goc);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var goc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goc);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var goc = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goc);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            var goc = new GardenOrcOmelette();
            Assert.True(goc.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            var goc = new GardenOrcOmelette();
            Assert.True(goc.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            var goc = new GardenOrcOmelette();
            Assert.True(goc.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            var goc = new GardenOrcOmelette();
            Assert.True(goc.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var goc = new GardenOrcOmelette();
            goc.Broccoli = false;
            Assert.False(goc.Broccoli);
            goc.Broccoli = true;
            Assert.True(goc.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var goc = new GardenOrcOmelette();
            goc.Mushrooms = false;
            Assert.False(goc.Mushrooms);
            goc.Mushrooms = true;
            Assert.True(goc.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var goc = new GardenOrcOmelette();
            goc.Tomato = false;
            Assert.False(goc.Tomato);
            goc.Tomato = true;
            Assert.True(goc.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var goc = new GardenOrcOmelette();
            goc.Cheddar = false;
            Assert.False(goc.Cheddar);
            goc.Cheddar = true;
            Assert.True(goc.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var goc = new GardenOrcOmelette();
            Assert.Equal(4.57, goc.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var goc = new GardenOrcOmelette();
            Assert.Equal(404u, goc.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var goc = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };

            if (!includeBroccoli)
                Assert.Contains("Hold broccoli", goc.SpecialInstructions);
            if (!includeMushrooms)
                Assert.Contains("Hold mushrooms", goc.SpecialInstructions);
            if (!includeTomato)
                Assert.Contains("Hold tomato", goc.SpecialInstructions);
            if (!includeCheddar)
                Assert.Contains("Hold cheddar", goc.SpecialInstructions);
            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar)
                Assert.Empty(goc.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var goc = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goc.ToString());
        }

        [Fact]
        public void ShouldNotifyWhenSettingBroccoli()
        {
            var goc = new GardenOrcOmelette();
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Broccoli), () => {
                goc.Broccoli = false;
            });
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Broccoli), () => {
                goc.Broccoli = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingMushrooms()
        {
            var goc = new GardenOrcOmelette();
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Mushrooms), () => {
                goc.Mushrooms = false;
            });
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Mushrooms), () => {
                goc.Mushrooms = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingTomato()
        {
            var goc = new GardenOrcOmelette();
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Tomato), () => {
                goc.Tomato = false;
            });
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Tomato), () => {
                goc.Tomato = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingCheddar()
        {
            var goc = new GardenOrcOmelette();
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Cheddar), () => {
                goc.Cheddar = false;
            });
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Cheddar), () => {
                goc.Cheddar = true;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var goc = new GardenOrcOmelette();
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Broccoli), () => {
                goc.Broccoli = false;
            });
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Mushrooms), () => {
                goc.Mushrooms = false;
            });
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Tomato), () => {
                goc.Tomato = false;
            });
            Assert.PropertyChanged(goc, nameof(GardenOrcOmelette.Cheddar), () => {
                goc.Cheddar = false;
            });
        }
    }
}