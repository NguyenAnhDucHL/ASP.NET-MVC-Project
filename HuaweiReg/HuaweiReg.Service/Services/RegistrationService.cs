using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HuaweiReg.Data.Models;
using HuaweiReg.Data.UnitOfWork;
using HuaweiReg.Service.IServices;
using HuaweiReg.Service.ServiceModels;

namespace HuaweiReg.Service.Services
{
    public class RegistrationService: IRegistrationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RegistrationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<RegistrationModel>> GetAllRegistrations()
        {
            var registrations = (await _unitOfWork.RegistrationRepository.GetAllAsync()).ToList();
            //Need mapper to RegistrationModel
            
            return new List<RegistrationModel>();

        }

        public async Task AddRegistrationAsync(RegistrationModel model)
        {
            try
            {
                var registrationDto = _mapper.Map<Registration>(model);
                var addedItem = await _unitOfWork.RegistrationRepository.AddAsync(registrationDto);
                if(addedItem == null)
                    throw new InvalidOperationException("Create registration failed");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
