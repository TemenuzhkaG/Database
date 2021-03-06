

using Quiz.Services.Models.Input;

namespace Quiz.Services.Interfaces
{
  public  interface IUserAnswerService
    {
        void AddUserAnswer(string userId, int quizId, int questionId, int answerId);
        void BulkAddUserAnswer(QuizInputModel quizInputModel);
        int GetUserResult(string userId, int quizId);
    }
}
