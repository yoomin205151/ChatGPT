using OpenAI_API;
using OpenAI_API.Completions;

namespace ChatGpt.Integration.Services
{
    public class AnswerGeneratorService : IAnswerGeneratorService
    {
        public async Task<string> GeneratorAnswer(string prompt)
        {
            string apiKey = "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";
            string answer = string.Empty;

            var openai = new OpenAIAPI(apiKey);
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt = prompt;
            completion.MaxTokens = 4000;

            var result = await openai.Completions.CreateCompletionAsync(completion);
            if (result != null)
            {
                foreach (var item in result.Completions)
                {
                    answer = item.Text;
                }
            }

            return answer;
        }
    }
}
