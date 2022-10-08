namespace GoalLessMeat.AppLogic.Responses
{
    public class BaseResponse
    {
        protected BaseResponse()
        {
            Success = true;
            ValidationErrors = new List<string>();
        }

        public bool Success { get; internal set; }
        public List<string> ValidationErrors { get; internal set; }
    }
}
