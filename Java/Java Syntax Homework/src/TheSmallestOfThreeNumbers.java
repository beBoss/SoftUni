/**
 * Created by beBoss on 7.6.2015
 *
 * Write a program that finds the smallest of three numbers. Examples:
 *  a       b       c       smallest
 *  5       2       2       2
 *  2       2       1       1
 *  22      4       13      4
 *  0       -2.5    -5      -5
 *  -1.1    -0.5 -0.1       -1.1
 */

import java.text.DecimalFormat;
import java.util.Scanner;

public class TheSmallestOfThreeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        float a = scanner.nextFloat();
        float b = scanner.nextFloat();
        float c = scanner.nextFloat();

        calculateTheSmallest(a, b, c);

    }

    private static void calculateTheSmallest(float a, float b, float c) {
        DecimalFormat df = new DecimalFormat("0.###");

        if ((a < b ) && (a < c)) {
            System.out.println(df.format(a));

        } else if ((a > b) && (b < c)){
            System.out.println(df.format(b));

        } else{
            System.out.println(df.format(c));
        }

    }
}