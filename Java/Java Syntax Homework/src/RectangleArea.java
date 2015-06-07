/**
 * Created by beBoss on 6.6.2015
 *
 * Write a program that enters the sides of a rectangle (two integers a and b) and
 * calculates and prints the rectangle's
 * area. Examples:
 *
 * Input Output
 * 7 20 140
 * 5 12 60
 *
 */

import java.util.Scanner;

public class RectangleArea {

    public static  void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        System.out.print("A = ");
        int a = scanner.nextInt();

        System.out.print("B = ");
        int b = scanner.nextInt();

        int output = (a * b);
        System.out.println(output);
    }
}
