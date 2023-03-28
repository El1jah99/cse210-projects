namespace GoalSetter
{

    public class InMemoryRepository : Repository
    {

        private List<Goal> _goals = new List<Goal>();

        public override Add(Goal goal)
        {
            
        }

        public override List<Goal> GetAll()
        {
            throw new Exception("Not implemented in base class.");
        }

        public override Remove(Goal goal)
        {
            throw new Exception("Not implemented in base class.");
        }






    }
}