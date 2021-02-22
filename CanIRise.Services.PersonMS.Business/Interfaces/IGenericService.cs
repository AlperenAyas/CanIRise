using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Interfaces
{
    public interface IGenericService<ListDto,AddDto,UpdateDto>
        where ListDto : class,IListDto,new()
        where AddDto : class,ICreateDto,new()
        where UpdateDto :class,IUpdateDto,new()
    {
        List<ListDto> GetAll();
        ListDto GetById(Guid id);
        AddDto Create(AddDto dto);
        void Update(UpdateDto dto);
        void Remove(Guid id);
    }
}
