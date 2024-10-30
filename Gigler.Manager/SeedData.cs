using Gigler.Core.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gigler.Manager;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new GiglerDBContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<GiglerDBContext>>()))
        {

            if (context.Questions.Any())
            {
                return;   // DB has been seeded
            }
            context.Questions.AddRange(
                new Question
                {
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    Type = 1
                },
                new Question
                {
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    Type = 1
                },
                new Question
                {
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    Type = 1
                },
                new Question
                {
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    Type = 1
                },
                new Question
                {
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    Type = 1
                },
                new Question
                {
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    Type = 1
                },
                new Question
                {
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    Type = 1
                }
            );
            context.QuestionTitles.AddRange(
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "How are you feeling today?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 1,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "How are you today?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 1,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "What is your interest?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 2,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "What are your hobbies?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 2,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "Which is your birthplace?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 3,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "Where were you born?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 3,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "What are you doing this weekend?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 4,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "Any plans for the weekend?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 4,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "How old are you?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 5,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "What is your age?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 5,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "Tell me something about yourself!",
                    CreatedAt = DateTime.Now,
                    QuestionId = 6,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "Can you brief me about yourself!",
                    CreatedAt = DateTime.Now,
                    QuestionId = 6,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "What is your Name?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 7,
                },
                new QuestionTitle
                {
                    Guid = Guid.NewGuid().ToString(),
                    Title = "May I know your Good Name?",
                    CreatedAt = DateTime.Now,
                    QuestionId = 7,
                }
            );
            context.SaveChanges();
        }
    }
}