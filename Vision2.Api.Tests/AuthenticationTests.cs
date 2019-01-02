using NUnit.Framework;
using Vision2.Api;
using System.Threading.Tasks;
using Shouldly;

namespace Vision2.Api.Tests {
    [TestFixture]
    public class AuthenticationTests {
        private Vision2Options _options;

        [SetUp]
        public void Setup() {
            _options = new Vision2Options {
                IsStaging = true,
                TenantCode = ""
            };
        }

        [Test]
        public async Task integration_authentication_login_with_creds() {
           var token = await Vision2Client.RequestAccessTokenAsync(_options, "", "");
            token.Data.ShouldNotBe(null);
            token.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
        }
    }
}
