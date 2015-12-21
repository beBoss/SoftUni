/**
 * Created by beBoss on 8.6.2015
 */
public class TestCards {
    public static void main(String[] args) {
        String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        char[] suits = new char[]{'\u2660', '\u2665', '\u2666', '\u2663'};

        int combination = 0;
        for (int i = 0; i < cards.length; i++) {
            for (int j = 0; j < cards.length; j++) {
                if (i != j) {
                    for (int firstCard = 0; firstCard < 4; firstCard++) {
                        for (int secondCard = firstCard + 1; secondCard + 1 < 4; secondCard++) {
                            for (int thirdCard = secondCard + 1; thirdCard < 4; thirdCard++) {
                                for (int fourthCard = 0; fourthCard < 4; fourthCard++) {
                                    for (int fifthCard = fourthCard + 1; fifthCard  < 4; fifthCard++) {
                                        combination++;
                                        System.out.println(cards[i] + "" + suits[firstCard] + "" + cards[i] + "" + suits[secondCard]
                                                + "" + cards[i] + "" + suits[thirdCard] + "" + cards[j] + "" + suits[fourthCard] + "" +
                                                cards[j] + "" + suits[fifthCard] + " ");

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        System.out.println(combination);
    }
}
