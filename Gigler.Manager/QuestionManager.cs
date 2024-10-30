using Gigler.Core.DTOs;

namespace Gigler.Manager
{
    public class QuestionManager : IManager
    {
        private readonly GiglerDBContext _giglerDBContext;

        public QuestionManager(GiglerDBContext giglerDBContext)
        {
            _giglerDBContext = giglerDBContext;
        }

        public List<QuestionDTO> GetRandom(int count = 5)
        {
            var listQuestionDto = new List<QuestionDTO>();

            var listQuestions = _giglerDBContext.Questions
                .OrderBy(r => Guid.NewGuid())
                .Take(count)
                .Select(x => new { x.Id })
                .ToList()
                .Select(x => x.Id);

            var listQuestionTitles = _giglerDBContext.QuestionTitles
                .Where(r => listQuestions.Contains(r.QuestionId))
                .OrderBy(r => Guid.NewGuid())
                .Select(x => new { x.Title, x.QuestionId })
                .ToArray();


            foreach (var question in listQuestions)
            {
                var objQuestionTitle = listQuestionTitles.Where(x => x.QuestionId == question).FirstOrDefault();

                listQuestionDto.Add(new QuestionDTO { id = question.ToString(), title = objQuestionTitle.Title });
            }

            return listQuestionDto;
        }

        public List<QuestionDTO> GetRandomV2(int count = 5)
        {
            var listQuestions = _giglerDBContext.Questions
                .Join(
                    _giglerDBContext.QuestionTitles,
                    question => question.Id,
                    questionTitle => questionTitle.QuestionId,
                    (question, questionTitle) => new
                    {
                        id = question.Guid,
                        title = questionTitle.Title,
                    }
                )
                .OrderBy(r => Guid.NewGuid())
                .Take(count)
                .ToList();

            return listQuestions.Select(x => new QuestionDTO() { id=x.id, title=x.title}).ToList();
        }
    }
}
