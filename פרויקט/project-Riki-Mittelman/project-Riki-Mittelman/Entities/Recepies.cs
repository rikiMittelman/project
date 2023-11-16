namespace project_Riki_Mittelman.Entities
{
    public class Recepies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsAviable { get; set; }
        public int Amount { get; set; }
        public string[] ProductArr { get; set; }

    }
}
