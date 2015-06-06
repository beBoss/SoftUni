/**
 * Created by beBoss on 5.6.2015 ã..
 * <p>
 * Write a program to generate a PDF document called Deck-of-Cards.pdf and print in it
 * a standard deck of 52 cards, following one after another. Each card should be
 * a rectangle holding its face and suit.
 */

import java.io.FileOutputStream;
import java.io.IOException;

import com.itextpdf.text.*;
import com.itextpdf.text.pdf.*;

public class GeneratePDF {

    private static final String FILE
            = "Deck-of-Cards.pdf";

    public static void main(String[] args) {

        try {
            Document pdfDocument = new Document();
            PdfWriter.getInstance(pdfDocument, new FileOutputStream(FILE));
            pdfDocument.open();
            generateCards(pdfDocument);
            pdfDocument.close();

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private  static void generateCards(Document document)
            throws IOException, DocumentException {

        String[] cards = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        char[] suits = new char[]{'\u2660', '\u2665', '\u2666', '\u2663'};

        BaseFont baseFont = BaseFont.createFont("res/arial.ttf", "Identity-H", true);
        Font red = new Font(baseFont, 12F, 0, BaseColor.RED);
        Font black = new Font(baseFont, 12F, 0, BaseColor.BLACK);

        PdfPTable table = new PdfPTable(4);
        table.getDefaultCell().setBorder(0);

        for (int i = 0; i < cards.length; i++) {
            for (int j = 0; j < suits.length; j++) {
                String card = cards[i] + suits[j];

                if (suits[j] == '\u2660' || suits[j] == '\u2663') {
                    cardsBorder(card, black, table);
                } else if (suits[j] == '\u2665' || suits[j] == '\u2666') {
                    cardsBorder(card, red, table);
                }

            }
        }
        document.add(table);
    }

    private static void cardsBorder(String card, Font colour, PdfPTable tableContent) {
        PdfPTable table = new PdfPTable(1);
        table.getDefaultCell().setFixedHeight(45);
        table.setTotalWidth(30);
        table.setLockedWidth(true);
        table.getDefaultCell().setVerticalAlignment(Element.ALIGN_MIDDLE);
        table.getDefaultCell().setHorizontalAlignment(Element.ALIGN_CENTER);

        table.addCell(new Phrase(card, colour));
        tableContent.addCell(table);
    }

}