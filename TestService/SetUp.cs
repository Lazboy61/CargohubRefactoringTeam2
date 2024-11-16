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
public class SetUp
{
    protected ModelContext Context;

    public SetUp()
    {
        var options = new DbContextOptionsBuilder<ModelContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        Context = new ModelContext(options);
    }
    public void Save()
    {
        Context.SaveChanges();
    }
}
