using L2Earn.Domain.Abstractions;

namespace L2Earn.Domain.Users;

public class User : Entity
{
    private User(
        Guid id,
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

    public Guid Id { get; private set; }
    public Username Username { get; private set; }
    public ProfilePhoto ProfilePhoto { get; private set; }
    public WalletAddress WalletAddress { get; private set; }

    public static User Create(
        WalletAddress walletAddress,
        Username username,
        ProfilePhoto profilePhoto
    ) => new(
        Guid.NewGuid(),
        walletAddress,
        username,
        profilePhoto
    );
}
