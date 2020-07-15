/** Tim Dickens
* z1804759
* CSCI 470
* Assignment 1
* TipCalculator.Java
* Class declaration for TipCalculator objects
*/

public class TipCalculator {
    private double billAmount;
    private int tipPercent;
    private int partySize;

    public double getBillAmount() {
        return billAmount;
    }

    public void setBillAmount(double billAmount) {
        this.billAmount = billAmount;
    }

    public int getTipPercent() {
        return tipPercent;
    }

    public void setTipPercent(int tipPercent) {
        this.tipPercent = tipPercent;
    }

    public int getPartySize() {
        return partySize;
    }

    public void setPartySize(int partySize) {
        this.partySize = partySize;
    }


    public TipCalculator(double billAmount, int tipPercent, int partySize) {
        this.billAmount = billAmount;
        this.tipPercent = tipPercent;
        this.partySize = partySize;
    }

    public TipCalculator(){
        this.billAmount = 0;
        this.tipPercent = 0;
        this.partySize = 1;
    }

    public double getTotalBill() {
        return (this.billAmount + (this.billAmount * (.01 * tipPercent)));
    }

    public double getIndividualShare(double totalBill) {
        return (totalBill / this.partySize);
    }

}
