import java.awt.EventQueue;
import javax.swing.JFrame;

public class GUI extends JFrame {

    public GUI() {

        initUI();
    }

    private void initUI() {

        setTitle("TipApp Calculator");
        setSize(600, 300);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    }

    public static void main(String[] args) {

        EventQueue.invokeLater(() -> {
            var ex = new GUI();
            ex.setVisible(true);
        });
    }
}