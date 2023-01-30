namespace ShapeLib.Console.Entities
{
    public class CategoryProductEntity
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
