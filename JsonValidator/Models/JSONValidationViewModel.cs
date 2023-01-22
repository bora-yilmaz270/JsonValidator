namespace JsonValidator.Models
{
    public class JSONValidationViewModel
    {
        public string JSONString { get; set; }
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
    }
}
