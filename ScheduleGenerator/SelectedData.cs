namespace ScheduleGenerator
{
    class SelectedData_Subject
    {
           public string Name { get; private set; } 
           public bool Class { get; private set; }
           public int Count { get; private set; }

        public SelectedData_Subject(string Named, bool Practic, int Counts) 
        { Name = Named; Class = Practic; Count = Counts; }

        public void CountReduce() => Count -= 2;
    }
}
