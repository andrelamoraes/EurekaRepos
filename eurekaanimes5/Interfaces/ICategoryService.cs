using System.Collections.Generic;

namespace eurekaanimes5.Interfaces
{
    public interface ICategoryService
    {
        void cadastrar(Categories category);

        List<Categories> listarcategoria();

        void deletar(int CategoryID);
    }
}