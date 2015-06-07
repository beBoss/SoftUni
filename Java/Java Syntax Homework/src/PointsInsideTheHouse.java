/**
 * Created by beBoss on 7.6.2015
 *
 * Write a program to check whether a point is inside or outside the house below.
 * The point is given as a pair of floating-point numbers, separated by a space.
 * Your program should print "Inside" or "Outside". Examples:
 * Input        Output          Input           Output
 * 10 9.7       Outside         17.60 8.50      Inside
 * 11.6 7       Outside         17.72 9.12      Outside
 * 12.5 6       Outside         18.6 3.9        Outside
 * 12.5 14.5    Outside         18.6 6          Inside
 * 13.13 9.15   Inside          19.693 13.4     Outside
 * 13.5 6.9     Outside         20 6            Inside
 * 15 6         Inside          21 7.5          Inside
 * 15.02 4.83   Outside         21 13.5         Inside
 * 15.11 7.01   Inside          21.3 5.5        Outside
 * 16.33 14.03  Outside         21.45 9.7       Inside
 * 16.4 5.4     Inside          22 14           Outside
 * 17.5 3       Outside         22.5 8.5        Inside
 * 17.51 4.01   Inside          23 7.5          Outside
 * 17.5 13.5    Inside          23.001 11.01    Outside
 * Hint: to check whether a point is inside a rectangle, you may check at which
 * side of a line a point lies: http://stackoverflow.com/questions/1560492/
 * (for each of the triangle's sides the point should lie at the same side).

 */

import java.util.Scanner;

public class PointsInsideTheHouse {
    public static void main(String[] args ) {
        Scanner scanner = new Scanner(System.in);

        double x = scanner.nextDouble();
        double y = scanner.nextDouble();

        Boolean house = (x >= 12.5) && (x <= 17.5) && (y >= 8.5) && (y <= 13.5);
        Boolean garage = (x >= 20) && (x <= 22.5) && (y >= 8.5) && (y <= 13.5);

        //define the roof coordinates
        double Ax = 12.5, Ay = 8.5;
        double Bx = 22.5, By = 8.5;
        double Cx = 17.5, Cy = 3.5;

        double ABC = Math.abs(Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By));
        double ABP = Math.abs(Ax * (By - y) + Bx * (y - Ay) + x * (Ay - By));
        double APC = Math.abs(Ax * (y - Cy) + x * (Cy - Ay) + Cx * (Ay - y));
        double PBC = Math.abs(x * (By - Cy) + Bx * (Cy - y) + Cx * (y - By));

        boolean roof = ABP + APC + PBC == ABC;

        if(house ||garage || roof ){
            System.out.println("Inside");
        }else{
            System.out.println("Outside");
        }
    }


}
