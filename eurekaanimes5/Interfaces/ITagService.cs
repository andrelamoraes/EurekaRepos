using System.Collections.Generic;
using eurekaanimes5.Models;

namespace eurekaanimes5.Interfaces
{
    public interface ITagService
    {
        void cadastrar(Tags tag);

        List<Tags> listartags();

        void delete(int TagID);

    }
}