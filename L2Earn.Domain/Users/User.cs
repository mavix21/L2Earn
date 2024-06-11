using L2Earn.Domain.Abstractions;
using StronglyTypedIds;

namespace L2Earn.Domain.Users;

[StronglyTypedId]
public partial struct UserId { }

public class User : Entity<UserId>
{
    private User(
        UserId id,
        WalletAddress walletAddress,
        Username username,
        ProfilePhoto profilePhoto
    ) : base(id)
    {
        Id = id;
        WalletAddress = walletAddress;
        Username = username;
        ProfilePhoto = profilePhoto;
    }

    public UserId Id { get; private set; }
    public Username Username { get; private set; }
    public ProfilePhoto ProfilePhoto { get; private set; }
    public WalletAddress WalletAddress { get; private set; }

    public static User Create(
        WalletAddress walletAddress,
        Username username,
        ProfilePhoto profilePhoto
    ) => new(
        UserId.New(),
        walletAddress,
        username,
        profilePhoto
    );
}
