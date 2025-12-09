using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos.Product;
using ApiEcommerce.Repository.IRepository;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace ApiEcommerce.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetProducts()
        {
            var products = _productRepository.GetProducts();
            var productsDto = products.Adapt<List<ProductDto>>();

            return Ok(productsDto);
        }

        [HttpGet("{productId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProduct(int productId)
        {
            var product = _productRepository.GetProduct(productId);
            if (product == null)
            {
                return NotFound($"The product with the id {productId} does not exist");
            }

            var productDto = product.Adapt<ProductDto>();
            return Ok(productDto);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            if (createProductDto == null)
            {
                return BadRequest(ModelState);
            }

            if (_productRepository.ProductExists(createProductDto.Name))
            {
                ModelState.AddModelError("CustomError", "The product already exists");
            }

            if (!_categoryRepository.CategoryExists(createProductDto.Name))
            {
                ModelState.AddModelError("CustomError", $"The category with id {createProductDto.CategoryId} exists");
            }

            var product = createProductDto.Adapt<Product>();
            if (!_productRepository.CreatedProduct(product))
            {
                ModelState.AddModelError("CustomError", $"Something went wrong while saving the record {product.Name}");
            }

            return CreatedAtRoute("GetProduct", new {productId = product.ProductId}, product);
        }
    }
}
