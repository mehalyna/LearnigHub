namespace StudentLearningHub.Models;

public sealed record Course(
    int Id,
    string Title,
    string Description,
    int DurationWeeks);
