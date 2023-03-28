namespace GoalSetter
{
    public class EternalGoal : Goal
    {

        public EternalGoal(string name, string desc, int points)
            : base(name, desc, points)
        {
           
           
        }

 

        public override void RecordProgress()
        {
            _complete
        }

        public override bool IsComplete()
        {
            return _complete;
        }

        public override string ToString()
        {
            // TODO: this is cruddy, make a better goal string
            return $"The goal is complete: {_complete}";
        }
    }