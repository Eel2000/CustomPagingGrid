using CustomPagingGrid.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomPagingGrid.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        List<OValue> GetValues = new List<OValue>
        {
            new OValue
            {
                FirstName ="michaella",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="lucas",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Paul",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Angel",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Turbo",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Gil",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Fink",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Pinch",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Lucas",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Agrito",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Lua",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="LUna",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Ten",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Ken",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Kenny",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Kent",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Superman",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Batman",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Lucas",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Amelia",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Jordan",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Poole",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="John",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Doe",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Fi",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Lucia",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Guard",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new OValue
            {
                FirstName ="Toe",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            },
        };


        [HttpGet("data")]
        public async Task<IActionResult> GetDataEnvelop([FromQuery] int pageSize, [FromQuery] int pageNumber)
        {
            var data = new DataEnvelop
            {
                OdataContext = "Context",
                OdataCount = GetValues.Count,
                Value = GetValues.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList()
            };
            return Ok(data);
        }
    }
}
