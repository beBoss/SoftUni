/**
 * Created by beBoss on 5.6.2015 ã..
 *
 * Write a program to generate a PDF document called Deck-of-Cards.pdf and print in it
 * a standard deck of 52 cards, following one after another. Each card should be
 * a rectangle holding its face and suit.
 */

import java.io.FileOutputStream;
import java.io.IOException;

import com.itextpdf.text.*;
import com.itextpdf.text.pdf.*;

public class OldGeneratePDF {

    public static final String RESULT
            = "GenerateCards.pdf";

    PdfPTable table = new PdfPTable(4);

    public static void main(String[] args)
            throws DocumentException, IOException {
        new OldGeneratePDF().createPdf(RESULT);
    }

    public  void createPdf(String filename)
            throws DocumentException, IOException {

        Document pdfDocument = new Document();
        PdfWriter.getInstance(pdfDocument, new FileOutputStream(filename));
        pdfDocument.open();
        generateCards();
        table.setWidthPercentage(100F);
        table.getDefaultCell().setFixedHeight(100F);
        pdfDocument.add(table);
        pdfDocument.close();
    }

    public  void generateCards()
            throws IOException, DocumentException {

        String[] faces = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        char[] suits = new char[]{'\u2660', '\u2665', '\u2666', '\u2663'};

        BaseFont baseFont = BaseFont.createFont("res/arial.ttf", "Identity-H", true);
        Font red = new Font(baseFont, 70F, 0, BaseColor.RED);
        Font black = new Font(baseFont, 70F, 0, BaseColor.BLACK);

        for (int i = 0; i < faces.length; i++) {
            for (int j = 0; j < suits.length; j++) {
                String card = faces[i] + suits[j];

                if (suits[j] == '\u2660' || suits[j] == '\u2663') {
                    table.addCell(new Paragraph(card, black));
                } else if (suits[j] == '\u2665' || suits[j] == '\u2666') {
                    table.addCell(new Paragraph(card, red));
                }

            }
        }
    }

}