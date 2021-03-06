package Sockets.Models;

import org.springframework.boot.autoconfigure.domain.EntityScan;

import java.io.Serializable;
/**
 * This class contains information of a user
 */
public class User implements Serializable
{
    public int Id;
    public String Username;
    public String Password;
    public String Photo;
    public String LastName;
    public String FirstName;
    public int SecurityLevel;
    public String Role;
    private static final long serialVersionUID = 6529685098267757690L;

    public User(int id, String username, String password, String photo, String lastName, String firstName, int securityLevel, String role) {
        Id = id;
        Username = username;
        Password = password;
        Photo = photo;
        LastName = lastName;
        FirstName = firstName;
        SecurityLevel = securityLevel;
        Role = role;
    }

    public User(String username, String password, String photo, String lastName, String firstName, int securityLevel, String role) {
        Id = -1;
        Username = username;
        Password = password;
        Photo = photo;
        LastName = lastName;
        FirstName = firstName;
        SecurityLevel = securityLevel;
        Role = role;
    }

    public User(int id, String username, String photo, String lastName, String firstName)
    {
        Id = id;
        Username = username;
        Photo = photo;
        LastName = lastName;
        FirstName = firstName;
    }

    public User (String username, String password, String firstName, String lastName)
    {
        Username = username;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
    }

    public User(String username, String password)
    {
        this(-1,username,password,null,null,null,0,null);
    }


    public User(String username)
    {
        this(-1,username,null,null,null,null,0,null);
    }

    public User()
    {

    }

    public int getId() {
        return Id;
    }

    public void setId(int id) {
        Id = id;
    }

    public String getUsername() {
        return Username;
    }

    public void setUsername(String username) {
        Username = username;
    }

    public String getPassword() {
        return Password;
    }

    public void setPassword(String password) {
        Password = password;
    }

    public String getPhoto() {
        return Photo;
    }

    public void setPhoto(String photo) {
        Photo = photo;
    }

    public String getLastName() {
        return LastName;
    }

    public void setLastName(String lastName) {
        LastName = lastName;
    }

    public String getFirstName() {
        return FirstName;
    }

    public void setFirstName(String firstName) {
        FirstName = firstName;
    }

    public int getSecurityLevel() {
        return SecurityLevel;
    }

    public void setSecurityLevel(int securityLevel) {
        SecurityLevel = securityLevel;
    }

    public String getRole() {
        return Role;
    }

    public void setRole(String role) {
        Role = role;
    }

    @Override public String toString()
    {
        return "User{" + "Id=" + Id + ", Username='" + Username + '\''
            + ", Password='" + Password + '\'' + ", Photo='" + Photo + '\''
            + ", LastName='" + LastName + '\'' + ", FirstName='" + FirstName
            + '\'' + ", SecurityLevel='" + SecurityLevel + '\'' + ", Role='"
            + Role + '\'' + '}';
    }
}