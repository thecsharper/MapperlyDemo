using Riok.Mapperly.Abstractions;

namespace MapperlyDemo
{
    // Enums of source and target have different numeric values -> use ByName strategy to map them
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class CarMapper
    {
        [MapProperty(nameof(Car.Manufacturer), nameof(CarDto.Producer))] // Map property with a different name in the target type
        public partial CarDto MapCarToDto(Car car);
    }
}
