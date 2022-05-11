using CustomPagingGrid.Api.Models;
using CustomPagingGrid.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomPagingGrid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        List<Products> products = new List<Products>
        {
            new Products
            {
                Name="Lap Top",
                Quantity=43,
                Price=500
            },
            new Products
            {
                Name="TV",
                Quantity=20,
                Price=1000
            },
            new Products
            {
                Name="Phone",
                Quantity=100,
                Price=200
            },
            new Products
            {
                Name="Watch",
                Quantity=1000,
                Price=50
            },
        };


        [HttpGet("data")]
        public async Task<IActionResult> GetDataEnvelop([FromQuery] int pageSize, [FromQuery] int pageNumber)
        {
            var data = new DataEnvelop
            {
                OdataContext = "",
                OdataCount = GetValues.Count,
                Value = GetValues.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList()
            };
            return Ok(data);
        }

        [HttpGet("get-data")]
        public async Task<IActionResult> GetDataFromQuery([FromQuery] QueryParameter query)
        {
            DataEnvelop data = new DataEnvelop();
            switch (query.OrderBy)
            {
                case nameof(OValue.UserName):
                    data = new DataEnvelop
                    {
                        OdataContext = "",
                        OdataCount = GetValues.Count,
                        Value = GetValues
                       .OrderBy(x => x.UserName)
                       .Skip(query.Skip * (query.Top - 1)).
                       Take(query.Top).ToList()
                    };
                    break;
                case nameof(OValue.FirstName):
                    data = new DataEnvelop
                    {
                        OdataContext = "",
                        OdataCount = GetValues.Count,
                        Value = GetValues
                       .OrderBy(x => x.FirstName)
                       .Skip(query.Skip * (query.Top - 1)).
                       Take(query.Top).ToList()
                    };
                    break;
                case nameof(OValue.LastName):
                    data = new DataEnvelop
                    {
                        OdataContext = "",
                        OdataCount = GetValues.Count,
                        Value = GetValues
                       .OrderBy(x => x.LastName)
                       .Skip(query.Skip * (query.Top - 1)).
                       Take(query.Top).ToList()
                    };
                    break;
                case nameof(OValue.MiddleName):
                    data = new DataEnvelop
                    {
                        OdataContext = "",
                        OdataCount = GetValues.Count,
                        Value = GetValues
                       .OrderBy(x => x.MiddleName)
                       .Skip(query.Skip * (query.Top - 1)).
                       Take(query.Top).ToList()
                    };
                    break;
                case nameof(OValue.Age):
                    data = new DataEnvelop
                    {
                        OdataContext = "",
                        OdataCount = GetValues.Count,
                        Value = GetValues
                       .OrderBy(x => x.Age)
                       .Skip(query.Skip * (query.Top - 1)).
                       Take(query.Top).ToList()
                    };
                    break;
                case nameof(OValue.Gender):
                    data = new DataEnvelop
                    {
                        OdataContext = "",
                        OdataCount = GetValues.Count,
                        Value = GetValues
                       .OrderBy(x => x.Gender)
                       .Skip(query.Skip * (query.Top - 1)).
                       Take(query.Top).ToList()
                    };
                    break;
                default:
                    data = new DataEnvelop
                    {
                        OdataContext = "",
                        OdataCount = GetValues.Count,
                        Value = GetValues
                                .Skip(query.Skip * (query.Top - 1)).
                                Take(query.Top).ToList()
                    };
                    break;

            }
            return Ok(data);
        }

        [HttpGet("get-products")]
        public async Task<IActionResult> GetProductsAsync()
        {
            return Ok(products);
        }
    }
}
