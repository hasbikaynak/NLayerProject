﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayerProject.Core.Services;
using NLayerProject.Web.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NLayerProject.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<ProductDTO>>(products));
        }
    }
}