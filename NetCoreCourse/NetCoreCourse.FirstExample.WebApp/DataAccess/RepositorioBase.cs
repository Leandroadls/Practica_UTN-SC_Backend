namespace NetCoreCourse.FirstExample.WebApp.DataAccess
{
    public class RepositorioBase<TEntidad>
        where TEntidad : EntidadBase
    {
        public string Add(TEntidad entity)
        {
            return $"La entidad con Id {entity.Id} fue agregada";
        }
        public TEntidad ModifyDescription(TEntidad entity, string newDescription)
        {
            entity.Descripcion = newDescription;
            return entity;
        }


    }
}
