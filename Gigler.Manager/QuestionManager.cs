using Gigler.Core.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gigler.Manager
{
    public class QuestionManager: IManager
    {
        private readonly GiglerDBContext _giglerDBContext;

        public QuestionManager(GiglerDBContext giglerDBContext)
        {
            _giglerDBContext = giglerDBContext;
        }

        public IEnumerable<Question> GetAll()
        {
            return _giglerDBContext.Questions.ToList();
        }
    }
}
