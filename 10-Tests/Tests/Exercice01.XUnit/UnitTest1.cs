using Exercice01.Classes;

namespace Exercice01.XUnit;

public class UnitTest1
{
    [Theory]
    [InlineData(95, 90, 'A')]
    [InlineData(85, 90, 'B')]
    [InlineData(65, 90, 'C')]
    [InlineData(95, 65, 'B')]
    [InlineData(95, 55, 'F')]
    [InlineData(65, 55, 'F')]
    [InlineData(50, 90, 'F')]
    public void GetGrade_ShouldReturnNote(int score, int attendance, char note)
    {
        var calculator = new GradingCalculator
        {
            Score = score,
            AttendancePercentage = attendance
        };

        var result = calculator.GetGrade();

        Assert.Equal(note, result);
    }
}