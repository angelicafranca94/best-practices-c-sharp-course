using Avanade.BestPractices.Domain.Entities;
using Avanade.BestPractices.Domain.Entities.Exceptions;
using Avanade.BestPractices.Domain.Interfaces.Repositories;
using Avanade.BestPractices.Domain.Interfaces.Services;
using Avanade.BestPractices.Domain.QueryContext;
using Avanade.BestPractices.Infrestructure.Core.Extensions;
using Avanade.BestPractices.Service.Core;
using Avanade.BestPractices.Service.Validators;
using FluentValidation;
using System;
using System.Threading.Tasks;

namespace Avanade.BestPractices.Service
{
    public class VehicleService : ServiceBase<Vehicle>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public Task<Vehicle> GetByIdAsync(Guid id, int queryContext = default)
        {
            return _vehicleRepository.GetByIdAsync(id, queryContext);
        }

        public async Task SetIsAvailableAsync(Guid vehicleId, bool isAvailable)
        {
            var vehicle = await GetByIdAsync(vehicleId, VehicleQueryContext.GetById.SetIsAvailable.ToInt());
            if (vehicle is null)
                throw new NullReferenceException(VehicleErrorCode.V001.Code);

            vehicle.IsAvailable = isAvailable;

            var validator = new VehicleValidator();
            await validator.ValidateAndThrowAsync(vehicle);

            _vehicleRepository.Update(vehicle);
            await _vehicleRepository.SaveChangesAsync();
        }
    }
}
