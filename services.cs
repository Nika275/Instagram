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
