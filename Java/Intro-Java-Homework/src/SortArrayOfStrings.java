/**
 * Created by beBoss on 12.5.2015 ã..
 */

import java.util.Scanner;


public class SortArrayOfStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        String[] cities = new String[n];

        for (int i = 0; i < n; i++) {
            cities[i] = scan.next();
        }

        bubbleStringSort(cities);

        for (String i : cities) {
            System.out.println(i);
        }

    }

    public static void bubbleStringSort(String cities[]) {
        int i;
        boolean flag = true;
        String temp;

        while (flag) {
            flag = false;
            for (i = 0; i < cities.length - 1; i++) {
                if (cities[i].compareToIgnoreCase(cities[i + 1]) > 0) {                                             // ascending sort
                    temp = cities[i];
                    cities[i] = cities[i + 1];
                    cities[i + 1] = temp;
                    flag = true;
                }
            }
        }
    }
}
