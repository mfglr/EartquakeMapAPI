
using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class IndividualService : UserService<Individual>, IIndividualService
    {
        private IIndividualRepository _individualRepository;
        private IMapper _mapper;
        public IndividualService(
                IRepository<Individual> repository,
                IUnitOfWork unitOfWork,
                IUserRepository<Individual> userRepository,
                IIndividualRepository individualRepository,
                IMapper mapper
            ) : base(repository, unitOfWork, userRepository)
        {
            _individualRepository = individualRepository;
            _mapper = mapper;
        }

        public IQueryable<Individual> GetAllWithDiseases()
        {
            return _individualRepository.GetAllWithDiseases();
        }

        public async Task<Response<IndividualWithDiseasesDto>> GetWithDiseasesByIdAsync(int id)
        {
            return new Response<IndividualWithDiseasesDto>(
                _mapper.Map<IndividualWithDiseasesDto>(
                    await _individualRepository.GetWithDiseasesByIdAsync(id)
                    )
                );
        }
    }
}
