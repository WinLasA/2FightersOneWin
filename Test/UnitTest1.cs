using _2FightersOneWin;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Fighter_ShouldHaveValidInput_ShouldReturnCompleteFighter()
    {
        var result = new Fighter("Lars", 10, 1);

        Assert.Equal("Lars", result.Name);
        Assert.Equal(10, result.Health);
        Assert.Equal(1, result.DamagePerAttack);
    }

    [Fact]
    public void Kata_2FightersWithNoHealth_ShouldReturnNoWinner()
    {
        Fighter a = new("Lars", 0, 2);
        Fighter b = new("Anna", 0, 5);

        var result = Kata.Declare_winner(a, b, "Lars");

        Assert.Equal(result, "No winner");
    }



}