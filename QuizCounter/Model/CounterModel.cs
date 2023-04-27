namespace QuizCounter.Model;

public class CounterModel
{
    public Guid Id { get; } = Guid.NewGuid();

    public int Correct { get; set; } = 0;

    public int Worng { get; set; } = 0;

    public int Score { get; set; } = 0;

    public Stack<(int correct, int worng, int score)> UndoStack = new Stack<(int, int, int)>();

    public virtual void PushUndoStack()
    {
        UndoStack.Push((Correct, Worng, Score));
    }

    public void Undo()
    {
        if (UndoStack.TryPop(out (int correct, int worng, int score) previousPoint))
        {
            Correct = previousPoint.correct;
            Worng = previousPoint.worng;
            Score = previousPoint.score;
        }
    }

    public void Reset()
    {
        Score = 0;
        Correct = 0;
        Worng = 0;
        UndoStack.Clear();
    }
}