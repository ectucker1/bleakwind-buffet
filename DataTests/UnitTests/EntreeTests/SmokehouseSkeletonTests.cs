/*
 * Author: Zachery Brunner
 * Edited by: Ethan Tucker
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ss);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            var ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            var ss = new SmokehouseSkeleton();
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var ss = new SmokehouseSkeleton();
            ss.Egg = false;
            Assert.False(ss.Egg);
            ss.Egg = true;
            Assert.True(ss.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            var ss = new SmokehouseSkeleton();
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            var ss = new SmokehouseSkeleton();
            ss.Pancake = false;
            Assert.False(ss.Pancake);
            ss.Pancake = true;
            Assert.True(ss.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal(602u, ss.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var ss = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };

            if (!includeSausage)
                Assert.Contains("Hold sausage", ss.SpecialInstructions);
            if (!includeEgg)
                Assert.Contains("Hold eggs", ss.SpecialInstructions);
            if (!includeHashbrowns)
                Assert.Contains("Hold hash browns", ss.SpecialInstructions);
            if (!includePancake)
                Assert.Contains("Hold pancakes", ss.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake)
                Assert.Empty(ss.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }

        [Fact]
        public void ShouldHaveCorrectBaseName()
        {
            var ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.BaseName);
        }

        [Fact]
        public void ShouldNotifyWhenSettingSausageLink()
        {
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.SausageLink), () => {
                ss.SausageLink = false;
            });
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.SausageLink), () => {
                ss.SausageLink = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingEgg()
        {
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.Egg), () => {
                ss.Egg = false;
            });
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.Egg), () => {
                ss.Egg = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingHashBrowns()
        {
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.HashBrowns), () => {
                ss.HashBrowns = false;
            });
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.HashBrowns), () => {
                ss.HashBrowns = true;
            });
        }

        [Fact]
        public void ShouldNotifyWhenSettingPancake()
        {
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.Pancake), () => {
                ss.Pancake = false;
            });
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.Pancake), () => {
                ss.Pancake = true;
            });
        }

        [Fact]
        public void ShouldNotifySpecialInstructionsChanged()
        {
            var ss = new SmokehouseSkeleton();
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.SausageLink), () => {
                ss.SausageLink = false;
            });
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.Egg), () => {
                ss.Egg = false;
            });
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.HashBrowns), () => {
                ss.HashBrowns = false;
            });
            Assert.PropertyChanged(ss, nameof(SmokehouseSkeleton.Pancake), () => {
                ss.Pancake = false;
            });
        }
    }
}