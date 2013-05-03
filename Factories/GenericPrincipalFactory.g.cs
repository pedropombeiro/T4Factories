namespace T4Factories
{
	public interface IGenericPrincipalFactory
	{
        System.Security.Principal.IPrincipal Create(System.Security.Principal.IIdentity identity, System.String[] roles);
    }

    public class GenericPrincipalFactory : IGenericPrincipalFactory
    {
		public System.Security.Principal.IPrincipal Create(System.Security.Principal.IIdentity identity, System.String[] roles)
		{
			return new System.Security.Principal.GenericPrincipal(identity, roles);
		}

	}
}
