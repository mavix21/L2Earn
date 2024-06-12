namespace L2Earn.Domain.Shared;

public record Currency
{
    public static readonly Currency Eth = new("ETH");
    public static readonly Currency Usdt = new("USDT");

    private Currency(string code) => Code = code;

    public string Code { get; init; }

    public static Currency FromCode(string code) =>
        All.FirstOrDefault(c => c.Code == code) ??
        throw new ArgumentException($"The currency {code} is not supported");

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Eth,
        Usdt
    };
}
