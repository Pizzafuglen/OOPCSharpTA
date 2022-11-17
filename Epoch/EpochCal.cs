namespace Epoch;

public class EpochCal
{
    private double secSince1970;

    public EpochCal(double secSince1970)
    {
        this.secSince1970 = secSince1970;
    }

    public double calcWholeDays()
    {
        double yearDecimal = 0;
        double yearDayDecimal = 0;
        double yearModulus = this.secSince1970 % 31556926;

        if (yearModulus == 0)
        {
            yearDecimal = this.secSince1970 / 31556926;
        }
        else
        {
            yearDayDecimal = (this.secSince1970 / 31556926) - yearModulus;
            yearDecimal = yearDayDecimal + (yearModulus / 86400);
        }

        return yearDecimal;
    }
}