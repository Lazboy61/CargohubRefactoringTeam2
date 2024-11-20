// using Xunit;

// public class TestWarehouse : SetUp
// {
//     public TestWarehouse() : base()
//     {
//     }
    
//     [Fact]
//     public void GetAll()
//     {
//         // Given
//         var warehouse = new Warehouse
//         {
//             Id = 1,
//             Code = "WH001",
//             Name = "Main Warehouse",
//             Address = "123 Warehouse St.",
//             City = "Rotterdam",
//             ZipCode = "3011",
//             Province = "South Holland",
//             Country = "Netherlands",
//             ContactName = "John Doe",
//             ContactPhone = "0101234567",
//             ContactEmail = "johndoe@warehouse.com"
//         };
//         var warehouse2= new Warehouse
//         {
//             Id = 2,
//             Code = "WH001",
//             Name = "Main Warehouse",
//             Address = "123 Warehouse St.",
//             City = "Rotterdam",
//             ZipCode = "3011",
//             Province = "South Holland",
//             Country = "Netherlands",
//             ContactName = "John Doe",
//             ContactPhone = "0101234567",
//             ContactEmail = "johndoe@warehouse.com"
//         };
//         Context.warehouses.Add(warehouse);
//         Context.warehouses.Add(warehouse2);
//         Context.SaveChanges();

    
//         // When

//         var holder = ServiceWarehouse.GetAll();

//         // Then
//         Assert.Equal(2,holder.Count);
//     }
//     [Fact]
//     public void GetByID()
//     {
//         // Given
//         var warehouse = new Warehouse
//         {
//             Id = 3,
//             Code = "SECRET",
//             Name = "Main Warehouse",
//             Address = "123 Warehouse St.",
//             City = "Rotterdam",
//             ZipCode = "3011",
//             Province = "South Holland",
//             Country = "Netherlands",
//             ContactName = "John Doe",
//             ContactPhone = "0101234567",
//             ContactEmail = "johndoe@warehouse.com"
//         };

//         Context.warehouses.Add(warehouse);


//         // When
//         var holder = ServiceWarehouse.Get(3);

//         // Then
//         Assert.Equal("SECRET",holder.name);
//     }
//     [Fact]
//     public void LinkedLocations()
//     {

//         // Given


//         var location = new Location
//         {
//             Id = 1,
//             WarehouseId = 1,  
//             Code = "LOC001",
//             Name = "Location A",
//             CreatedAt = DateTime.UtcNow,  
//             UpdatedAt = DateTime.UtcNow  
//         };
//         var location2 = new Location
//         {
//             Id = 2,
//             WarehouseId = 1,  
//             Code = "LOC001",
//             Name = "Location B",
//             CreatedAt = DateTime.UtcNow,  
//             UpdatedAt = DateTime.UtcNow  
//         };
//         Context.locations.AddRange(location,location2);
//         this.Save();

    
//         // When
//         var holder = ServiceWarehouse.GetLinkedLocations(3);



    
//         // Then
//         Assert.Equal(2,holder.Count);
//     }

// }

