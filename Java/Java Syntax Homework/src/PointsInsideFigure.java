/**
 * Created by beBoss on 7.6.2015
 *
 * Write a program to check whether a point is inside or outside of the figure below.
 * The point is given as a pair of floating-point numbers, separated by a space.
 * Your program should print "Inside" or "Outside"
 */

import java.util.Scanner;

public class PointsInsideFigure {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        float x = scanner.nextFloat();
        float y = scanner.nextFloat();

        calculatePoints(x, y);
    }

    private static void calculatePoints(float x, float y) {
        boolean placeOne = (x >= 12.5) && (x <= 17.5) && (y >= 8.5) && (y <= 13.5);
        boolean placeTwo = (y >= 12.5) && (y <= 22.5) && (y >= 6) && (y <= 8.5);
        boolean placeThree = (x >= 20) && (x <= 22.5) && (y >= 8.5) && (y <= 13.5);

        if (placeOne || placeTwo || placeThree) {
            System.out.println("Inside");
        } else {
            System.out.println("Outside");
        }
    }
}