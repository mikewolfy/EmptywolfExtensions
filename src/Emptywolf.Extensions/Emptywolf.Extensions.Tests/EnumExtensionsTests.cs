using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Emptywolf.Extensions.Tests
{
    public class EnumExtensionsTests
    {
        public enum VehicleMakes
        {
            Toyota,
            Honda,
            Ford,
            Chevrolet
        }

        [ExcludeFromCodeCoverage]
        public class StringToEnumMapperTests
        {

            [Fact]
            public void TestMapper()
            {
                var enumString = "Ford";
                var output = enumString.MapToEnum<VehicleMakes>();
                Assert.Equal(VehicleMakes.Ford, output);
            }

            [Theory]
            [InlineData("Chevrolet", VehicleMakes.Chevrolet)]
            [InlineData("Honda", VehicleMakes.Honda)]
            [InlineData("BogusValue", VehicleMakes.Toyota)]
            public void TestDifferentEnums(string enumString, VehicleMakes expectedEnum)
            {
                var output = enumString.MapToEnum<VehicleMakes>();
                Assert.Equal(expectedEnum, output);
            }
        }
    }
}
