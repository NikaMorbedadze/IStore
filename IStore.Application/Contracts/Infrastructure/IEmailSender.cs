using IStore.Application.Models;

namespace IStore.Application.Contracts.Infrastructure;

public interface IEmailSender
{
    Task<bool> SendEmail(Email email);
}