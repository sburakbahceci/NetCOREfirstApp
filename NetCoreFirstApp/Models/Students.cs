namespace NetCoreFirstApp.Models{
    public class Students{
        public int Number{ get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Classroom { get; set; }

        public Students(int number,string name,string surname,int classroom){
            this.Number = number;
            this.Name = name;
            this.Surname = surname;
            this.Classroom = classroom;
        }
    }
}