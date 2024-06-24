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
