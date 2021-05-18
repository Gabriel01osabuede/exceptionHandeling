namespace week6
{   public class StudentB : Marks
    {
        double Score1 ;
        double Score2;
        double Score3;
        double Score4;

        public StudentB(double FirstScore,double SecondScore,double ThirdScore,double ForthScore)
        {
              this.Score1 = FirstScore;
            this.Score2 = SecondScore;
            this.Score3 = ThirdScore;
            this.Score4 = ForthScore;
        }
        public override double getPercentage()
        {
            //(TotalNumber of Marks) (divided) by (number of subjects * overAll Marks) (Multiplied by 100 (percent))
            double calculatePercentage = (Score1 + Score2 + Score3 + Score4 ) /(4 * 100) * 100;
            return calculatePercentage;
        }
    }
}