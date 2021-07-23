namespace JasonJT_Web.Models
{
    public class Contact
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public Sex Sex { get; set; }
        public string Text { get; set; }

    }

    public enum Sex
    {
        gay,
        bi,
        bi_more_male,
        bi_more_female,
        hetero,
        pan,
        other,
        unknown

    }

}