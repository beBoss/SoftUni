/**
 * Created by beBoss on 6.6.2015
 *
 * Write a program that enters 3 points in the plane (as integer x and y coordinates),
 * calculates and prints the area of the triangle composed by these 3 points.
 * Round the result to a whole number. In case the three points do not form a triangle,
 * print "0" as result. Examples:
 *
 *  Input Output Input Output Input Output
 *  -5 10  575   53 18   86    1 1     0
 *  25 30        56 23         2 2
 *  60 15        24 27         3 3
 *
 */

import java.util.Scanner;

public class TriangleArea {
    public static  void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ax = ");
        float Ax = scanner.nextFloat();

        System.out.print("Ay = ");
        float Ay = scanner.nextFloat();

        System.out.print("Bx = ");
        float Bx = scanner.nextFloat();

        System.out.print("By = ");
        float By = scanner.nextFloat();

        System.out.print("Cx = ");
        float Cx = scanner.nextFloat();

        System.out.print("Cy = ");
        float Cy = scanner.nextFloat();

        float area =  Math.abs((Ax * (By - Cy)) + (Bx * (Cy - Ay)) + (Cx * (Ay - By))) / 2;
        System.out.println( (int)area );
    }
}
