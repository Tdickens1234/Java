/** Tim Dickens
* z1804759
* CSCI 470
* Assignment 1
* TipApp.Java
* Use: creates an object that calculates bill and tips
*/
import java.awt.EventQueue;
import javax.swing.JFrame;
import javax.swing.event.ChangeListener;
import java.awt.event.ActionListener;
import java.util.Scanner;

public class TipApp extends JFrame implements ActionListener, ChangeListener {

    private javax.swing.JLabel TotalBillLabel;
    private javax.swing.JLabel SharePerPerson;
    private javax.swing.JButton CalculateButton;
    private javax.swing.SpinnerNumberModel PartySize;
    private javax.swing.JTextField BillAmountText;
    private javax.swing.JButton ClearButton;
    private javax.swing.JSlider TipPercentSlider;
    public TipCalculator calculate;

    public TipApp(){
        initComponents();
    }

    /**
     *  main driver function handles program flow, calls calculateTips method to handle logic
     */
    public void main(String[] args)
    {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new TipApp().setVisible(true);
            }
        });
    }

    public void stateChanged(java.awt.event.ActionEvent evt){
        if( evt.getSource() == TipPercentSlider ){
            calculate.setTipPercent(TipPercentSlider.getValue());
        }
        else if( evt.getSource() == PartySize){
            calculate.setPartySize((Integer)PartySize.getValue());
        }
    }

    public void actionPerformed (java.awt.event.ActionEvent evt){
        if(evt.getSource() == CalculateButton){
            CalculateButtonActionPerformed();
        }
        else if(evt.getSource() == ClearButton){
            ClearButtonActionPerformed();
        }
    }

    public void ClearButtonActionPerformed(){
        TotalBillLabel.setText("$0.00");
        SharePerPerson.setText("$0.00");
        BillAmountText.setText("");
        PartySize.setValue(1);
    }

    private void initComponents() {
        Integer value = 1;
        Integer min = 1;
        Integer max = 100;
        Integer step = 1;

        TotalBillLabel = new javax.swing.JLabel("$0.00");
        SharePerPerson = new javax.swing.JLabel("$0.00");
        CalculateButton = new javax.swing.JButton("Calculate");
        ClearButton = new javax.swing.JButton("Clear");
        PartySize = new javax.swing.SpinnerNumberModel(value, min, max, step);
        BillAmountText = new javax.swing.JTextField();
        TipPercentSlider = new javax.swing.JSlider();

        javax.swing.JLabel BillText = new javax.swing.JLabel("Bill Amount");
        javax.swing.JLabel TipText = new javax.swing.JLabel("Tip Percent");
        javax.swing.JLabel PartyText = new javax.swing.JLabel("Total Bill (with Tip)");
        javax.swing.JLabel ShareText = new javax.swing.JLabel("Individual Share");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Tip Calculator");

        CalculateButton.addActionListener(this::actionPerformed);
        ClearButton.addActionListener(this::actionPerformed);
        TipPercentSlider.addChangeListener(this::stateChanged);
        PartySize.addChangeListener(this::stateChanged);
    }

    private void CalculateButtonActionPerformed(){
        calculate.setBillAmount(Double.parseDouble(TotalBillLabel.getText()));
        calculate.setPartySize((Integer)PartySize.getValue());
        calculate.setTipPercent(TipPercentSlider.getValue());
        TotalBillLabel.setText(String.valueOf(calculate.getTotalBill()));
        SharePerPerson.setText(String.valueOf(calculate.getIndividualShare(calculate.getTotalBill())));
    }

    /**
     *   calculateTips method scans for valid input, then uses that input to create a TipCalculator object,
     *   which is used to calculate the bill
     */

    private static void calculateTips() {
        Scanner scan = new Scanner(System.in);
        double billAmount;
        int tipPercent;
        int partySize;
        String input;

        String play = "y";
        String n = "n";
        String N = "N";

        //check for exit conditions

        while (!play.equals(n) && !play.equals(N)) {
            System.out.print("Enter the bill amount: ");

            //Check for the bill amount, valid number must be used
            input = scan.next();
            while (!isDouble(input)) {
                System.out.println("That's not a valid number.\n");
                System.out.print("Enter the bill amount: ");
                input = scan.next();
            }
            billAmount = Double.valueOf(input);

            //check for the tip amount, valid number must be used

            System.out.print("Enter desired tip percentage (20 = 20%): ");
            input = scan.next();
            while (!input.matches("\\d+")) {
                System.out.println("That's not a valid number.\n");
                System.out.print("Enter desired tip percentage (20 = 20%): ");
                input = scan.next();
            }
            tipPercent = Integer.valueOf(input);

            //check for the party size, must be a valid number

            System.out.print("Enter the size of your party: ");
            input = scan.next();
            while (!input.matches("\\d+") || input.startsWith("-") || input.startsWith("0")) {
                System.out.println("That's not a valid party size.\n");
                System.out.print("Enter the size of your party: ");
                input = scan.next();
            }

            //Call tipcalculator the calculate the bill and tip

            partySize = Integer.valueOf(input);
            TipCalculator calculate = new TipCalculator(billAmount, tipPercent, partySize);
            System.out.println("\n*** YOUR BILL ***\n");
            System.out.println("Bill Amount: $" + String.format("%.2f", calculate.getBillAmount()));
            System.out.println("Tip Percentage: " + calculate.getTipPercent() + "%");
            System.out.println("Party Size: " + calculate.getPartySize() + "\n");
            System.out.println("Total Bill (With Tip): $" + String.format("%.2f", calculate.getTotalBill()));
            System.out.println("Share for Each Individual: $" + String.format("%.2f", calculate.getIndividualShare(calculate.getTotalBill())) + "\n");

            //check for exit

            System.out.print("Another Bill? (y/n): ");
            play = scan.next();
        }
        System.out.println("\nGoodbye!");
    }

    /**
     *   isDouble method used to check for double and negative numbers
     */

    private static boolean isDouble(String input) {
        try {
            Double.parseDouble(input);
            double tempDouble = Double.valueOf(input);
            if(tempDouble < 0){
                return false;
            }
            return true;
        } catch (Exception e) {
            return false;
        }
    }


}
