namespace ChatGpt.Integration.Services
{
    public interface IAnswerGeneratorService
    {
        Task<string> GeneratorAnswer(string prompt);
    }
}
