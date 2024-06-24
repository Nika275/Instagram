public class Post { 
    private int postID;
    private int userID;
    private Content content;
    private Date timestamp;

    public Post(int postID, int userID, Content content, Date timestamp) {
        this.postID = postID;
        this.userID = userID;
        this.content = content;
        this.timestamp = timestamp;
    }

    public int getPostID() {
        return postID;
    }

    public void setPostID(int postID) {
        this.postID = postID;
    }

    public int getUserID() {
        return userID;
    }

    public void setUserID(int userID) {
        this.userID = userID;
    }

    public Content getContent() {
        return content;
    }

    public void setContent(Content content) {
        this.content = content;
    }

    public Date getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(Date timestamp) {
        this.timestamp = timestamp;
    }
}

public class Comment {
    private int commentID;
    private int postID;
    private int userID;
    private String text;
    private Date timestamp;

    public Comment(int commentID, int postID, int userID, String text, Date timestamp) {
        this.commentID = commentID;
        this.postID = postID;
        this.userID = userID;
        this.text = text;
        this.timestamp = timestamp;
    }

    public int getCommentID() {
        return commentID;
    }

    public void setCommentID(int commentID) {
        this.commentID = commentID;
    }

    public int getPostID() {
        return postID;
    }

    public void setPostID(int postID) {
        this.postID = postID;
    }

    public int getUserID() {
        return userID;
    }

    public void setUserID(int userID) {
        this.userID = userID;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public Date getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(Date timestamp) {
        this.timestamp = timestamp;
    }
}


public class Reel {
    private int reelID;
    private Content content;
    private Date timestamp;

    public Reel(int reelID, Content content, Date timestamp) {
        this.reelID = reelID;
        this.content = content;
        this.timestamp = timestamp;
    }

    public int getReelID() {
        return reelID;
    }

    public void setReelID(int reelID) {
        this.reelID = reelID;
    }

    public Content getContent() {
        return content;
    }

    public void setContent(Content content) {
        this.content = content;
    }

    public Date getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(Date timestamp) {
        this.timestamp = timestamp;
    }
}

public class Story {
    private int storyID;
    private Content content;
    private Date timestamp;

    public Story(int storyID, Content content, Date timestamp) {
        this.storyID = storyID;
        this.content = content;
        this.timestamp = timestamp;
    }

    public int getStoryID() {
        return storyID;
    }

    public void setStoryID(int storyID) {
        this.storyID = storyID;
    }

    public Content getContent() {
        return content;
    }

    public void setContent(Content content) {
        this.content = content;
    }

    public Date getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(Date timestamp) {
        this.timestamp = timestamp;
    }
}
