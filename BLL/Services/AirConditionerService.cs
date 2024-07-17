using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories;

namespace BLL.Services
{
    public class AirConditionerService
    {
        AirConditionerRepository _repository = new();

        public List<AirConditioner> GetAllAirConditioners() { return _repository.GetAll(); }

        public List<AirConditioner> SearchlAirConditionersByFeatureFunctionOrQuantity(string featureFunction, int? quantity)
        {
            var list = _repository.GetAll().Where(a => a.FeatureFunction.ToLower().Contains(featureFunction.ToLower()) || a.Quantity == quantity).ToList();
            return list;
        }
    }
}
