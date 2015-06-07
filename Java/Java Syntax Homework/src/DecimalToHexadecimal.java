/**
 * Created by beBoss on 7.6.2015
 *
 * Write a program that enters a positive integer number num and converts
 * and prints it in hexadecimal form. You may use some built-in method
 * from the standard Java libraries. Examples:
 *  Input   Output
 *  254     FE
 *  6779    1A7B
 */

import java.util.Scanner;

public class DecimalToHexadecimal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();

        System.out.printf("%X", number);
    }
}
