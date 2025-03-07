/*
 * Matrimonial API - OpenAPI 3.0
 *
 * Design and definition of Matrimonial APIs created for practice and teaching
 *
 * OpenAPI spec version: 1.0.11
 * Contact: floatingrays@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using MatrimonialApi.Attributes;
using MatrimonialApi.Security;
using Microsoft.AspNetCore.Authorization;
using MatrimonialApi.Models;

namespace MatrimonialApi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class PersonApiController : ControllerBase
    { 
        /// <summary>
        /// Add a profile to the system
        /// </summary>
        /// <remarks>Add a profile to the system</remarks>
        /// <param name="body">Create a new Profile</param>
        /// <param name="xRequestAuth">Authorization token value</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid input</response>
        /// <response code="422">Validation exception</response>
        /// <response code="500">An error occured while processing the request.</response>
        /// <response code="0">Default error</response>
        [HttpPost]
        [Route("/api/person")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AddProfile")]
        [SwaggerResponse(statusCode: 200, type: typeof(AdminDTO), description: "Successful operation")]
        public virtual IActionResult AddProfile([FromBody]PersonDTO body, [FromHeader]string xRequestAuth)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CreateAdmin));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);
            string exampleJson = null;
            exampleJson = "{\n  \"accountLocked\" : false,\n  \"firstName\" : \"Ram\",\n  \"lastName\" : \"Sanatani\",\n  \"passwordResetDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"createdDateTime\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"middleName\" : \"kumar\",\n  \"emailId\" : \"Ram@gmail.com\",\n  \"isSuperAdmin\" : true,\n  \"isActive\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AdminDTO>(exampleJson)
                        : default(AdminDTO);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Delete a profile
        /// </summary>
        /// <remarks>Delete a profile</remarks>
        /// <param name="personId"></param>
        /// <param name="xRequestAuth">Authorization token value</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid input</response>
        /// <response code="422">Validation exception</response>
        /// <response code="500">An error occured while processing the request.</response>
        /// <response code="0">Default error</response>
        [HttpDelete]
        [Route("/api/person/{personId}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteProfie")]
        [SwaggerResponse(statusCode: 200, type: typeof(bool?), description: "Successful operation")]
        public virtual IActionResult DeleteProfie([FromRoute][Required]string personId, [FromHeader]string xRequestAuth)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(bool?));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);
            string exampleJson = null;
            exampleJson = "true";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<bool?>(exampleJson)
                        : default(bool?);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get a particular profile
        /// </summary>
        /// <remarks>Get a particular profile</remarks>
        /// <param name="personId"></param>
        /// <param name="xRequestAuth">Authorization token value</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid input</response>
        /// <response code="422">Validation exception</response>
        /// <response code="500">An error occured while processing the request.</response>
        /// <response code="0">Default error</response>
        [HttpGet]
        [Route("/api/person/{personId}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetProfile")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<PersonDTO>), description: "Successful operation")]
        public virtual IActionResult GetProfile([FromRoute][Required]string personId, [FromHeader]string xRequestAuth)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Person>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);
            string exampleJson = null;
            exampleJson = "[ {\n  \"lastName\" : \"Sanatani\",\n  \"Relative\" : [ {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  }, {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  } ],\n  \"address\" : {\n    \"country\" : \"country\",\n    \"city\" : \"city\",\n    \"street\" : \"street\",\n    \"postalCode\" : \"postalCode\",\n    \"state\" : \"state\"\n  },\n  \"gender\" : \"male\",\n  \"zodiacSign\" : \"Aries (Meṣa)\",\n  \"dateOfBirth\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"biodataURL\" : \"biodataURL\",\n  \"MatchPreferance\" : {\n    \"remark\" : \"remark\",\n    \"preferredChoice\" : \"preferredChoice\"\n  },\n  \"religion\" : \"Hindu\",\n  \"EducationalQualification\" : [ {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  }, {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  } ],\n  \"firstName\" : \"Ram\",\n  \"isGroom\" : false,\n  \"Occupation\" : {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  },\n  \"isBride\" : true,\n  \"imageURL\" : \"imageURL\",\n  \"contact\" : {\n    \"phoneNumber\" : \"phoneNumber\",\n    \"emailId\" : \"Ram@gmail.com\"\n  },\n  \"middleName\" : \"kumar\",\n  \"height\" : \"5 feet 6 inch\",\n  \"bodyComplexion\" : \"bodyComplexion\"\n}, {\n  \"lastName\" : \"Sanatani\",\n  \"Relative\" : [ {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  }, {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  } ],\n  \"address\" : {\n    \"country\" : \"country\",\n    \"city\" : \"city\",\n    \"street\" : \"street\",\n    \"postalCode\" : \"postalCode\",\n    \"state\" : \"state\"\n  },\n  \"gender\" : \"male\",\n  \"zodiacSign\" : \"Aries (Meṣa)\",\n  \"dateOfBirth\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"biodataURL\" : \"biodataURL\",\n  \"MatchPreferance\" : {\n    \"remark\" : \"remark\",\n    \"preferredChoice\" : \"preferredChoice\"\n  },\n  \"religion\" : \"Hindu\",\n  \"EducationalQualification\" : [ {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  }, {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  } ],\n  \"firstName\" : \"Ram\",\n  \"isGroom\" : false,\n  \"Occupation\" : {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  },\n  \"isBride\" : true,\n  \"imageURL\" : \"imageURL\",\n  \"contact\" : {\n    \"phoneNumber\" : \"phoneNumber\",\n    \"emailId\" : \"Ram@gmail.com\"\n  },\n  \"middleName\" : \"kumar\",\n  \"height\" : \"5 feet 6 inch\",\n  \"bodyComplexion\" : \"bodyComplexion\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<PersonDTO>>(exampleJson)
                        : default(List<PersonDTO>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get n profiles
        /// </summary>
        /// <remarks>Get n profiles page wise</remarks>
        /// <param name="xRequestAuth">Autorization</param>
        /// <param name="pageNumber"></param>
        /// <param name="range"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid input</response>
        /// <response code="422">Validation exception</response>
        /// <response code="500">An error occured while processing the request.</response>
        /// <response code="0">Default error</response>
        [HttpGet]
        [Route("/api/person")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetProfiles")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ShortProfileDTO>), description: "Successful operation")]
        public virtual IActionResult GetProfiles([FromHeader]string xRequestAuth, [FromQuery]int? pageNumber, [FromQuery]int? range)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ShortProfile>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);
            string exampleJson = null;
            exampleJson = "[ {\n  \"firstName\" : \"firstName\",\n  \"lastName\" : \"lastName\",\n  \"cityName\" : \"cityName\",\n  \"stateName\" : \"stateName\",\n  \"imageURL\" : \"imageURL\",\n  \"occupationName\" : \"occupationName\",\n  \"middleName\" : \"middleName\",\n  \"id\" : 0\n}, {\n  \"firstName\" : \"firstName\",\n  \"lastName\" : \"lastName\",\n  \"cityName\" : \"cityName\",\n  \"stateName\" : \"stateName\",\n  \"imageURL\" : \"imageURL\",\n  \"occupationName\" : \"occupationName\",\n  \"middleName\" : \"middleName\",\n  \"id\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ShortProfileDTO>>(exampleJson)
                        : default(List<ShortProfileDTO>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update a profile
        /// </summary>
        /// <remarks>Update a profile</remarks>
        /// <param name="body">Update a Profile</param>
        /// <param name="personId"></param>
        /// <param name="xRequestAuth">Authorization token value</param>
        /// <response code="200">Successful operation</response>
        /// <response code="400">Invalid input</response>
        /// <response code="422">Validation exception</response>
        /// <response code="500">An error occured while processing the request.</response>
        /// <response code="0">Default error</response>
        [HttpPut]
        [Route("/api/person/{personId}")]
        [ValidateModelState]
        [SwaggerOperation("PutProfile")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<PersonDTO>), description: "Successful operation")]
        public virtual IActionResult PutProfile([FromBody]PersonDTO body, [FromRoute][Required]string personId, [FromHeader]string xRequestAuth)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Person>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 422 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(422);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0);
            string exampleJson = null;
            exampleJson = "[ {\n  \"lastName\" : \"Sanatani\",\n  \"Relative\" : [ {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  }, {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  } ],\n  \"address\" : {\n    \"country\" : \"country\",\n    \"city\" : \"city\",\n    \"street\" : \"street\",\n    \"postalCode\" : \"postalCode\",\n    \"state\" : \"state\"\n  },\n  \"gender\" : \"male\",\n  \"zodiacSign\" : \"Aries (Meṣa)\",\n  \"dateOfBirth\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"biodataURL\" : \"biodataURL\",\n  \"MatchPreferance\" : {\n    \"remark\" : \"remark\",\n    \"preferredChoice\" : \"preferredChoice\"\n  },\n  \"religion\" : \"Hindu\",\n  \"EducationalQualification\" : [ {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  }, {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  } ],\n  \"firstName\" : \"Ram\",\n  \"isGroom\" : false,\n  \"Occupation\" : {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  },\n  \"isBride\" : true,\n  \"imageURL\" : \"imageURL\",\n  \"contact\" : {\n    \"phoneNumber\" : \"phoneNumber\",\n    \"emailId\" : \"Ram@gmail.com\"\n  },\n  \"middleName\" : \"kumar\",\n  \"height\" : \"5 feet 6 inch\",\n  \"bodyComplexion\" : \"bodyComplexion\"\n}, {\n  \"lastName\" : \"Sanatani\",\n  \"Relative\" : [ {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  }, {\n    \"name\" : \"name\",\n    \"remark\" : \"remark\",\n    \"relationship\" : \"relationship\"\n  } ],\n  \"address\" : {\n    \"country\" : \"country\",\n    \"city\" : \"city\",\n    \"street\" : \"street\",\n    \"postalCode\" : \"postalCode\",\n    \"state\" : \"state\"\n  },\n  \"gender\" : \"male\",\n  \"zodiacSign\" : \"Aries (Meṣa)\",\n  \"dateOfBirth\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"biodataURL\" : \"biodataURL\",\n  \"MatchPreferance\" : {\n    \"remark\" : \"remark\",\n    \"preferredChoice\" : \"preferredChoice\"\n  },\n  \"religion\" : \"Hindu\",\n  \"EducationalQualification\" : [ {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  }, {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  } ],\n  \"firstName\" : \"Ram\",\n  \"isGroom\" : false,\n  \"Occupation\" : {\n    \"name\" : \"name\",\n    \"description\" : \"description\"\n  },\n  \"isBride\" : true,\n  \"imageURL\" : \"imageURL\",\n  \"contact\" : {\n    \"phoneNumber\" : \"phoneNumber\",\n    \"emailId\" : \"Ram@gmail.com\"\n  },\n  \"middleName\" : \"kumar\",\n  \"height\" : \"5 feet 6 inch\",\n  \"bodyComplexion\" : \"bodyComplexion\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<PersonDTO>>(exampleJson)
                        : default(List<PersonDTO>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
