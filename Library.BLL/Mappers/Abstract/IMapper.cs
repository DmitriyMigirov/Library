namespace Library.BLL.Mappers.Abstract
{
    public interface IMapper<TEntity, TModel>
    {
        TEntity Map(TModel from);
        TModel Map(TEntity from);
    }
}
