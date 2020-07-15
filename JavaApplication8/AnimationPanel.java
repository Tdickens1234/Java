import javax.swing.*;
import java.awt.*;

/**
 *
 * @author Tim Dickens
 * z1804759
 * CSCI 470 Programming In Java
 * Spring 2019
 * Assignment 4
 *
 * Animation Panel Class is responsible for loading and drawing the frames of the animation
 */

public class AnimationPanel extends JPanel implements Runnable{

    volatile Thread animThread;
    boolean isPaused = false;
    int xCenter;
    int yCenter;
    int AnimIndex = 0;
    int animDelay;
    Image[] FrameArray;
    MediaTracker Tracker;

    /**
     * loadAnimation method sets the array of frames, calculates the top right corner of the
     * animation so that it is centered, and uses a media tracker to track progress
     */

    void loadAnimation(Animation a){
            FrameArray = new Image[a.getFrameNum()];
            xCenter = (this.getHeight() / 2) - (a.getAnimHeight() / 2);
            yCenter = (this.getWidth() / 2) - (a.getAnimWidth() / 2);
            animDelay = a.getDelay();
            Tracker = new MediaTracker(this);
            for(int i = 0; i < FrameArray.length; i++) {
                String name;
                name = "src" + '\\' + "Animations" + '\\' + a.getAnimName() +'\\' + "frame" + String.format("%03d", i) + ".gif";
                ImageIcon ii = new ImageIcon(name);
                FrameArray[i] = ii.getImage();
                Tracker.addImage(FrameArray[i], i);
            }
    }

    void startAnimation(){
        AnimIndex = 0;
        isPaused = false;
        animThread = new Thread(this);
        animThread.start();
    }

    synchronized void pauseAnimation(){
        isPaused = true;
    }

    synchronized void resumeAnimation(){
        isPaused = false;
        notify();
    }

    synchronized void stopAnimation(){
        animThread = null;
        notify();
        AnimIndex = 0;
    }

    /**
     * paint component method calls the super method, which ensures that only what is being changed is changed
     */
    public void paintComponent(Graphics g){
        super.paintComponent(g);
        if(FrameArray != null){
            g.drawImage(FrameArray[AnimIndex], xCenter, yCenter, null);
        }
        repaint();
    }

    /**
     * run method ensures that the thread runs in synchronization, and draws the panel every frame
     */

    public void run(){
        try {
            Tracker.waitForAll();
        } catch (InterruptedException e) {
            return;
        }
        // Get a reference to the current thread.
        Thread thisThread = Thread.currentThread();
        // Continue to loop while the thread has not been stopped.
        while (animThread == thisThread) {
            try {
                // Sleep for the required delay between frames.
                Thread.sleep(animDelay);
                // If the thread is paused and has not been stopped, wait.
                synchronized (this) {
                    while (isPaused && animThread == thisThread)
                        wait();
                }
            } catch (InterruptedException e) {
                // Thread was interrupted.
            }
            // Redraw the animation panel.
            repaint();
            AnimIndex++;
            if (AnimIndex == FrameArray.length){
                AnimIndex = 0;
            }
        }
    }
}
