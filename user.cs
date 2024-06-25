public class User
{

  private int userID;
  private Username username;
  private Password password;
  private String email;
  private Date createdAt;

  public User(int userID, Username username, Password password, String email, Date createdAt)
  {
    this.userID = userID;
    this.username = username;
    this.password = password;
    this.email = email;
    this.createdAt = createdAt;
  }

  public int getUserID()
  {
    return userID;
  }

  public void setUserID(int userID)
  {
    this.userID = userID;
  }

  public Username getUsername()
  {
    return username;
  }

  public void setUsername(Username username)
  {
    this.username = username;
  }

  public Password getPassword()
  {
    return password;
  }

  public void setPassword(Password password)
  {
    this.password = password;
  }

  public String getEmail()
  {
    return email;
  }

  public void setEmail(String email)
  {
    this.email = email;
  }

  public Date getCreatedAt()
  {
    return createdAt;
  }

  public void setCreatedAt(Date createdAt)
  {
    this.createdAt = createdAt;
  }
}

public class Username
{
  private String username;

  public Username(String username)
  {
    if (username == null || username.isEmpty())
    {
      throw new IllegalArgumentException("Username cannot be null or empty");
    }
    this.username = username;
  }

  public String getUsername()
  {
    return username;
  }

  public void setUsername(String username)
  {
    if (username == null || username.isEmpty())
    {
      throw new IllegalArgumentException("Username cannot be null or empty");
    }
    this.username = username;
  }
}


public class Password
{
  private String password;

  public Password(String password)
  {
    if (password == null || password.isEmpty())
    {
      throw new IllegalArgumentException("Password cannot be null or empty");
    }
    this.password = password;
  }

  public String getPassword()
  {
    return password;
  }

  public void setPassword(String password)
  {
    if (password == null || password.isEmpty())
    {
      throw new IllegalArgumentException("Password cannot be null or empty");
    }
    this.password = password;
  }
}


public class UserAggregate
{
  private User user;
  private List<Post> posts;
  private List<Comment> comments;

  public UserAggregate(User user, List<Post> posts, List<Comment> comments)
  {
    this.user = user;
    this.posts = posts;
    this.comments = comments;
  }

  public User getUser()
  {
    return user;
  }

  public void setUser(User user)
  {
    this.user = user;
  }

  public List<Post> getPosts()
  {
    return posts;
  }

  public void setPosts(List<Post> posts)
  {
    this.posts = posts;
  }

  public List<Comment> getComments()
  {
    return comments;
  }

  public void setComments(List<Comment> comments)
  {
    this.comments = comments;
  }
}
