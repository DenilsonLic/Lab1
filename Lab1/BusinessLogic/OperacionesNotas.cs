using Lab1.Models;
using Lab1.Services;

namespace Lab1.BusinessLogic
{
    public class OperacionesNotas : IoperacionesNotas
    {
        public double PorcLab(ActionNotas action)
        {
            throw new NotImplementedException();
        }

        public double PorcPar(ActionNotas action)
        {
            throw new NotImplementedException();
        }

        public double Prom(ActionNotas action)
        {
            throw new NotImplementedException();
        }

        public double SumaLab(ActionNotas action)
        {
            return action.Lab1 + action.Lab2 + action.Lab3;
        }

        public double SumaPar(ActionNotas action)
        {
            return action.Par1 + action.Par2 + action.Par3;
        }

        public double TotalLab(ActionNotas action)
        {
            throw new NotImplementedException();
        }

        public double TotalParc(ActionNotas action)
        {
            throw new NotImplementedException();
        }
    }
}