using System.Net;
using RestSharp;

namespace test;

public class BookApiTests : BaseTest
{
    [Test]
    public void GetInventoryShouldBeOk()
    {
        // Arrange
        var request = new RestRequest();

        // Act
        var result = client.GetAsync((request)).GetAwaiter().GetResult();

        // Assert
        Assert.That(result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        Assert.That(result.Content, Is.Not.Null);
    }
}