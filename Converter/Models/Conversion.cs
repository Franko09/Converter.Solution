using System.Collections.Generic;

namespace Converter.Models
{
    public interface IConversion
    {
        double Convert(Unit from, Unit To, double valueFrom);
    }
}
