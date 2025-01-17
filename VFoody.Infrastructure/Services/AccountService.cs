﻿using Microsoft.Extensions.Logging;
using VFoody.Application.Common.Services;

namespace VFoody.Infrastructure.Services;

public class AccountService : IAccountService
{
    private readonly ILogger<AccountService> logger;

    public AccountService(ILogger<AccountService> logger)
    {
        this.logger = logger;
    }

    public void TestWriteLog()
    {
        this.logger.LogInformation("Log successly");
    }
}
