namespace GoalSetter
{
    public class SimpleGoal : Goal
    {

        public SimpleGoal(string name, string desc, int points)
            :base(name,desc,points)
        {

            
        }

        public override void RecordProgress()
        {
            _complete = true;

            MarkComplete();
        }

        public override string ToString()
        {
            String s = "";
            s += $"name: {GetName()}\n";
            s += $"desc: {GetDesc()}\n";
            s += $"points: {GetPoints()}\n";
            s += $"earned: {GetPointsEarned()}\n";
            s += $"name: {GetName()}\n";


            return $"The goal is complete: {IsComplete()}";
        }
    }
}