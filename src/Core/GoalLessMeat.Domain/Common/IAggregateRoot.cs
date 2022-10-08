using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalLessMeat.Domain.Common
{
    public interface IAggregateRoot
    {
        public Guid Id { get; set; }
    }
}
