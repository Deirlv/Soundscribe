namespace Soundscribe.DAL.Entities
{
    public class Question
    { 
        public string? QuestionPath {  get; set; }

        public string? Answer { get; set; }
    }

    public class Test
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<Question>? Questions {  get; set; }
    }
}
