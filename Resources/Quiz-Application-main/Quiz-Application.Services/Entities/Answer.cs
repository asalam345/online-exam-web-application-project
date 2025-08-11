using System.ComponentModel.DataAnnotations;

namespace Quiz_Application.Services.Entities
{
    public class Answer : BaseEntity
    {
        [Key]
        public int Sl_No { get; set; }
        public int QuestionID { get; set; }
        public int ChoiceID { get; set; }
        public string DisplayText { get; set; }
    }
}
