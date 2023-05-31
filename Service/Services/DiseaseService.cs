using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class DiseaseService : Service<Disease>, IDiseaseService
    {
        private IDiseaseRepository _diseaseRepository;
        private IMapper _mapper;
        public DiseaseService(
                IRepository<Disease> repository,
                IUnitOfWork unitOfWork,
                IDiseaseRepository diseaseRepository,
                IMapper mapper
            ) : base(repository, unitOfWork)
        {
            _diseaseRepository = diseaseRepository;
            _mapper = mapper;
        }

        public IQueryable<Disease> GetAllWithIndividuals()
        {
            return _diseaseRepository.GetAllWithIndividuals();
        }

        public IQueryable<Disease> GetAllWithProducts()
        {
            return _diseaseRepository.GetAllWithProducts();
        }

        public async Task<Response<DiseaseWithIndividualDto>> GetWithIndividualsByIdAsync(int id)
        {
            return new Response<DiseaseWithIndividualDto>(
                _mapper.Map<DiseaseWithIndividualDto>(
                    await _diseaseRepository.GetWithIndividualsByIdAsync(id)
                    )
                );
        }

        public async Task<Response<DiseaseWithProductsDto>> GetWithProductsByIdAsync(int id)
        {
            return new Response<DiseaseWithProductsDto>(
                _mapper.Map<DiseaseWithProductsDto>(
                    await _diseaseRepository.GetWithProductsByIdAsync(id)
                    )
                );
        }
    }
}
