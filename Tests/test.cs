using Xunit;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class CRUDTest
{
    private ModelContext Context;
    public CRUDTest()
    {
        
        var options = new DbContextOptionsBuilder<ModelContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
       
        Context = new ModelContext(options);
        
    }
    
    [Fact]
    public void GetTest()
    {
       
        Context.ItemGroups.Add(new ItemGroup { Id = 1, Name = "Group 1" });
        Context.ItemGroups.Add(new ItemGroup { Id = 2, Name = "Group 2" });
        Context.ItemGroups.Add(new ItemGroup { Id = 9, Name = "Group 2" });
        Context.locations.Add(new Location { Id = 1, Name = "Location 1" });
        Context.locations.Add(new Location { Id = 2, Name = "Location 2" });
        Context.locations.Add(new Location { Id = 9, Name = "Location 3" });
        Context.Clients.Add(new Client { Id = 9, Name = "Location 3" });
    
        Context.SaveChanges(); // heel raar hoe dit werkt ik kan dit niet op de constructor 
        //zetten zonder dat dingen breken op een niet logische volgorde
        
        
        // var CheckClient = new ClientService(Context);
        var CheckServiceitemGroup = new CrudService<ItemGroup>(Context);
        var CheckServiceitemLocation= new CrudService<Location>(Context);
        ItemGroup itemGroup = CheckServiceitemGroup.Get(9);
        Location location = CheckServiceitemLocation.Get(9);
        // Client client = CheckClient.Get(9);
        // Assert.Equal("Location 3",client.Name);
        Assert.Equal("Group 2",itemGroup.Name);
        Assert.Equal("Location 3",location.Name);
    }
    [Fact]
    public void GetAllTest()
    {
        // Given
       
        // When
        var CheckServiceitemGroup = new CrudService<ItemGroup>(Context);
        var CheckServiceitemLocation= new CrudService<Location>(Context);
        
        
    
        // Then
        List<ItemGroup> itemGroups = CheckServiceitemGroup.GetAll();
        List<Location> locations = CheckServiceitemLocation.GetAll();
        int amountItemGroups = Context.ItemGroups.ToList().Count;
        int amountlocations = Context.ItemGroups.ToList().Count;
        Assert.Equal(2,itemGroups.Count);
        Assert.Equal(2,locations.Count);
    }
    [Fact]
    public void DeleteTest()
    {
        // Given
            
        // When
        var CheckServiceitemGroup = new CrudService<ItemGroup>(Context);
        var CheckServiceitemLocation= new CrudService<Location>(Context);
        bool check = CheckServiceitemGroup.Delete(1);
        bool check2 = CheckServiceitemLocation.Delete(1);
        // Then
        Assert.True(check);
        Assert.True(check2);
    }
    [Fact]
    public void Update() // can be both put and/or patch 
    {
        // Given
    
        // When
    
        // Then
        Assert.True(true);
    }
    
    
}
// alles word gerunt voordat de check word gedaan of iets goed is of niet