﻿using TravelsFreak.Models.DataTransferObject;

namespace TravelsFreak.Repository.IRepository
{
    public interface IBlogRepository
    {
        public Task<BlogDTO> Create(BlogDTO objectDTO);
        public Task<BlogDTO> Update(BlogDTO objectDTO);
        public Task<int> Delete(int id);
        public Task<BlogDTO> Get(int id);
        public Task<IEnumerable<BlogDTO>> GetAll();
    }
}
