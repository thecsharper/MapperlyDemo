using MapperlyDemo;
using FluentAssertions;

var mapper = new CarMapper();

var car = new Car { 
                    Name = "Test Car", 
                    Color = CarColor.Blue, 
                    NumberOfSeats = 10, 
                    Manufacturer = new Manufacturer(1, "Test Manufacturer")
                  };

var dto = mapper.MapCarToDto(car);

dto.NumberOfSeats.Should().Be(10);

Console.WriteLine(dto.Name);
Console.WriteLine(dto.Color);
Console.WriteLine(dto.NumberOfSeats);
Console.WriteLine($"{dto.Producer?.Name} {dto.Producer?.Id}");
Console.WriteLine(dto.Tires?.FirstOrDefault()?.Description);