﻿//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Services.Core.NotUsed;
//using Swashbuckle.AspNetCore.Annotations;

//namespace IMS.Controllers.NotUsed;
//[Route("api/[controller]")]
//[ApiController]
//[Authorize(AuthenticationSchemes = "Bearer")]
//public class CompanyTypeController : ControllerBase
//{
//    private readonly ICompanyTypeService _companyTypeService;

//    public CompanyTypeController(ICompanyTypeService companyTypeService)
//    {
//        _companyTypeService = companyTypeService;
//    }

//    [HttpGet]
//    [SwaggerOperation(Summary = "Get all company type")]
//    public async Task<ActionResult> Get()
//    {
//        var result = await _companyTypeService.Get();
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpGet("{id}")]
//    public async Task<ActionResult> GetDetail(int id)
//    {
//        var result = await _companyTypeService.GetDetail(id);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }
//}