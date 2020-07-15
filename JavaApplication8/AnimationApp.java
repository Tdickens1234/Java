import javax.swing.*;
import javax.swing.event.ListSelectionEvent;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.io.*;
import java.util.Vector;
import java.util.Collections;

/**
 *
 * @author Tim Dickens
 * z1804759
 * CSCI 470 Programming In Java
 * Spring 2019
 * Assignment 4
 *
 * Animation App Class is responsible for the main function, which controls the creation of the app, and the
 * creation of the GUI, as well as reading in the animations and creating animation objects
 */

public class AnimationApp extends JFrame {

    public Vector<Animation> anims = new Vector();
    AnimationPanel animPanel = new AnimationPanel();
    Vector<String> animNames = new Vector();
    JButton Start = new JButton("Start");
    JButton Pause = new JButton("Pause");
    JButton Stop = new JButton("Stop");
    JList<String> List;

    public static void main(String[] args) {

        EventQueue.invokeLater(() -> {
            AnimationApp ex = new AnimationApp("Animation App");
            ex.createAndShowGUI();
            ex.setVisible(true);
        });

    }

    /**
     * readloop method reads in the animations and builds the vector of animation objects
     */

    private void readLoop(){
        File file = new File("src\\Animations\\animations.txt");
        try{
            BufferedReader reader = new BufferedReader(new FileReader(file));
            String line;
            String name = "";
            int width = 0;
            int height = 0;
            int frameNum = 0;
            int delay = 0;

            while((line = reader.readLine()) != null){
                String[] splitter = line.split(":");
                for(int i = 0; i < splitter.length; i++){
                    if(i == 0){
                       String[] split2 = splitter[0].split(" ");
                       name = split2[0];
                       for(int j = 1; j < split2.length; j++){
                           name = name + "_" + split2[j];
                       }
                    }
                    else if(i == 1){
                        try{
                            width = Integer.parseInt(splitter[1]);
                        }
                        catch(NumberFormatException e){
                            System.out.println("Number Format Exception thrown");
                        }
                    }
                    else if(i == 2){
                        try{
                            height = Integer.parseInt(splitter[2]);
                        }
                        catch(NumberFormatException e){
                            System.out.println("Number Format Exception thrown");
                        }
                    }
                    else if(i == 3){
                        try{
                            frameNum = Integer.parseInt(splitter[3]);
                        }
                        catch(NumberFormatException e){
                            System.out.println("Number Format Exception thrown");
                        }
                    }
                    else if(i == 4){
                        try{
                            delay = Integer.parseInt(splitter[4]);
                        }
                        catch(NumberFormatException e){
                            System.out.println("Number Format Exception thrown");
                        }

                    }
                }
                Animation anim = new Animation(name, width, height, frameNum, delay);
                anims.add(anim);
            }
            for(int i = 0; i < anims.size(); i++){
                animNames.add(anims.get(i).toString());
            }
            Collections.sort(animNames);
        }
        catch(FileNotFoundException e){
            return;
        }
        catch(IOException e) {
            return;
        }
    }

    private AnimationApp(String title){
        super(title);
    }

    /**
     * actionPerformed method handles the button click events
     */

    public void actionPerformed(ActionEvent e){
        if(e.getActionCommand() == "Start"){
            animPanel.startAnimation();
            Start.setEnabled(false);
            Pause.setText("Pause");
            Pause.setEnabled(true);
            Stop.setEnabled(true);
        }
        else if(e.getActionCommand() == "Stop"){
            animPanel.stopAnimation();
            Start.setEnabled(true);
            Pause.setEnabled(false);
            Stop.setEnabled(false);
        }
        else if(e.getActionCommand() == "Pause"){
            animPanel.pauseAnimation();
            Pause.setText("Resume");
        }
        else if(e.getActionCommand() == "Resume"){
            animPanel.resumeAnimation();
            Pause.setText("Pause");
        }
    }

    /**
     * createAndShowGUI method enables all components and sets sizes
     */

    private void createAndShowGUI() {
        JPanel CenterPanel = new JPanel();
        JPanel SouthPanel = new JPanel();
        JPanel WestPanel = new JPanel();
        JLabel label = new JLabel("Animations");
        Pause.setPreferredSize(new Dimension(100,20));
        Stop.setPreferredSize(new Dimension(100,20));
        Start.setPreferredSize(new Dimension(100,20));
        readLoop();
        List = new JList(animNames);
        List.setPreferredSize(new Dimension(160, 600));
        WestPanel.setPreferredSize(new Dimension(180, 600));
        CenterPanel.setPreferredSize(new Dimension(600, 400));
        SouthPanel.setPreferredSize(new Dimension(100, 20));
        add(CenterPanel, BorderLayout.CENTER);
        add(SouthPanel, BorderLayout.SOUTH);
        add(WestPanel, BorderLayout.WEST);
        WestPanel.add(label);
        WestPanel.add(List);
        SouthPanel.setLayout(new GridLayout());
        SouthPanel.add(Start);
        SouthPanel.add(Pause);
        SouthPanel.add(Stop);
        animPanel.setPreferredSize(new Dimension(600, 400));
        add(animPanel, BorderLayout.CENTER);
        animPanel.setBackground(Color.BLACK);
        Start.addActionListener(this::actionPerformed);
        Pause.addActionListener(this::actionPerformed);
        Stop.addActionListener(this::actionPerformed);
        List.addListSelectionListener(this::valueChanged);
        setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        Start.setEnabled(false);
        Pause.setEnabled(false);
        Stop.setEnabled(false);
        pack();
    }

    /**
     * valueChanged method handles list selection changes, stops animations and loads the new ones
     */

    public void valueChanged(ListSelectionEvent e){
        animPanel.stopAnimation();
        for(int i = 0; i < anims.size(); i++){
            if(anims.get(i).toString().equals(List.getSelectedValue())){
                animPanel.loadAnimation(anims.get(i));
                Pause.setText("Pause");
                Start.setEnabled(true);
                Pause.setEnabled(false);
                Stop.setEnabled(false);
            }
        }
    }
}