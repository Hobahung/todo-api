namespace TodoWebApi.Model
{
    public class Todo
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int Status { get; set; }

        public People People { get; set; }

        public Todo()
        {
            
        }
        
        public Todo(int id, string name, int status, People people)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.People = people;
        }
    }
}