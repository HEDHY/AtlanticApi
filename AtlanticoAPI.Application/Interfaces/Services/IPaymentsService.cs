using Atlantico.Business.Model;
using AtlanticoAPI.Application.DTOs.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AtlanticoAPI.Application.Interfaces.Services
{
    public interface IPaymentsService
    {
        Task<PaymentResponseDTO> Pay(List<Payment> payments);
    }
}
