/**
 * Created by beBoss on 8.6.2015
 *
 * Write a program to generate and print all symmetric numbers in given range [start…end]
 * (0 ? start ? end ? 999). A number is symmetric if its digits are symmetric toward its
 * middle. For example, the numbers 101, 33, 989 and 5 are symmetric, but 102, 34 and 997
 * are not symmetric. Examples:
 *
 * Input	    Output
 * 5 11	        5 6 7 8 9 11
 * 101 110  	101
 * 555 777	    555 565 575 585 595 606 616 626
 *              636 646 656 666 676 686 696 707
 *              717 727 737 747 757 767 777
 *
 */

import java.util.Scanner;

public class SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int start = scanner.nextInt();
        int end = scanner.nextInt();

        isSymmetricNumber(start, end);
    }

    private static void isSymmetricNumber(int start, int end){
        for (int i = start; i <= end; i++) {
            int n = i;
            int rev = 0;

            while (n > 0) {
                //To extract the last digit
                int digit = n % 10;

                //To store it in reverse
                rev = (rev * 10) + digit;

                //To throw the last digit
                n = n / 10;
            }

            //To check if a number is symmetric or not
            if (i == rev) {
                System.out.println(i);
            }
        }
    }
}
