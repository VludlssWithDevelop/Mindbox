namespace ShapeLib.Console.Entities
{
    /// <summary>
    /// Сущность продукта
    /// </summary>
    public class ProductEntity
    {
        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование продукта
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Категории продукта
        /// </summary>
        public List<CategoryProductEntity> Categories { get; set; } = new();
    }
}
