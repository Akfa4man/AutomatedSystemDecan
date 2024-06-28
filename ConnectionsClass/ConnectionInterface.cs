namespace Приложение_для_деканата_v1
{
    public interface ConnectionInterface
    {
        string Server { get;  }
        int Port { get;  }
        string DataBase { get;  }
        string UserName { get;  }
        string Password { get;  }
    }
}
