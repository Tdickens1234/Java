/**
 *
 * @author Tim Dickens
 * z1804759
 * CSCI 470 Programming In Java
 * Spring 2019
 * Assignment 4
 *
 * Animation class defines animation objects
 */

public class Animation{

    private String animName;
    private int animWidth;
    private int animHeight;
    private int frameNum;
    private int delay;

    public Animation(String newAnim, int newWidth, int newHeight, int newFrameNum, int newDelay){
        this.animWidth = newWidth;
        this.animName = newAnim;
        this.animHeight = newHeight;
        this.frameNum = newFrameNum;
        this.delay = newDelay;
    }

    public String getAnimName(){
        return this.animName;
    }

    public int getAnimWidth(){
        return this.animWidth;
    }

    public int getAnimHeight(){
        return this.animHeight;
    }

    public int getFrameNum(){
        return this.frameNum;
    }

    public int getDelay(){
        return this.delay;
    }

    /**
     * toString method removes the underscore used to find path names for Animations
     */
    @Override
    public String toString(){
        String[] splitter = animName.split("_");
        String name = splitter[0];
        for(int i = 1; i < splitter.length; i++){
            name = name + " " + splitter[i];
        }
        return name;
    }

}
