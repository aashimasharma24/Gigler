using Gigler.Core.DataObjects;
using Gigler.Core.DTOs;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gigler.Manager
{
    public class QuestionManager : IManager
    {
        private readonly GiglerDBContext _giglerDBContext;

        public QuestionManager(GiglerDBContext giglerDBContext)
        {
            _giglerDBContext = giglerDBContext;
        }

        public List<QuestionDTO> GetAll()
        {
            var list = new List<QuestionDTO>();

            var ids = _giglerDBContext.Questions
                .OrderBy(r => Guid.NewGuid())
                .Take(5)
                .Select(x => new { x.Id })
                .ToList()
                .Select(x => x.Id);

            var titles = _giglerDBContext.QuestionTitles
                .Where(r => ids.Contains(r.QuestionId))
                .OrderBy(r => Guid.NewGuid())
                .Select(x => new { x.Title, x.QuestionId })
                .ToArray();


            foreach (var id in ids)
            {
                var title = titles.Where(x => x.QuestionId == id).FirstOrDefault();

                list.Add(new QuestionDTO { Guid = id.ToString(), Title = title.Title });
            }

            return list;
        }
    }
}
