namespace QuizCounter.Model;

public class CounterModel
{
    public Guid Id { get; } = Guid.NewGuid();

    public int Correct { get; set; } = 0;

    public int Worng { get; set; } = 0;

    public int Score { get; set; } = 0;

    public void Reset()
    {
        Score = 0;
        Correct = 0;
        Worng = 0;
    }
}