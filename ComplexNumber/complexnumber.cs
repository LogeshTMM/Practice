namespace complexNumber;
public class ComplexNumber {
   // First complex number syntax based on method parameters: aReal + aImg
   // Second complex number syntax based on method parameters: bReal + bImg

   // The user provides four parameter values for the addition operation between two complex numbers.
   public string Addition (double aReal, double aImg, double bReal, double bImg)
      => $"{aReal + bReal} + {aImg + bImg}i";

   // The user provides four parameter values for the subtraction operation between two complex numbers.
   public string Subraction (double aReal, double aImg, double bReal, double bImg)
      => $"{aReal - bReal} - ({aImg - bImg}i)";

   // It performs a magnitude operation on a single complex number.
   public double Magnitude (double aReal, double aimg)
      => Math.Sqrt (Math.Pow (aReal, 2) + Math.Pow (aimg, 2));
}