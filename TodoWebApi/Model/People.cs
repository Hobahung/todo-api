using System.Collections.Generic;

namespace TodoWebApi.Model
{
    public class People
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public People()
        {
            
        }
        
        public People(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}