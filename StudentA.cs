namespace week6
{
   public class StudentA : Marks
    {
        double Score1 ;
        double Score2;
        double Score3;

        public StudentA(double FirstScore,double SecondScore,double ThirdScore)
        {
            this.Score1 = FirstScore;
            this.Score2 = SecondScore;
            this.Score3 = ThirdScore;
        }
        public override double getPercentage()
        {
            //(TotalNumber of Marks) (divided) by (number of subjects * overAll Marks) (Multiplied by 100 (percent))
            double calculatePercentage = (Score1 + Score2 + Score3 ) /(3 * 100) * 100;
            return calculatePercentage;  
        }
    }
}