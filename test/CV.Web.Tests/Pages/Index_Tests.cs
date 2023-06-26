using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CV.Pages;

public class Index_Tests : CVWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
