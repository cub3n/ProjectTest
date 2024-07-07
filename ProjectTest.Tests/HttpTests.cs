using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using ProjectTest.Web;

namespace ProjectTest.Tests;

public class HttpTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public HttpTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Get_EndpointsReturnSuccessAndCorrectContentType()
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("/Home/GetEmployees");

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        Assert.Equal("application/json; charset=utf-8",
            response.Content.Headers.ContentType?.ToString());

        string body = await response.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
        string expectedBody = JsonSerializer.Serialize(Constants.Employees, options);
        Assert.Equal(expectedBody, body);
    }
}