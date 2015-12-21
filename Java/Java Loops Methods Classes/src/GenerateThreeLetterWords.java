/**
 * Created by beBoss on 8.6.2015
 *
 */

import java.util.Scanner;

public class GenerateThreeLetterWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String chars = scanner.nextLine();
        permutation(chars);
    }

    public static void permutation(String str) {
        permutation("", str);
    }

    private static void permutation(String prefix, String str) {
        int n = str.length();

        if (n == 0) {
            System.out.println(prefix);
        } else {
            for (int i = 0; i < n; i++){
                permutation(prefix + str.charAt(i),
                        str.substring(0, i) + str.substring(i + 1, n));
            }
        }
    }
}
