namespace WinFormsApp2
{
    public class Todo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Done { get; set; }

        public override string ToString()
        {
            //return $"{Text} - {DueDate}";
            return $"{Text} - {DueDate?.ToString("F")}";
        }
    }
}
