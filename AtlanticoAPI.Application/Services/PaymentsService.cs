using Atlantico.Business.Model;
using AtlanticoAPI.Application.DTOs.Payments;
using AtlanticoAPI.Application.Interfaces;
using AtlanticoAPI.Application.Interfaces.ExtServices.Conversions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticoAPI.Application.Services
{
    public class PaymentsService : Interfaces.Services.IPaymentsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConversionService _conversionService;


        public PaymentsService(IUnitOfWork unitOfWork, IConversionService conversionService)
        {
            _unitOfWork = unitOfWork;
            _conversionService = conversionService;
        }


        public async Task<PaymentResponseDTO> Pay(List<Payment> payments)
        {

            double totalValue = 0;

            foreach (Payment paymentType in payments)
            {
                if (paymentType.Currency != "EUR")
                {
                    double rate= _conversionService.GetRate(paymentType.Currency)
                }
            }

            var result = await _unitOfWork.Courses.GetAllAsync();

            if (result != null)
                return ResultMessage<IEnumerable<Course>>.Success("OK", result);
            else

                return ResultMessage<IEnumerable<Course>>.
                    Failure(new string[] { ErrorCodes.ServiceError.ToString() }, result);

        }

    }
}
