public class User {
    private int userID;
    private Username username;
    private Password password;
    private String email;
    private Date createdAt;

    public User(int userID, Username username, Password password, String email, Date createdAt) {
        this.userID = userID;
        this.username = username;
        this.password = password;
        this.email = email;
        this.createdAt = createdAt;
    }

    public int getUserID() {
        return userID;
    }

    public void setUserID(int userID) {
        this.userID = userID;
    }

    public Username getUsername() {
        return username;
    }

    public void setUsername(Username username) {
        this.username = username;
    }

    public Password getPassword() {
        return password;
    }

    public void setPassword(Password password) {
        this.password = password;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public Date getCreatedAt() {
        return createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }
}

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


public class Username {
    private String username;

    public Username(String username) {
        if (username == null || username.isEmpty()) {
            throw new IllegalArgumentException("Username cannot be null or empty");
        }
        this.username = username;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        if (username == null || username.isEmpty()) {
            throw new IllegalArgumentException("Username cannot be null or empty");
        }
        this.username = username;
    }
}


public class Password {
    private String password;

    public Password(String password) {
        if (password == null || password.isEmpty()) {
            throw new IllegalArgumentException("Password cannot be null or empty");
        }
        this.password = password;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        if (password == null || password.isEmpty()) {
            throw new IllegalArgumentException("Password cannot be null or empty");
        }
        this.password = password;
    }
}

public class Content {
    private String data;

    public Content(String data) {
        if (data == null || data.isEmpty()) {
            throw new IllegalArgumentException("Content cannot be null or empty");
        }
        this.data = data;
    }

    public String getData() {
        return data;
    }

    public void setData(String data) {
        if (data == null || data.isEmpty()) {
            throw new IllegalArgumentException("Content cannot be null or empty");
        }
        this.data = data;
    }
}

public class Reaction {
    private int reactionID;
    private String type;
    private int contentID;
    private int userID;
    private Date createdAt;

    public Reaction(int reactionID, String type, int contentID, int userID, Date createdAt) {
        this.reactionID = reactionID;
        this.type = type;
        this.contentID = contentID;
        this.userID = userID;
        this.createdAt = createdAt;
    }

    public int getReactionID() {
        return reactionID;
    }

    public void setReactionID(int reactionID) {
        this.reactionID = reactionID;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public int getContentID() {
        return contentID;
    }

    public void setContentID(int contentID) {
        this.contentID = contentID;
    }

    public int getUserID() {
        return userID;
    }

    public void setUserID(int userID) {
        this.userID = userID;
    }

    public Date getCreatedAt() {
        return createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }
}

public class UserAggregate {
    private User user;
    private List<Post> posts;
    private List<Comment> comments;

    public UserAggregate(User user, List<Post> posts, List<Comment> comments) {
        this.user = user;
        this.posts = posts;
        this.comments = comments;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public List<Post> getPosts() {
        return posts;
    }

    public void setPosts(List<Post> posts) {
        this.posts = posts;
    }

    public List<Comment> getComments() {
        return comments;
    }

    public void setComments(List<Comment> comments) {
        this.comments = comments;
    }
}

public class UserService {
    private UserRepository userRepository;

    public UserService(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    public void registerUser(User user) {
        userRepository.save(user);
    }

}

public class ContentService {
    private ContentRepository contentRepository;

    public ContentService(ContentRepository contentRepository) {
        this.contentRepository = contentRepository;
    }

    public void uploadPost(Post post) {
        contentRepository.save(post);
    }

}

public class SocialService {
    private UserRepository userRepository;
    private CommentRepository commentRepository;

    public SocialService(UserRepository userRepository, CommentRepository commentRepository) {
        this.userRepository = userRepository;
        this.commentRepository = commentRepository;
    }

    public void followUser(int followerID, int followeeID) {

        User follower = userRepository.findById(followerID);
        User followee = userRepository.findById(followeeID);

        if (follower == null || followee == null) {
            throw new IllegalArgumentException("Invalid user ID(s) provided.");
        }

        if (!follower.getFollowing().contains(followeeID)) {
            follower.getFollowing().add(followeeID);
            userRepository.save(follower);
        }
    }

    public void writeComment(Comment comment) {
        if (comment == null || comment.getText() == null) {
            throw new IllegalArgumentException("Comment cannot be null or empty.");
        }

        Post post = postRepository.findById(comment.getPostID());
        if (post == null) {
            throw new IllegalArgumentException("post does not exist");
        }
        commentRepository.save(comment);

    }

}