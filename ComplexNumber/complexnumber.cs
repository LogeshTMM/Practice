namespace complexNumber;
public class ComplexNumber {
   public string Addition (double aReal, double aImg, double bReal, double bImg) {
      double realAdd = aReal + bReal, imgAdd = aImg + bImg;
      return $"{realAdd} + {imgAdd}i";
   }

   public string Subraction (double aReal, double aImg, double bReal, double bImg) {
      double realSub = aReal - bReal, imgSub = aImg - bImg;
      return $"{realSub} - ({imgSub}i)";
   }

   public double Magnitude (double aReal, double aimg) {
      double result = Math.Pow (aReal, 2) + Math.Pow (aimg, 2);
      return Math.Sqrt (result);
   }

}