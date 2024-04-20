﻿using MyApplication.Entities;
using MyApplication.Services;

Product product = new Product();
product.Name = "Klavye";
product.UnitPrice = 50;
product.Id = 1;

BaseProductService productService = new ProductService();
productService.AddProductWithLogging(product);