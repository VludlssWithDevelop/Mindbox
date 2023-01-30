namespace ShapeLib.Console.Entities
{
    /// <summary>
    /// Сущность категории
    /// </summary>
    public class CategoryEntity
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование категории
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Продукты категории
        /// </summary>
        public List<CategoryProductEntity> Products { get; set; } = new();
    }
}
