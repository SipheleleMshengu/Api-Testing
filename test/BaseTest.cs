using RestSharp;

namespace test;

public class BaseTest
{
    protected RestClient client;

    [SetUp]
    public void Initialise()
    {
        client = new RestClient(" http://openlibrary.org/");
    }
}